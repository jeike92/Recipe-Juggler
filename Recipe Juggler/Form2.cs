using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Juggler
{
    public partial class Form2 : Form
    {
        public Form2(List<Favorite> favList)
        {
            InitializeComponent();
            dataGridView1.DataSource = favList;

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                Favorite selectedFavorite = dataGridView1.Rows[e.RowIndex].DataBoundItem as Favorite;

                Form1 form1Instance = Application.OpenForms.OfType<Form1>().FirstOrDefault();

                if (form1Instance != null)
                {
                    form1Instance.UpdateFavDataFromForm2(selectedFavorite);
                }

                this.Close();
            }
        }

        private void btnRemoveFavorite_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Remove the selected row from the data source
                
            }
        }
    }
}
