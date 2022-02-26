using Business;
using Data.Model;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        // Контекста на базата данни
        private ProductBusiness productBusiness = new ProductBusiness();

        // Идентификатор на продукта
        private int editId = 0;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            UpdateGrid();
            ClearTextBoxes();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        /// <summary>
        /// Зарежда информацията от базата данни
        /// </summary>
        private void UpdateGrid()
        {
            dataGridView1.DataSource = productBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Изчистваме текстовите полета
        /// </summary>
        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
        }

        /// <summary>
        /// Добави
        /// </summary>
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text),
                Stock = int.Parse(txtStock.Text)
            };
            productBusiness.Add(product);

            UpdateGrid();
            ClearTextBoxes();
        }

        /// <summary>
        /// Актуализация
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                editId = id;
                UpdateTextboxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }

        /// <summary>
        /// Актуализация на текстовите кутийки
        /// </summary>
        private void UpdateTextboxes(int id)
        {
            txtName.Text = productBusiness.Get(id).Name;
            txtPrice.Text = productBusiness.Get(id).Price.ToString();
            txtStock.Text = productBusiness.Get(id).Stock.ToString();
        }

        /// <summary>
        /// Смяна на бутоните Save и Update
        /// </summary>
        private void ToggleSaveUpdate()
        {
            if (btnUpdate.Enabled)
            {
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
            }
        }

        private void DisableSelect()
        {
            dataGridView1.Enabled = false;
        }

        /// <summary>
        /// Изтриване
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                productBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        private void ResetSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }


        /// <summary>
        /// Запис
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Product editedProduct = GetEditedProduct();
            productBusiness.Update(editedProduct);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
        }

        private Product GetEditedProduct()
        {
            Product product = new Product();
            product.Id = editId;

            var name = txtName.Text;
            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);
            int stock = 0;
            int.TryParse(txtStock.Text, out stock);
            product.Name = name;
            product.Price = price;
            product.Stock = stock;

            return product;
        }
    }
}