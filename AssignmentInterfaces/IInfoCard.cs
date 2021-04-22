using System;
using System.Windows.Forms;

public interface IInfoCard
{
    string Name { get; set; }
    string Category { get; }
    string GetDataAsString();
    void DisplayData(Panel displayPanel);
    void CloseDisplay();
    bool EditData();
}
