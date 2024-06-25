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
    public partial class DeleteForm : Form
    {
        private DatabaseHelper db;
        public DeleteForm()
        {
            InitializeComponent();
            db = new DatabaseHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(IDText.Text);
                string query = $"DELETE FROM Sales WHERE id = {ID}";
                db.ExecuteNonQuery(query);
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
