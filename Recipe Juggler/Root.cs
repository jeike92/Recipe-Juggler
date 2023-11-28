using System.Text.Json.Serialization;


namespace Recipe_Juggler
{

    public class Root
    {
        [JsonPropertyName("meals")]
        public Dictionary<string, string>[] Meals { get; set; }
        

        public string Id => Meals[0]["idMeal"];
        public string Name => Meals[0]["strMeal"];
        public string DrinkAlternate => Meals[0]["strDrinkAlternate"];
        public string Category => Meals[0]["strCategory"];
        public string Area => Meals[0]["strArea"];
        public string Instructions => Meals[0]["strInstructions"];
        public string MealThumb => Meals[0]["strMealThumb"];
        public string Tags => Meals[0]["strTags"];
        public string YoutubeLink => Meals[0]["strYoutube"];
        #region Ingredients 1-20
        public List<string> Ingredients 
        { 
            get 
            {
                List<string> result = new();
                    for (int i = 1; i <= 20; i++)
                    {
                    string value = this.Meals[0][$"strIngredient{i}"];
                        if (String.IsNullOrEmpty(value) == false)
                        {
                            result.Add(value);
                        }
                    }
                    return result;
            } 
        }
                    
        public string Ingredient1 => Meals[0]["strIngredient1"];
        public string Ingredient2 => Meals[0]["strIngredient2"];
        public string Ingredient3 => Meals[0]["strIngredient3"];
        public string Ingredient4 => Meals[0]["strIngredient4"];
        public string Ingredient5 => Meals[0]["strIngredient5"];
        public string Ingredient6 => Meals[0]["strIngredient6"];
        public string Ingredient7 => Meals[0]["strIngredient7"];
        public string Ingredient8 => Meals[0]["strIngredient8"];
        public string Ingredient9 => Meals[0]["strIngredient9"];
        public string Ingredient10 => Meals[0]["strIngredient10"];
        public string Ingredient11 => Meals[0]["strIngredient11"];
        public string Ingredient12 => Meals[0]["strIngredient12"];
        public string Ingredient13 => Meals[0]["strIngredient13"];
        public string Ingredient14 => Meals[0]["strIngredient14"];
        public string Ingredient15 => Meals[0]["strIngredient15"];
        public string Ingredient16 => Meals[0]["strIngredient16"];
        public string Ingredient17 => Meals[0]["strIngredient17"];
        public string Ingredient18 => Meals[0]["strIngredient18"];
        public string Ingredient19 => Meals[0]["strIngredient19"];
        public string Ingredient20 => Meals[0]["strIngredient20"];
        #endregion

        #region Measurements 1 - 20
        public List<string> Measurements
        {
            get
            {
                List<string> result = new();
                for (int i = 1; i <= 20; i++)
                {
                    string value = this.Meals[0][$"strMeasure{i}"];
                    if (String.IsNullOrEmpty(value) == false)
                    {
                        result.Add(value);
                    }
                }
                return result;
            }
        }
        public string Measure1 => Meals[0]["strMeasure1"];
        public string Measure2 => Meals[0]["strMeasure2"];
        public string Measure3 => Meals[0]["strMeasure3"];
        public string Measure4 => Meals[0]["strMeasure4"];
        public string Measure5 => Meals[0]["strMeasure5"];
        public string Measure6 => Meals[0]["strMeasure6"];
        public string Measure7 => Meals[0]["strMeasure7"];
        public string Measure8 => Meals[0]["strMeasure8"];
        public string Measure9 => Meals[0]["strMeasure9"];
        public string Measure10 => Meals[0]["strMeasure10"];
        public string Measure11 => Meals[0]["strMeasure11"];
        public string Measure12 => Meals[0]["strMeasure12"];
        public string Measure13 => Meals[0]["strMeasure13"];
        public string Measure14 => Meals[0]["strMeasure14"];
        public string Measure15 => Meals[0]["strMeasure15"];
        public string Measure16 => Meals[0]["strMeasure16"];
        public string Measure17 => Meals[0]["strMeasure17"];
        public string Measure18 => Meals[0]["strMeasure18"];
        public string Measure19 => Meals[0]["strMeasure19"];
        public string Measure20 => Meals[0]["strMeasure20"];
        #endregion

        
        public string Source => Meals[0]["strSource"];
        public string ImageSource => Meals[0]["strImageSource"];
        public string CreativeCommonsConfirmed => Meals[0]["strCreativeCommonsConfirmed"];
        public string DateModified => Meals[0]["dateModified"];


    }
}
