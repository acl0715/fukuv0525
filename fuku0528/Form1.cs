namespace fuku0528
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Top = label2.Top - 15;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ebina");
            label2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Left = label2.Left - 15;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Top = label2.Top + 15;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Left = label2.Left + 15;
        }
    }
}