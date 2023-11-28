using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Juggler
{
    public class Favorite
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Instruction { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Area { get; set; }
        public string Tag { get; set; }
        public string YouTube { get; set; }
        public string MealThumb { get; set; }
        public string Category { get; set; }

    }
}
