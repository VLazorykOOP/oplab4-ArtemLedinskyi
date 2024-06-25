using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alcohol
{
    public partial class AddForm : Form
    {
        private DatabaseHelper db;
        public AddForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Type = TypeText.Text;
                string Brand = BrandText.Text;
                string Manufacturer = ManText.Text;
                DateTime expirationDate = DateTime.Parse(ExpDateText.Text);
                string Supplier = SupText.Text;
                decimal Price = decimal.Parse(PriceText.Text);

                string query = $"INSERT INTO Sales(type, brand, manufacturer, expiration_date, supplier, price)" +
                    $"VALUES ('{Type}', '{Brand}' , '{Manufacturer}', '{expirationDate:yyyy-MM-dd}' , '{Supplier}', '{Price}') ";
                db.ExecuteNonQuery(query);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {
                MessageBox.Show($"Помилка: {ex.Message}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
