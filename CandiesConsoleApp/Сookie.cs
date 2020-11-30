using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesConsoleApp
{
    public class Сookie : NewYearsSweets, IComparable<NewYearsSweets>
    {
        public Сookie(string name, string manufacturer, float weight, float sugarPercentage,float flourPercentage)
            :base(name, manufacturer, weight, sugarPercentage)
        {
            FlourPercentage = flourPercentage;
        }

        public float FlourPercentage { get; set; }

        public int CompareTo(NewYearsSweets other)
        {
            return this.SugarPercentage.CompareTo(other.SugarPercentage);
        }

        public override string ShowProductsData()
        {
            return $"Product Name: {this.Name}, Product Manufacturer Name: {this.Manufacturer}, Weight per one thing: {this.Weight} gramms, Flour Percentage: {this.FlourPercentage}.";
        }
    }
}
