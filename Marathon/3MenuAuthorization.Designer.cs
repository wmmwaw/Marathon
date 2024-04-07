namespace Marathon
{
    partial class MenuAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAuthorization));
            panel1 = new Panel();
            button1 = new Button();
            MARATHON = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 83, 83);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(MARATHON);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 49);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(68, 30);
            button1.TabIndex = 2;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            // 
            // MARATHON
            // 
            MARATHON.AutoSize = true;
            MARATHON.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            MARATHON.ForeColor = Color.FromArgb(254, 254, 254);
            MARATHON.Location = new Point(102, 8);
            MARATHON.Name = "MARATHON";
            MARATHON.Size = new Size(467, 38);
            MARATHON.TabIndex = 0;
            MARATHON.Text = "MARATHON SKILLS 2016";
            MARATHON.TextAlign = ContentAlignment.TopCenter;
            MARATHON.Click += MARATHON_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(338, 85);
            label1.Name = "label1";
            label1.Size = new Size(259, 29);
            label1.TabIndex = 2;
            label1.Text = "Форма авторизации";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 133);
            label2.Name = "label2";
            label2.Size = new Size(770, 18);
            label2.TabIndex = 3;
            label2.Text = "Пожалуйста, авторизуйтесь в системе, испльзуя ваш адрес электронной почты и паролью";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(283, 185);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(250, 242);
            label4.Name = "label4";
            label4.Size = new Size(87, 18);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 20);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(362, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 20);
            textBox2.TabIndex = 7;
            // 
            // MenuAuthorization
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuAuthorization";
            Text = "MenuAuthorization";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label MARATHON;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}