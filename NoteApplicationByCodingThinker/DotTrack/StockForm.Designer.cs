namespace DotTrack
{
    partial class StockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            productsLabel = new Label();
            productsDataGrid = new DataGridView();
            editButton = new Button();
            deleteButton = new Button();
            newProductButton = new Button();
            saveButton = new Button();
            noteLabel = new Label();
            titleLabel = new Label();
            priceTextBox = new TextBox();
            nameTextBox = new TextBox();
            logOutLabel = new LinkLabel();
            label1 = new Label();
            descriptionTextBox = new TextBox();
            label2 = new Label();
            stockTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            productsLabel.Location = new Point(70, 29);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(77, 23);
            productsLabel.TabIndex = 0;
            productsLabel.Text = "Products";
            // 
            // productsDataGrid
            // 
            productsDataGrid.AllowUserToAddRows = false;
            productsDataGrid.AllowUserToDeleteRows = false;
            productsDataGrid.BackgroundColor = SystemColors.Control;
            productsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGrid.Location = new Point(33, 67);
            productsDataGrid.Margin = new Padding(3, 4, 3, 4);
            productsDataGrid.Name = "productsDataGrid";
            productsDataGrid.ReadOnly = true;
            productsDataGrid.RowHeadersWidth = 51;
            productsDataGrid.RowTemplate.Height = 25;
            productsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGrid.Size = new Size(396, 367);
            productsDataGrid.TabIndex = 10;
            productsDataGrid.CellClick += productsDataGrid_CellClick;
            // 
            // editButton
            // 
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.ForeColor = Color.DarkBlue;
            editButton.Location = new Point(86, 448);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(109, 36);
            editButton.TabIndex = 7;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.ForeColor = Color.DarkBlue;
            deleteButton.Location = new Point(257, 445);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(109, 36);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // newProductButton
            // 
            newProductButton.FlatStyle = FlatStyle.Flat;
            newProductButton.ForeColor = Color.DarkBlue;
            newProductButton.Location = new Point(692, 442);
            newProductButton.Margin = new Padding(3, 4, 3, 4);
            newProductButton.Name = "newProductButton";
            newProductButton.Size = new Size(109, 36);
            newProductButton.TabIndex = 6;
            newProductButton.Text = "New Product";
            newProductButton.UseVisualStyleBackColor = true;
            newProductButton.Click += newProductButton_Click;
            // 
            // saveButton
            // 
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.ForeColor = Color.DarkBlue;
            saveButton.Location = new Point(525, 442);
            saveButton.Margin = new Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(109, 36);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            noteLabel.ForeColor = Color.DarkBlue;
            noteLabel.Location = new Point(489, 118);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(51, 23);
            noteLabel.TabIndex = 29;
            noteLabel.Text = "Price:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(489, 44);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(60, 23);
            titleLabel.TabIndex = 28;
            titleLabel.Text = "Name:";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(489, 145);
            priceTextBox.Margin = new Padding(3, 4, 3, 4);
            priceTextBox.Multiline = true;
            priceTextBox.Name = "priceTextBox";
            priceTextBox.PlaceholderText = "Product's selling price";
            priceTextBox.Size = new Size(365, 32);
            priceTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(489, 71);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Product's Name";
            nameTextBox.Size = new Size(365, 27);
            nameTextBox.TabIndex = 1;
            // 
            // logOutLabel
            // 
            logOutLabel.ActiveLinkColor = Color.RoyalBlue;
            logOutLabel.AutoSize = true;
            logOutLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            logOutLabel.ForeColor = SystemColors.ControlText;
            logOutLabel.LinkColor = Color.MidnightBlue;
            logOutLabel.Location = new Point(418, 492);
            logOutLabel.Name = "logOutLabel";
            logOutLabel.Size = new Size(84, 25);
            logOutLabel.TabIndex = 9;
            logOutLabel.TabStop = true;
            logOutLabel.Text = "Log Out";
            logOutLabel.VisitedLinkColor = Color.Navy;
            logOutLabel.LinkClicked += logOutLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(489, 280);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 31;
            label1.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(489, 307);
            descriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Product's description";
            descriptionTextBox.Size = new Size(365, 32);
            descriptionTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(489, 200);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 33;
            label2.Text = "Stock:";
            // 
            // stockTextBox
            // 
            stockTextBox.Location = new Point(489, 227);
            stockTextBox.Margin = new Padding(3, 4, 3, 4);
            stockTextBox.Multiline = true;
            stockTextBox.Name = "stockTextBox";
            stockTextBox.PlaceholderText = "Product's quantity";
            stockTextBox.Size = new Size(365, 32);
            stockTextBox.TabIndex = 3;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 541);
            Controls.Add(label2);
            Controls.Add(stockTextBox);
            Controls.Add(label1);
            Controls.Add(descriptionTextBox);
            Controls.Add(editButton);
            Controls.Add(deleteButton);
            Controls.Add(newProductButton);
            Controls.Add(saveButton);
            Controls.Add(noteLabel);
            Controls.Add(titleLabel);
            Controls.Add(priceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(logOutLabel);
            Controls.Add(productsDataGrid);
            Controls.Add(productsLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "StockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DotTrack";
            FormClosed += StockForm_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productsLabel;
        private DataGridView productsDataGrid;
        private Button editButton;
        private Button deleteButton;
        private Button newProductButton;
        private Button saveButton;
        private Label noteLabel;
        private Label titleLabel;
        private TextBox priceTextBox;
        private TextBox nameTextBox;
        private LinkLabel logOutLabel;
        private Label label1;
        private TextBox descriptionTextBox;
        private Label label2;
        private TextBox stockTextBox;
    }
}