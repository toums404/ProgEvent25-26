namespace ProgEvent25_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bPermuter_Click(object sender, EventArgs e)
        {
            Image temp = Pb1.Image;
            Pb1.Image = Pb2.Image;
            Pb2.Image = temp;
        }

        private void Fenetre2_Click(object sender, EventArgs e)
        {
            EcranDeux fenetre = new EcranDeux();
            fenetre.Show();
            this.Hide();

        }
    }
}
