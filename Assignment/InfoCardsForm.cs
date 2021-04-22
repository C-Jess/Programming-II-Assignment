using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

namespace Assignment
{
    public partial class InfoCardsForm : Form
    {
        const int NodeRoot = -1;
        const int NodeCategory = -2;
        const string InfoCardsFile = "infocards.txt";

        IInfoCards _infoCards = null;
        Dictionary<string, IInfoCardFactory> _infoCardFactories;
        IInfoCard _lastDisplayedCard = null;

        public InfoCardsForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!LoadCollectionClass())
            {
                MessageBox.Show("Unable to load the InfoCards class. The program is terminating");
                Application.Exit();
            }
            LoadInfoHandlers();
            if (!System.IO.File.Exists(InfoCardsFile))
            {
                if (MessageBox.Show("The Info Cards File does not exist. Do you wish to create a new one?", "Create New File?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                if (!_infoCards.Load(InfoCardsFile, GetInfoCardFactory))
                {
                    if (MessageBox.Show("An error occured loading the Info Cards file. Do you wish to continue?", "Error in Info Cards File", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
            }
            PopulateTreeView(null);
        }


        private void LoadInfoHandlers()
        {
            _infoCardFactories = new Dictionary<string, IInfoCardFactory>();

            // Get list of all dll files in same folder as main executable and
            // iterate through them seeing if any of them contain classes that
            // implement IInfoCardFactory.  
            string[] dllFiles = System.IO.Directory.GetFiles(".", "*.dll");
            foreach (string file in dllFiles)
            {
                Assembly assembly = Assembly.LoadFrom(file);
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.IsClass && type.GetInterface("IInfoCardFactory") != null)
                    {
                        // IInfoCardFactory is implemented. Create a new instance of the object
                        // and determine what categories are supported. Build the list of categories
                        // and the IInfoCardFactory that creates objects of that category type
                        IInfoCardFactory infoCardFactory = (IInfoCardFactory)Activator.CreateInstance(type);
                        string[] categoriesSupported = infoCardFactory.CategoriesSupported;
                        foreach (string category in categoriesSupported)
                        {
                            _infoCardFactories.Add(category, infoCardFactory);
                        }
                    }
                }
            }
        }

        private bool LoadCollectionClass()
        {
            bool collectionClassLoaded = false;
            // This code is specifically for this assignement.  It allows a compiled InfoCards class to be
            // supplied (in InfoCardsSupplied.dll).  If you provide your own (as described in Task 2), then
            // delete the one supplied and your version will be used instead
            string collectionClass = "InfoCardsSupplied.dll";
            if (!System.IO.File.Exists(collectionClass))
            {
                collectionClass = "InfoCards.dll";
                if (!System.IO.File.Exists(collectionClass))
                {
                    return false;
                }
            }
            Assembly assembly = Assembly.LoadFrom(collectionClass);
            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsClass && type.GetInterface("IInfoCards") != null)
                {
                    _infoCards = (IInfoCards)Activator.CreateInstance(type);
                    collectionClassLoaded = true;
                }
            }
            return collectionClassLoaded;
        }

        private void mainMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PopulateTreeView(string selectedKey)
        {
            Dictionary<string, TreeNode> mainNodes = new Dictionary<string, TreeNode>();
            TreeNode selectedNode = null;

            treeView.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Information Cards");
            rootNode.Tag = NodeRoot;
            treeView.Nodes.Add(rootNode);
            for (int i = 0; i < _infoCards.Count; i++)
            {
                IInfoCard infoCard = (IInfoCard)_infoCards[i];
                TreeNode categoryNode = null;
                if (!mainNodes.ContainsKey(infoCard.Category))
                {
                    categoryNode = new TreeNode(infoCard.Category);
                    categoryNode.Tag = NodeCategory;
                    rootNode.Nodes.Add(categoryNode);
                    mainNodes.Add(infoCard.Category, categoryNode);
                }
                else
                {
                    categoryNode = mainNodes[infoCard.Category];
                }
                TreeNode newNode = new TreeNode(infoCard.Name);
                if (infoCard.Name == selectedKey)
                {
                    selectedNode = newNode;
                }
                newNode.Tag = i;
                categoryNode.Nodes.Add(newNode);
            }
            treeView.ExpandAll();
            if (selectedNode != null)
            {
                treeView.SelectedNode = selectedNode;
            }
        }
        
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView.SelectedNode = e.Node;
                int nodeTag = (int)e.Node.Tag;
                if (nodeTag == NodeRoot)
                {
                    contextMenuRoot.Show(e.X + this.Location.X + splitContainer.Location.X, e.Y + this.Location.Y + splitContainer.Location.Y);
                }
                else
                {
                    if (nodeTag == NodeCategory)
                    {
                        contextMenuCategory.Show(e.X + this.Location.X + splitContainer.Location.X, e.Y + this.Location.Y + splitContainer.Location.Y);
                    }
                    else
                    {
                        contextMenuNode.Show(e.X + this.Location.X + splitContainer.Location.X, e.Y + this.Location.Y + splitContainer.Location.Y);
                    }
                }
            }
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView.SelectedNode = e.Node;
            DisplayCardData();
        }

        private void menuItemDisplay(object sender, EventArgs e)
        {
            DisplayCardData();
        }

        private void menuItemEdit(object sender, EventArgs e)
        {
            EditCardData();
        }

        private void contextMenuItemNewCard_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                CreateNewCard(treeView.SelectedNode.Text);
            }
        }

        private void menuItemNewCardFromList(object sender, EventArgs e)
        {
            ListCategoriesAndCreateCard();
        }

        private void menuItemDelete(object sender, EventArgs e)
        {
            DeleteInfoCard();
        }

        private void ListCategoriesAndCreateCard()
        {
            // Create a new card where the category is not known.  We need to display a window
            // listing all of the categories and their descrtiptions.  If the user selects a 
            // category, then we create a card of that category
            NewCard newCardForm = new NewCard();
            newCardForm.Factories = _infoCardFactories;
            if (newCardForm.ShowDialog() == DialogResult.OK)
            {
                CreateNewCard(newCardForm.SelectedCategory);
            }
            newCardForm.Dispose();
        }

        private void DisplayCardData()
        {
            if (treeView.SelectedNode != null)
            {
                int cardIndex = (int)treeView.SelectedNode.Tag;
                if (cardIndex >= 0)
                {
                    // If a card is currently displayed, close it
                    if (_lastDisplayedCard != null)
                    {
                        _lastDisplayedCard.CloseDisplay();
                        _lastDisplayedCard = null;
                    }
                    IInfoCard card = _infoCards[cardIndex];
                    card.DisplayData(panelInfoCard);
                    _lastDisplayedCard = card;
                }
            }
        }

        private void EditCardData()
        {
            if (treeView.SelectedNode != null)
            {
                int cardIndex = (int)treeView.SelectedNode.Tag;
                if (cardIndex >= 0)
                {
                    if (_lastDisplayedCard != null)
                    {
                        // Close any card currently displayed
                        _lastDisplayedCard.CloseDisplay();
                        _lastDisplayedCard = null;
                    }
                    IInfoCard card = _infoCards[cardIndex];
                    bool cardChanged = card.EditData();
                    if (cardChanged)
                    {
                        _infoCards[cardIndex] = card;
                        _infoCards.Save(InfoCardsFile);
                        PopulateTreeView(card.Name);
                    }
                }
            }
        }

        private void CreateNewCard(string category)
        {
            IInfoCard card = _infoCardFactories[category].CreateNewInfoCard(category);
            if (card.EditData())
            {
                _infoCards.Add(card);
                _infoCards.Save(InfoCardsFile);
                PopulateTreeView(card.Name);
            }
        }

        private void DeleteInfoCard()
        {
            // If a card is selected, display a message box asking if the user wants to delete this card.
            // If they select yes, delete the card from the collection, save the collection and repopulate 
            // the tree
            if (treeView.SelectedNode != null)
            {
                int cardIndex = (int)treeView.SelectedNode.Tag;
                if (cardIndex >= 0)
                {
                    IInfoCard card = _infoCards[cardIndex];
                    if (MessageBox.Show("Are you sure you want to delete " + card.Name + "?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (_lastDisplayedCard == card)
                        {
                            // If the card is currently displayed, make sure we close it
                            _lastDisplayedCard.CloseDisplay();
                            _lastDisplayedCard = null;
                        }
                        _infoCards.RemoveAt(cardIndex);
                        _infoCards.Save(InfoCardsFile);
                        PopulateTreeView(null);
                    }
                }

            }
        }

        public IInfoCardFactory GetInfoCardFactory(string category)
        {
            if (_infoCardFactories.ContainsKey(category))
            {
                return _infoCardFactories[category];
            }
            else
            {
                return null;
            }
        }
    }
}
