using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesConsoleApp
{
    class ChokolateCookie: Сookie, IComparable<NewYearsSweets>
    {
        public ChokolateCookie(string name, string manufacturer, float weight, float sugarPercentage, float flourPercentage, float chokolatePercentage)
            :base(name, manufacturer, weight, sugarPercentage, flourPercentage)
        {
            this.ChokolatePercentage = chokolatePercentage;
        }

        public float ChokolatePercentage { get; set; }

        public int CompareTo(NewYearsSweets other)
        {
            return this.SugarPercentage.CompareTo(other.SugarPercentage);
        }

        public override string ShowProductsData()
        {
            return $"Product Name: {this.Name}, Product Manufacturer Name: {this.Manufacturer}, Weight per one thing: {this.Weight} gramms, Flour Percentage: {this.FlourPercentage}, Chokolate Percentage: {this.ChokolatePercentage}.";
        }
    }
}
