namespace Marathon
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            DataCheking f2 = new DataCheking();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _10DetailInfo fr3 = new _10DetailInfo();
            fr3.Show();
        }
    }
}
