namespace labpokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pikachu pokachu = new pikachu();
            label1.Text = pokachu.Name();
            pictureBox1.Image = labpokemon.Properties.Resources.Pikachu_;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rayquaza Rayquaza = new Rayquaza();
            label1.Text = Rayquaza.Name();
            pictureBox1.Image =labpokemon.Properties.Resources.Rayquaza;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Blaziken Blaziken = new Blaziken();
            label1.Text = Blaziken.Name();
            pictureBox1.Image = labpokemon.Properties.Resources.Blaziken;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gardevoir gardevoir = new Gardevoir();
            label1.Text = gardevoir.Name();
            pictureBox1.Image = labpokemon.Properties.Resources.gardevoir;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lucario Lucario = new Lucario();
            label1.Text = Lucario.Name();
            pictureBox1.Image = labpokemon.Properties.Resources.lucario;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Swampert Swampert = new Swampert();
            label1.Text = Swampert.Name();
            pictureBox1.Image = labpokemon.Properties.Resources.Swampert;
        }
    }
}
