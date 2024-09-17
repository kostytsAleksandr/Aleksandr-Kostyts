using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesConsoleApp
{
    class DarkChokolateBar : ChokolateBar, IComparable<NewYearsSweets>
    {
        public DarkChokolateBar(string name, string manufacturer, float weight, float sugarPercentage, float cocoaPercentage, bool isContainNuts)
            : base(name, manufacturer, weight, sugarPercentage, cocoaPercentage)
        {
            this.IsContainNuts = isContainNuts;
        }

        public bool IsContainNuts { get; set; }

        public int CompareTo(NewYearsSweets other)
        {
            return this.SugarPercentage.CompareTo(other.SugarPercentage);
        }

        public override string ShowProductsData()
        {
            return $"Product Name: {this.Name}, Product Manufacturer Name: {this.Manufacturer}, Weight per one thing: {this.Weight} gramms," +
                $"Cocoa percentage: {this.CocoaPercentage}, Contains Nuts: {this.IsContainNuts}.";
        }
    }
}
