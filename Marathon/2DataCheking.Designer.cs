namespace Marathon
{
    partial class DataCheking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataCheking));
            panel1 = new Panel();
            button1 = new Button();
            MARATHON = new Label();
            panel2 = new Panel();
            ДниЧасы = new Label();
            Login = new Button();
            ЯУчавствовал = new Button();
            ЯНовый = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 83, 83);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(MARATHON);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1285, 81);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(14, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 3;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            // 
            // MARATHON
            // 
            MARATHON.AutoSize = true;
            MARATHON.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            MARATHON.ForeColor = Color.FromArgb(254, 254, 254);
            MARATHON.Location = new Point(131, 16);
            MARATHON.Name = "MARATHON";
            MARATHON.Size = new Size(495, 41);
            MARATHON.TabIndex = 1;
            MARATHON.Text = "MARATHON SKILLS 2016";
            MARATHON.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 83, 83);
            panel2.Controls.Add(ДниЧасы);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 787);
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
            ДниЧасы.Location = new Point(394, 7);
            ДниЧасы.Name = "ДниЧасы";
            ДниЧасы.Size = new Size(577, 35);
            ДниЧасы.TabIndex = 5;
            ДниЧасы.Text = "18 дней 8 часов и 17 минут до старта марафона!";
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Login.Location = new Point(1055, 707);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(179, 52);
            Login.TabIndex = 2;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            // 
            // ЯУчавствовал
            // 
            ЯУчавствовал.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ЯУчавствовал.Location = new Point(419, 265);
            ЯУчавствовал.Margin = new Padding(3, 4, 3, 4);
            ЯУчавствовал.Name = "ЯУчавствовал";
            ЯУчавствовал.Size = new Size(455, 107);
            ЯУчавствовал.TabIndex = 3;
            ЯУчавствовал.Text = "Я участвовал ранее";
            ЯУчавствовал.UseVisualStyleBackColor = true;
            ЯУчавствовал.Click += ЯУчавствовал_Click;
            // 
            // ЯНовый
            // 
            ЯНовый.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ЯНовый.Location = new Point(419, 400);
            ЯНовый.Margin = new Padding(3, 4, 3, 4);
            ЯНовый.Name = "ЯНовый";
            ЯНовый.Size = new Size(455, 107);
            ЯНовый.TabIndex = 4;
            ЯНовый.Text = "Я новый участник";
            ЯНовый.UseVisualStyleBackColor = true;
            // 
            // DataCheking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 843);
            Controls.Add(ЯНовый);
            Controls.Add(ЯУчавствовал);
            Controls.Add(Login);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "DataCheking";
            Text = "Marathon Skills 2016 – Register as a runner";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Login;
        private Label MARATHON;
        private Button button1;
        private Button ЯУчавствовал;
        private Button ЯНовый;
        private Label ДниЧасы;
    }
}