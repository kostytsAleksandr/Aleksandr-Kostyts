using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesConsoleApp
{
    class ChokolatsCandy : Waffles, IComparable<NewYearsSweets>
    {
        public int CompareTo(NewYearsSweets other)
        {
            return this.SugarPercentage.CompareTo(other.SugarPercentage);
        }
    }
    }
