using _Business;
using _Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Forms
{
    public partial class ProductsForm : Form
    {
        // Product
        private ProductBusiness productBusiness;

        // Constructor
        public ProductsForm()
        {
            InitializeComponent();
            productBusiness = new ProductBusiness();
            UpdateGrid();
        }

        // Update Grid
        private void UpdateGrid()
        {
            dataGridView1.DataSource = productBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                Name = textName.Text,
                Price = decimal.Parse(textPrice.Text),
                Stock = int.Parse(textStock.Text)
            };
            productBusiness.Add(product);
            UpdateGrid();
        }

        // Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                Product update = productBusiness.Get(id);
                textName.Text = update.Name;
                textPrice.Text = update.Price.ToString();
                textStock.Text = update.Stock.ToString();
            }
        }

        // Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                Product save = productBusiness.Get(id);
                save.Name = textName.Text;
                save.Price = decimal.Parse(textPrice.Text);
                save.Stock = int.Parse(textStock.Text);
                productBusiness.Update(save);
                UpdateGrid();
            }
        }

        // Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                productBusiness.Delete(id);
                UpdateGrid();
            }
        }
    }
}
