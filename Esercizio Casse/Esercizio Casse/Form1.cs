namespace Esercizio_Casse
{
    public partial class Form1 : Form
    {
        Cassa c1=new Cassa();
        Cassa c2 = new Cassa();
        Cassa c3 = new Cassa();
        Cassa tot = new Cassa();
        public Form1()
        {
            InitializeComponent();
        }
        private void VenditaSingola(Cassa c)
        {
            try
            {
                c.VendiBiglietto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VenditaMultipla(Cassa c, int n)
        {
            try
            {
                c.VendiBiglietto(n);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AnnulaSingola(Cassa c)
        {
            try
            {
                c.AnnullaBiglietto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AnnullaMultipla(Cassa c, int n)
        {
            try
            {
                c.AnnullaBiglietto(n);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.VendiBiglietto();
            aggiornaLabel();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            c2.VendiBiglietto();
            aggiornaLabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c3.VendiBiglietto();
            aggiornaLabel();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            c1.VendiBiglietto(5);
            aggiornaLabel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c2.VendiBiglietto(7);
            aggiornaLabel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c3.VendiBiglietto(3);
            aggiornaLabel();
        }
        private void aggiornaLabel()
        {
            label1.Text = "Cassa 1: " + c1.GetBigliettiVenduti();
            label2.Text = "Cassa 2: " + c2.GetBigliettiVenduti();
            label3.Text = "Cassa 3: " + c3.GetBigliettiVenduti();
            label4.Text = "Totale: " + tot.GetBigliettiTot();
        }
    }
}