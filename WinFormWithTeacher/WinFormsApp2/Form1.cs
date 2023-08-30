using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Product selectedProduct;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new List<Product>
            {
                new Product { Id=1, Name ="Samsung", Price = 1500},
                new Product {Id =2, Name="iPhone", Price = 6000}
            };
            dataGridView1.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#e8d0c3");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row != null)
                {
                    selectedProduct = new Product();
                    selectedProduct.Id = (int)row.Cells[0].Value;
                    selectedProduct.Name = (string)row.Cells[1].Value;
                    selectedProduct.Price = (int)row.Cells[2].Value;

                    textBox1.Text = selectedProduct.Name;
                    textBox2.Text = selectedProduct.Price.ToString();
                }

            }
            
        }
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

}