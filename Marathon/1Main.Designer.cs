namespace Marathon
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            label1 = new Label();
            MARATHON = new Label();
            panel2 = new Panel();
            ДниЧасы = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Login = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 83, 83);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MARATHON);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 279);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 204, 204);
            label1.Location = new Point(472, 141);
            label1.Name = "label1";
            label1.Size = new Size(345, 83);
            label1.TabIndex = 1;
            label1.Text = "  Москва, Россия  среда 21 октября 2016";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MARATHON
            // 
            MARATHON.AutoSize = true;
            MARATHON.Font = new Font("Verdana", 28F, FontStyle.Bold, GraphicsUnit.Point);
            MARATHON.ForeColor = Color.FromArgb(254, 254, 254);
            MARATHON.Location = new Point(334, 43);
            MARATHON.Name = "MARATHON";
            MARATHON.Size = new Size(682, 57);
            MARATHON.TabIndex = 0;
            MARATHON.Text = "MARATHON SKILLS 2016";
            MARATHON.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 83, 83);
            panel2.Controls.Add(ДниЧасы);
            panel2.Location = new Point(0, 788);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1285, 56);
            panel2.TabIndex = 1;
            // 
            // ДниЧасы
            // 
            ДниЧасы.AutoSize = true;
            ДниЧасы.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ДниЧасы.ForeColor = Color.White;
            ДниЧасы.Location = new Point(384, 5);
            ДниЧасы.Name = "ДниЧасы";
            ДниЧасы.Size = new Size(577, 35);
            ДниЧасы.TabIndex = 2;
            ДниЧасы.Text = "18 дней 8 часов и 17 минут до старта марафона!";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(419, 316);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(455, 107);
            button1.TabIndex = 2;
            button1.Text = "Я хочу стать бегуном";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(419, 451);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(455, 107);
            button2.TabIndex = 3;
            button2.Text = "Я хочу стать спонсором бегуна";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(419, 583);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(455, 107);
            button3.TabIndex = 4;
            button3.Text = "Я хочу узнать больше о событии";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Login.Location = new Point(1055, 707);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(179, 52);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 843);
            Controls.Add(Login);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Marathon Skills 2016";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label MARATHON;
        private Label label1;
        private Label ДниЧасы;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Login;
    }
}
