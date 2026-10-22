namespace WFA_feladat7
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            btndob.Click += Btndob_Click;
            tbdarab.ValueChanged += ValueChanged;
        }

        private void ValueChanged(object? sender, EventArgs e)
        {
            lblresult.Text = string.Empty;
        }

        private void Btndob_Click(object? sender, EventArgs e)
        {
            for (int i = 0; i < tbdarab.Value; i++)
            {
                int szam = rnd.Next(1, 6);
                lblresult.Text += szam.ToString() + " ";
            }
        }
        
        
    }
}
