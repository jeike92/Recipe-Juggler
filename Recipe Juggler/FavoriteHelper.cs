using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Recipe_Juggler
{
    internal class FavoriteHelper
    {
        public List<Favorite> Favorites;
        public void SaveData()
        {
            string filePath = "favorites.json";

            List<Favorite> existingData = new List<Favorite>();
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                existingData = JsonSerializer.Deserialize<List<Favorite>>(existingJson);
            }

            existingData.AddRange(Favorites);
            string json = JsonSerializer.Serialize(existingData);
            File.WriteAllText("favorites.json", json);

        }
    }
}
