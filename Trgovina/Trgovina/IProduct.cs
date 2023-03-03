using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trgovina
{
    internal interface IProduct
    {
        int GetiID();
        string GetIme();
        double GetPrice();

    }
}
