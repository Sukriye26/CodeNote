using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = new List<Category>()
            {
                new Category{Id =1, Description="Aksesuar" },
                new Category{Id =2,Description ="Giyim"},
                new Category{Id =3,Description= "Ayakkabý"}
            };

            listBox1.DataSource = list;
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var button = (Button)sender;
            //var data = (string)button.Tag;
            //Console.WriteLine("");
            //comboBox1.Items.AddRange(new object[] { "Deneme", "Deneme", "Deneme" });
            //MessageBox.Show("tag= " + data);
            //// MessageBox.Show("týkladýn");
            //Console.WriteLine("");

            Button button12 = new Button();

            ComboBox comboBox12 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button12.Location = new Point(320, 218);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            //button12.TabIndex = 0;
            button12.Tag = "Tag12";
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;

            comboBox12.FormattingEnabled = true;
            comboBox12.Items.AddRange(new object[] { "Deneme", "Deneme", "Deneme" });
            comboBox12.Location = new Point(82, 260);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(151, 28);
            //comboBox12.TabIndex = 1;
            Controls.Add(comboBox12);
            Controls.Add(button12);
            Console.WriteLine("");



        }

        private void button12_Click(object? sender, EventArgs e)
        {
            Button button13 = new Button();
            button13.Location = new Point(320, 218);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            //button12.TabIndex = 0;
            button13.Tag = "Tag13";
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            //button13.Click += button13_Click;
            MessageBox.Show("týkladýn");

            Form form = new Form();
            form.Controls.Clear();
            form.Text = "form 2";
            form.Controls.Add(button13);
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var list = new List<Category>()
            {
                new Category{Id =1, Description="Aksesuar" },
                new Category{Id =2,Description ="Giyim"},
                new Category{Id =3,Description= "Ayakkabý"}
            };
            foreach (var category in list)
            {
                comboBox2.Items.Add(category); // bu þekilde item'ý ekledi.
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var list = new List<Category>()
            {
                new Category{Id =1, Description="Aksesuar" },
                new Category{Id =2,Description ="Giyim"},
                new Category{Id =3,Description= "Ayakkabý"}
            };
            foreach (var category in list)
            {
                comboBox2.Items.Add(category.Description); // bu þekilde kategorinin açýklamasýný ekledi.
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var list = new List<Category>()
            {
                new Category{Id =1, Description="Aksesuar" },
                new Category{Id =2,Description ="Giyim"},
                new Category{Id =3,Description= "Ayakkabý"}
            };

            comboBox2.DataSource = list;
            comboBox2.DisplayMember = "Description";
            comboBox2.ValueMember = "Id";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                var itemValue = (Category)comboBox2.SelectedItem;
                MessageBox.Show("seçilen id: " + itemValue.Id);
            }

            //burda nesne var tüm propertyleri ile
            var textValue = comboBox2.SelectedText;
            //MessageBox.Show(textValue); // index changed olduðu için text boþ
            var selectedValue = comboBox2.SelectedValue;
            //burda id var 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var itemValue = (Category)listBox1.SelectedItem;
                MessageBox.Show("seçilen id: " + itemValue.Id);
                textBox1.Text = itemValue.Description;
            }
        }
           
    }
    public class Category
    {
        public int Id { get; set; }
        public string Description { get; set; }

    }

    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}