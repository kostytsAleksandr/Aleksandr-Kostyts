using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesConsoleApp
{
    class MilkChokolateBar : DarkChokolateBar, IComparable<NewYearsSweets>
    {
        public MilkChokolateBar(string name, string manufacturer, float weight, float sugarPercentage, float cocoaPercentage, bool isContainNuts, float driedMilk)
         : base(name, manufacturer, weight, sugarPercentage, cocoaPercentage, isContainNuts)
        {
            this.DriedMilk = driedMilk;
        }

        public float DriedMilk { get; set; }

        public int CompareTo(NewYearsSweets other)
        {
            return this.SugarPercentage.CompareTo(other.SugarPercentage);
        }

        public override string ShowProductsData()
        {
            return $"Product Name: {this.Name}, Product Manufacturer Name: {this.Manufacturer}, Weight per one thing: {this.Weight} gramms," +
                $"Cocoa percentage: {this.CocoaPercentage}, Contains Nuts: {this.IsContainNuts}, Dried Milk Percentage: {this.DriedMilk}.";
        }
    }
}
