namespace WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(48, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Име";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(49, 130);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(63, 30);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Цена";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(49, 224);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(117, 30);
            lblStock.TabIndex = 2;
            lblStock.Text = "Наличност";
            // 
            // txtName
            // 
            txtName.Location = new Point(48, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(344, 35);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(48, 163);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(344, 35);
            txtPrice.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(49, 257);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(344, 35);
            txtStock.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(47, 331);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(198, 49);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Добави";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(251, 331);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(198, 49);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Актуализирай";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(675, 331);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(198, 49);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Изтрий";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(461, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(198, 49);
            btnSave.TabIndex = 8;
            btnSave.Text = "Запис";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(427, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 37;
            dataGridView1.Size = new Size(808, 250);
            dataGridView1.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 408);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Name = "MainForm";
            Text = "Продукти 1.0";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPrice;
        private Label lblStock;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private DataGridView dataGridView1;
    }
}