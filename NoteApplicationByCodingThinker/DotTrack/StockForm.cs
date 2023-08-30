using System.Data.SqlClient;
using System.Data;

namespace DotTrack
{
    public partial class StockForm : Form
    {
        Product selectedProduct;
        public StockForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#dbdef1");
            productsLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#050f3d");
            titleLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#050f3d");
            noteLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#050f3d");
            productsDataGrid.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#edeff8");

            productsDataGrid.DataSource = null;
            productsDataGrid.DataSource = GetProducts();

        }

        private void ClearInputs()
        {
            nameTextBox.Text = String.Empty;
            priceTextBox.Text = String.Empty;
            stockTextBox.Text = String.Empty;
            descriptionTextBox.Text = String.Empty;
        }

        private List<Product> GetProducts()
        {
            var productList = new List<Product>();
            SqlConnection connection = new SqlConnection("server = .\\SQLExpress; database= ProductDb; integrated security = true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * From Products";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var product = new Product();
                product.Id = Convert.ToInt32(reader[0]);
                product.Name = Convert.ToString(reader[1]);
                product.Price = Convert.ToInt32(reader[2]);
                product.Stock = Convert.ToInt32(reader[3]);
                product.Description = Convert.ToString(reader[4]);
                productList.Add(product);
            }


            reader.Close();
            connection.Close();
            command.Parameters.Clear();
            return productList;

        }

        public void RefreshDataGrid()
        {
            var products = GetProducts();
            productsDataGrid.DataSource = null;
            productsDataGrid.DataSource = products;

        }


        private int UpdateProduct(string name, int price, int stock, string description,Product selectedProduct)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=ProductDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Update Products set Name= @name, Price= @price, Stock=@stock, Description=@description where Id=@productid";
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@stock", stock);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@productid", selectedProduct.Id);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();

            return affectedRows;
        }

        private int InsertProduct(String name, int price, int stock, string description)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=ProductDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into Products (Name, Price,Stock, Description) values (@name, @price,@stock, @description)";
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@stock", stock);
            command.Parameters.AddWithValue("@description", description);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();

            return affectedRows;

        }

        private int DeleteNote(Product selectedProduct)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=ProductDb; integrated security=true;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from Products where Id=@productid";
            command.Parameters.AddWithValue("@productid", selectedProduct.Id);

            connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
            return affectedRows;
        }

        private void logOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            this.Visible = false;
            form.ShowDialog();
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void productsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = productsDataGrid.Rows[e.RowIndex]; //hangi satýra týklandýysa o row id yi verir yani seçili olan satýrý getirir.
                if (row != null)
                {
                    selectedProduct = new Product();
                    selectedProduct.Id = (int)(row.Cells[0].Value);
                    selectedProduct.Name = row.Cells[1].Value.ToString();
                    selectedProduct.Price = (int)(row.Cells[2].Value);
                    selectedProduct.Stock = (int)(row.Cells[3].Value);
                    selectedProduct.Description = row.Cells[4].Value.ToString();
                }

                nameTextBox.Text = selectedProduct.Name;
                priceTextBox.Text = selectedProduct.Price.ToString();
                stockTextBox.Text = selectedProduct.Stock.ToString();
                descriptionTextBox.Text = selectedProduct.Description;
            }


        }

        private void newProductButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
            selectedProduct = null;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(priceTextBox.Text)
                && !string.IsNullOrEmpty(descriptionTextBox.Text) && !string.IsNullOrEmpty(stockTextBox.Text))
            {
                int affectedRows = InsertProduct(nameTextBox.Text, Convert.ToInt32(priceTextBox.Text), 
                                                    Convert.ToInt32(stockTextBox.Text), descriptionTextBox.Text);
                ClearInputs();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid();
                }

            }
            else
            {
                MessageBox.Show("Name, Price, Stock and Description fields cannot be blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (selectedProduct != null)
            {
                int affectedRows =  DeleteNote(selectedProduct);
                ClearInputs();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select the product you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(priceTextBox.Text)
                     && !string.IsNullOrEmpty(descriptionTextBox.Text) && !string.IsNullOrEmpty(stockTextBox.Text))
                {
                    int affectedRows = UpdateProduct(nameTextBox.Text, Convert.ToInt32(priceTextBox.Text), 
                                                        Convert.ToInt32(stockTextBox.Text), descriptionTextBox.Text, selectedProduct);
                    ClearInputs();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGrid();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select the product you want to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}