using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_1
{
    public partial class Form1 : Form
    {
        public readonly CategoriesCrud _categoriesCrud;
        public Form1()
        {
            InitializeComponent();
            _categoriesCrud = new CategoriesCrud();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _categoriesCrud.GetAllCategoies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var categoryName = categoryNameTextBox.Text;
                var categoryDescription = categoryDescriptionTextBox.Text;
                _categoriesCrud.InsertCategory(categoryName, categoryDescription);
                dataGridView1.DataSource = _categoriesCrud.GetAllCategoies();
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var current_index = dataGridView1.CurrentRow.Index;
                var category_id = Convert.ToInt32(dataGridView1.Rows[current_index].Cells[0].Value);
                _categoriesCrud.RemoveCategory(category_id);
                dataGridView1.DataSource = _categoriesCrud.GetAllCategoies();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var categoryName = categoryNameTextBox.Text;
                var categoryDescription = categoryDescriptionTextBox.Text;
                var current_index = dataGridView1.CurrentRow.Index;
                var category_id = Convert.ToInt32(dataGridView1.Rows[current_index].Cells[0].Value);
                _categoriesCrud.UpdateCategory(category_id, categoryName, categoryDescription);
                dataGridView1.DataSource = _categoriesCrud.GetAllCategoies();
            }
        }
    }
}
