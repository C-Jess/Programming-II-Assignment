using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Assignment
{
    public class InfoCards : List<IInfoCard>, IInfoCards
    {
        public bool Load(string fileName, GetFactory getFactory)
        {
            bool status = true;
            StreamReader inputFile = null;
            string inputLine;

            try
            {
                inputFile = new StreamReader(fileName);
                if (inputFile != null)
                {
                    inputLine = inputFile.ReadLine();
                    while (inputLine != null && status)
                    {
                        int tabPosition = inputLine.IndexOf('|');
                        if (tabPosition != -1)
                        {
                            string key = inputLine.Substring(0, tabPosition);
                            IInfoCardFactory infoCardFactory = getFactory(key);
                            if (infoCardFactory != null)
                            {
                                this.Add(infoCardFactory.CreateInfoCard(inputLine));
                            }
                            else
                            {
                                // We've found a category we do not know how to handle. Report
                                // an error reading the file
                                Debug.WriteLine("Unrecognised category in file: " + key);
                                status = false;
                            }
                        }
                        else
                        {
                            // Check to see if the line is blank.  If it is, just ignore it. Otherwise,
                            // the line does not seem to include a category. Report an error reading the file
                            if (inputLine.Length != 0)
                            {
                                Debug.WriteLine("No category on line " + inputLine);
                                status = false;
                            }
                        }
                        if (status)
                        {
                            inputLine = inputFile.ReadLine();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception occurred while loading file: " + e.ToString());
                status = false;
            }
            finally
            {
                if (inputFile != null)
                {
                    inputFile.Close();
                    inputFile.Dispose();
                }
            }
            return status;
        }

        public void Save(string fileName)
        {
            StreamWriter outputFile = null;
            string lineToOutput;

            try
            {
                outputFile = new StreamWriter(fileName, false);
                if (outputFile != null)
                {
                    foreach (IInfoCard infoCard in this)
                    {
                        lineToOutput = infoCard.GetDataAsString();
                        outputFile.WriteLine(lineToOutput);
                    }
                    outputFile.Close();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception occurred while saving file: " + e.ToString());
            }
            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                    outputFile.Dispose();
                }
            }
        }

    }
}
