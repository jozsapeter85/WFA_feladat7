namespace WFA_feladat7
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        public int db;
        public Form1()
        {
            InitializeComponent();
            btndob.Click += Btndob_Click;
        }

        private void Btndob_Click(object? sender, EventArgs e)
        {
            if(!isconvertible())
            {
                MessageBox.Show(
                    caption:"Hibás adat!",
                    text:"Invalid input!",
                    icon:MessageBoxIcon.Error,
                    buttons:MessageBoxButtons.OK
                    );
                return;
            }
            for (int i = 0; i < db; i++)
            {
                int szam = rnd.Next(1, 6);
                lblresult.Text += szam.ToString() + " ";
            }
        }

        public bool isconvertible()
            => int.TryParse(tbdarab.Text, out db);
    }
}
