using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IInfoCardFactory
{
    IInfoCard CreateNewInfoCard(string category);
    IInfoCard CreateInfoCard(string initialDetails);
    string[] CategoriesSupported { get; }
    string GetDescription(string category);
}
