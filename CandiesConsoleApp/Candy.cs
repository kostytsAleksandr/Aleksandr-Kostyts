using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesConsoleApp
{
    public class Candy : NewYearsSweets, IComparable<NewYearsSweets>
    {
        public Candy(string name, string manufacturer, float weight, float sugarPercentage, bool isContainsNuts, bool isContainsRaisins)
             : base(name, manufacturer, weight, sugarPercentage)
        {
            this.IsContainsNuts = isContainsNuts;
            this.IsContainsRaisins = isContainsRaisins;
        }

        public bool IsContainsNuts { get; set; }

        public bool IsContainsRaisins { get; set; }

        public int CompareTo(NewYearsSweets other)
        {
            return this.SugarPercentage.CompareTo(other.SugarPercentage);
        }

        public override string ShowProductsData()
        {
            return $"Product Name: {this.Name}, Product Manufacturer Name: {this.Manufacturer}, Weight per one thing: {this.Weight} gramms," +
                $"Contains Raisins: {this.IsContainsRaisins}, Contains Nuts: {this.IsContainsNuts}.";
        }
    }
}
