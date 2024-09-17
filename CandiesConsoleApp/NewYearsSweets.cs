using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesConsoleApp
{
    public class NewYearsSweets
    {
        public NewYearsSweets(string name, string manufacturer, float weight, float sugarPercentage)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Weight = weight;
            this.SugarPercentage = sugarPercentage;
        }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public float Weight { get; set; }

        public float SugarPercentage { get; set; }


        public virtual string ShowProductsData()
        {
            return $"Product Name: {Name}, Product Manufacturer Name: {Manufacturer}, Weight per one thing: {Weight} gramms.";
        }
    }
}
