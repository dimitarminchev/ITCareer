using Business;
using Data.Model;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        private int editId = 0;

        private ProductBusiness productBusiness = new ProductBusiness();

        /// <summary>
        ///  Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Update Table
        /// </summary>
        private void UpdateGrid()
        {
            dataGridView1.DataSource = productBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Clear Text Boxes
        /// </summary>
        private void ClearTextBoxes()
        {
            txtName.Text = string.Empty;
            txtPrice.Text = "0";
            txtStock.Text = "0";
        }

        /// <summary>
        /// SAve or Update Button Visible
        /// </summary>
        private void ToggleSaveUpdate()
        {
            if (btnUpdate.Visible)
            {
                btnUpdate.Visible = false;
                btnSave.Visible = true;
            }
            else
            {
                btnUpdate.Visible = true;
                btnSave.Visible = false;
            }
        }

        /// <summary>
        /// UpdateTextboxes
        /// </summary>
        private void UpdateTextboxes(int id)
        {
            Product product = productBusiness.Get(id);
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtStock.Text = product.Stock.ToString();
        }

        /// <summary>
        /// Disable Select in GridView
        /// </summary>
        private void DisableSelect()
        {
            dataGridView1.Enabled = false;
        }

        /// <summary>
        /// Reset Select
        /// </summary>
        private void ResetSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }

        /// <summary>
        /// Get Edited Product
        /// </summary>
        private Product GetEditedProduct()
        {
            // data
            string name = txtName.Text;

            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);

            int stock = 0;
            int.TryParse(txtStock.Text, out stock);

            // product
            var product = new Product();
            product.Id = editId;
            product.Name = name;
            product.Price = price;
            product.Stock = stock;

            return product;
        }

        /// <summary>
        /// Main Page Load
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            ClearTextBoxes();
        }

        /// <summary>
        /// Insert
        /// </summary>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // data
            string name = txtName.Text;

            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);

            int stock = 0;
            int.TryParse(txtStock.Text, out stock);

            // product
            var product = new Product();
            product.Name = name;
            product.Price = price;
            product.Stock = stock;

            // process
            productBusiness.Add(product);
            UpdateGrid();
            ClearTextBoxes();
        }

        /// <summary>
        /// Update
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 0 = id, 1 = name, 2 = price, 3 = stock
                var item = dataGridView1.SelectedRows[0].Cells;

                int id = int.Parse(item[0].Value.ToString());
                editId = id;

                UpdateTextboxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        /// <summary>
        /// Save
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = GetEditedProduct();

            productBusiness.Update(product);

            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
        }

        /// <summary>
        ///  Delete
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 0 = id, 1 = name, 2 = price, 3 = stock
                var item = dataGridView1.SelectedRows[0].Cells;

                // Get selected product from the grid
                var id = int.Parse(item[0].Value.ToString());

                // Delete
                productBusiness.Delete(id);

                // Update UI
                UpdateGrid();
                ResetSelect();
            }
        }

    }
}