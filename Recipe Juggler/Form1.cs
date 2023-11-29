using System.Diagnostics;
using System.Net;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;


namespace Recipe_Juggler
{
    public partial class Form1 : Form
    {
        private List<Favorite> Favorites = new List<Favorite>();

        private List<Favorite> History = new List<Favorite>();
        public int count { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadAndDeserializeApiResponse();
            SetObjects();
            LoadData();
        }

        private void SetObjects()
        {
            lblName.Text = History[count].Name;

            lblArea.Text = History[count].Area;

            lblId.Text = History[count].Id;

            lblCategory.Text = History[count].Category;

            lblTags.Text = History[count].Tag;

            rtbInstructions.Text = History[count].Instruction;

            dataGridView1.DataSource = History[count].Ingredients;

            #region PictureBox
            string imageUrl = History[count].MealThumb;
            try
            {
                WebClient webClient = new();
                byte[] data = webClient.DownloadData(imageUrl);

                using var stream = new System.IO.MemoryStream(data);
                Image image = Image.FromStream(stream);
                pbThumb.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
            #endregion
        }
        public void ReadAndDeserializeApiResponse()
        {
            HttpClient client = new();
            HttpResponseMessage response = client.GetAsync("https://www.themealdb.com/api/json/v1/1/random.php").Result;

            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            Root? post = JsonSerializer.Deserialize<Root>(responseBody);


            #region Konkatenierte Listen
            int i = 0;

            List<Ingredient> zutatenz = new List<Ingredient>();

            foreach (var item in post.Ingredients)
            {
                zutatenz.Add(new Ingredient { Ingredients = item.Trim(), Measurments = post.Measurements[i].Trim() });
                i++;
            }
            #endregion

            #region History
            Favorite newHistory = new Favorite()
            {
                Id = post.Id,
                Name = post.Name,
                Ingredients = zutatenz,
                Instruction = post.Instructions,
                Area = post.Area,
                Tag = post.Tags,
                YouTube = post.YoutubeLink,
                MealThumb = post.MealThumb,
                Category = post.Category,

            };
            History.Add(newHistory);
            count = History.Count - 1;
            #endregion


        }

        private void BtnLucky_Click(object sender, EventArgs e)
        {
            ReadAndDeserializeApiResponse();
            SetObjects();
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            AddFavorite(History[count]);
        }

        public void AddFavorite(Favorite history)
        {
            Favorite newFav = new Favorite
            {
                Id = history.Id,
                Name = history.Name,
                Ingredients = history.Ingredients,
                Instruction = history.Instruction,
                MealThumb = history.MealThumb,
                YouTube = history.YouTube,
                Area = history.Area,
                Tag = history.Tag,
                Category = history.Category,

            };


            bool shouldAdd = true;
            foreach (Favorite fav in Favorites)
            {
                if (fav.Id == newFav.Id)
                {
                    shouldAdd = false; break;
                }
            }

            if (shouldAdd)
            {
                Favorites.Add(newFav);
                SaveData(newFav);
            }

        }

        public void SaveData(Favorite newFav)
        {
            string filePath = "favorites.json";

            List<Favorite> existingData = new List<Favorite>();
            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                existingData = JsonSerializer.Deserialize<List<Favorite>>(existingJson);
            }

            existingData.Add(newFav);

            string json = JsonSerializer.Serialize(existingData);
            File.WriteAllText("favorites.json", json);

        }

        public void LoadData()
        {
            try
            {

                if (File.Exists("favorites.json"))
                {
                    string json = File.ReadAllText("favorites.json");
                    Favorites = JsonSerializer.Deserialize<List<Favorite>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SaveData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            count++;
            if (count > History.Count - 1)
            {
                MessageBox.Show("Bitte den Lucky button benutzen!");
                count--;
            }
            else
            {
                SetObjects();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            --count;
            if (count < 0)
            {
                MessageBox.Show("Davor gibt es nichts!");
                count++;
            }
            else
            {
                SetObjects();
            }

        }

        private void btnShowFavorites_Click(object sender, EventArgs e)
        {
            LoadData();
            Form2 fav = new Form2(Favorites);
            fav.Show();


        }

        public void UpdateFavDataFromForm2(Favorite f)
        {
            History.Add(f);
            count++;
            SetObjects();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(History[count].YouTube);
        }
    }
}