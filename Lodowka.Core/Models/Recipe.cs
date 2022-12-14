using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lodowka.Core.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Ingredients { get; set; }

        public int CookingTimeInMinutes { get; set; }

        public bool IsVegeterian { get; set; }

        public string Description { get; set; }
    }
}
