using System;
using System.Data;
using System.Windows.Forms;

namespace Alcohol
{
    public partial class Form1 : Form
    {
        private DatabaseHelper db;
        public Form1()
        {
            InitializeComponent();
            db = new DatabaseHelper();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Sales";
            DataTable dt = db.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
                EditForm editForm = new EditForm();
                editForm.ShowDialog();
               
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog(); 
            
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
