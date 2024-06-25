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
    
    public partial class EditForm : Form
    {
        private DatabaseHelper db;
        public EditForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(IDText.Text);
                string Type = TypeText.Text;
                string Brand = BrandText.Text;
                string Manufacturer = ManText.Text;
                DateTime expirationDate = DateTime.Parse(ExpDateText.Text);
                string Supplier = SupText.Text;
                decimal Price = decimal.Parse(PriceText.Text);

                string query = $"UPDATE Sales SET type='{Type}', brand='{Brand}', manufacturer='{Manufacturer}', expiration_date='{expirationDate:yyyy-MM-dd}', supplier='{Supplier}', price={Price} WHERE id={ID}";
                db.ExecuteNonQuery(query);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
