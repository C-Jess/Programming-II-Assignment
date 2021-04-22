using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IInfoCards : IList<IInfoCard>
{
    bool Load(string fileName, GetFactory getFactory);
    void Save(string fileName);
}
