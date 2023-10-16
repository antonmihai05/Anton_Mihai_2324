namespace Esercizio_16_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string scelta = "";
        string sceltaComputer = "";
        int punti;
        int puntiComputer;

       

        private void button1_Click(object sender, EventArgs e)
        {
            scelta = "carta";
            gioco();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scelta = "sasso";
            gioco();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scelta = "forbice";
            gioco();
        }
        private void gioco()
        {
            var rand = new Random();
            int a = rand.Next(1, 4);

            if (a == 1)
            {
                sceltaComputer = "carta";
            }
            if (a == 2)
            {
                sceltaComputer = "sasso";


            }
            if (a == 3)
            {
                sceltaComputer = "forbice";


            }
            if (scelta == "carta" && sceltaComputer == "sasso")
            {
                punti += 1;
                label4.Text = punti.ToString();
                pictureBox4.Load("Carta.png");
                pictureBox5.Load("sasso.png");

            }
            if (scelta == "sasso" && sceltaComputer == "forbice")
            {
                punti += 1;
                label4.Text = punti.ToString();
                pictureBox4.Load("sasso.png");
                pictureBox5.Load("Forbice.png");

            }
            if (scelta == "forbice" && sceltaComputer == "carta")
            {
                punti += 1;
                label4.Text = punti.ToString();
                pictureBox4.Load("Forbice.png");
                pictureBox5.Load("Carta.png");

            }
            if (scelta == "forbice" && sceltaComputer == "sasso")
            {
                puntiComputer += 1;
                label5.Text = puntiComputer.ToString();
                pictureBox4.Load("Forbice.png");
                pictureBox5.Load("sasso.png");

            }
            if (scelta == "sasso" && sceltaComputer == "carta")
            {
                puntiComputer += 1;
                label5.Text = puntiComputer.ToString();
                pictureBox4.Load("sasso.png");
                pictureBox5.Load("Carta.png");

            }
            if (scelta == "carta" && sceltaComputer == "forbice")
            {
                puntiComputer += 1;
                label5.Text = puntiComputer.ToString();
                pictureBox4.Load("Carta.png");
                pictureBox5.Load("Forbice.png");

            }
            if (scelta == "carta" && sceltaComputer == "carta")
            {
                puntiComputer += 0;
                punti += 0;
                label5.Text = puntiComputer.ToString();
                label4.Text = punti.ToString();
                pictureBox4.Load("Carta.png");
                pictureBox5.Load("Carta.png");

            }
            if (scelta == "forbice" && sceltaComputer == "forbice")
            {
                puntiComputer += 0;
                punti += 0;
                label5.Text = puntiComputer.ToString();
                label4.Text = punti.ToString();
                pictureBox4.Load("Forbice.png");
                pictureBox5.Load("Forbice.png");

            }
            if (scelta == "sasso" && sceltaComputer == "sasso")
            {
                puntiComputer += 0;
                punti += 0;
                label5.Text = puntiComputer.ToString();
                label4.Text = punti.ToString();
                pictureBox4.Load("sasso.png");
                pictureBox5.Load("sasso.png");

            }

        }
       
    }
}