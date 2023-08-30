namespace WinFormNotePad
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            notTxt = new TextBox();
            label1 = new Label();
            ekle = new Button();
            duzenle = new Button();
            sil = new Button();
            dbConnectBtn = new Button();
            connectionStatus = new Label();
            listBox2 = new ListBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            loginOlanUser = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(62, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(207, 224);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // notTxt
            // 
            notTxt.Location = new Point(36, 329);
            notTxt.Name = "notTxt";
            notTxt.PlaceholderText = "Not:";
            notTxt.Size = new Size(360, 27);
            notTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 47);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Ndt Listesi";
            // 
            // ekle
            // 
            ekle.Location = new Point(36, 382);
            ekle.Name = "ekle";
            ekle.Size = new Size(94, 29);
            ekle.TabIndex = 3;
            ekle.Text = "ekle";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            // 
            // duzenle
            // 
            duzenle.Location = new Point(136, 382);
            duzenle.Name = "duzenle";
            duzenle.Size = new Size(94, 29);
            duzenle.TabIndex = 4;
            duzenle.Text = "düzenle";
            duzenle.UseVisualStyleBackColor = true;
            duzenle.Click += duzenle_Click;
            // 
            // sil
            // 
            sil.Location = new Point(236, 382);
            sil.Name = "sil";
            sil.Size = new Size(94, 29);
            sil.TabIndex = 5;
            sil.Text = "sil";
            sil.UseVisualStyleBackColor = true;
            sil.Click += sil_Click;
            // 
            // dbConnectBtn
            // 
            dbConnectBtn.Location = new Point(24, 360);
            dbConnectBtn.Name = "dbConnectBtn";
            dbConnectBtn.Size = new Size(137, 29);
            dbConnectBtn.TabIndex = 6;
            dbConnectBtn.Text = "Connect DB";
            dbConnectBtn.UseVisualStyleBackColor = true;
            dbConnectBtn.Click += dbConnectBtn_Click;
            // 
            // connectionStatus
            // 
            connectionStatus.AutoSize = true;
            connectionStatus.Location = new Point(167, 364);
            connectionStatus.Name = "connectionStatus";
            connectionStatus.Size = new Size(50, 20);
            connectionStatus.TabIndex = 7;
            connectionStatus.Text = "label2";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(24, 65);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(266, 264);
            listBox2.TabIndex = 8;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(loginOlanUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(connectionStatus);
            panel1.Controls.Add(dbConnectBtn);
            panel1.Location = new Point(503, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 411);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(499, 355);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 355);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "düzenle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(299, 355);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(340, 84);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(241, 165);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 7);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 9;
            label2.Text = "DB Operations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 11);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 14;
            label3.Text = "Giriş Yapan Kullanıcı:";
            // 
            // loginOlanUser
            // 
            loginOlanUser.AutoSize = true;
            loginOlanUser.Location = new Point(361, 12);
            loginOlanUser.Name = "loginOlanUser";
            loginOlanUser.Size = new Size(50, 20);
            loginOlanUser.TabIndex = 15;
            loginOlanUser.Text = "label4";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 450);
            Controls.Add(panel1);
            Controls.Add(sil);
            Controls.Add(duzenle);
            Controls.Add(ekle);
            Controls.Add(label1);
            Controls.Add(notTxt);
            Controls.Add(listBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox notTxt;
        private Label label1;
        private Button ekle;
        private Button duzenle;
        private Button sil;
        private Button dbConnectBtn;
        private Label connectionStatus;
        private ListBox listBox2;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label loginOlanUser;
        private Label label3;
    }
}