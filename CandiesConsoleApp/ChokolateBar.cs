using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesConsoleApp
{
    //public class ChokolateBar : NewYearsSweets, IComparable<NewYearsSweets>
    {
        public ChokolateBar(string name, string manufacturer, float weight, float sugarPercentage, float cocoaPercentage)
            : base(name, manufacturer, weight, sugarPercentage)
        {
            this.CocoaPercentage = cocoaPercentage;
        }

        public float CocoaPercentage { get; set; }

        public int CompareTo(NewYearsSweets other)
        {
            return this.SugarPercentage.CompareTo(other.SugarPercentage);
        }

        public override string ShowProductsData()
        {
            return $"Product Name: {this.Name}, Product Manufacturer Name: {this.Manufacturer}, Weight per one thing: {this.Weight} gramms," +
                $"Cocoa percentage: {this.CocoaPercentage}.";
        }
    }
}
