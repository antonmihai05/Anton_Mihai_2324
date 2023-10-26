using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Esercizio_Libri
{
    public partial class Form1 : Form
    {
        List<Libro> listaLibri=new List<Libro>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void aggiornaListbox()
        {
                listBox1.Items.Clear();

                for (int i = 0; i < listaLibri.Count; i++)
                {
                    listBox1.Items.Add(listaLibri[i]);
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int indiceSelezionato = listBox1.SelectedIndex;
            if (indiceSelezionato == -1)
            {
                return;
            }
            Libro l = new Libro(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text, checkBox1.Checked);
            listaLibri.RemoveAt(indiceSelezionato);
            listaLibri.Insert(indiceSelezionato, l);

            aggiornaListbox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indiceSelezionato = listBox1.SelectedIndex;
            if (indiceSelezionato == -1)
            {
                return;
            }

            listaLibri.RemoveAt(indiceSelezionato);
            aggiornaListbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titolo = textBox1.Text;
            string autore= textBox2.Text;
            int numeroPagine = int.Parse(textBox3.Text);
            string genere = textBox4.Text;
            bool raccolta = checkBox1.Checked;
            Libro l = new Libro(titolo, autore, numeroPagine, genere, raccolta);
            listaLibri.Add(l);
            aggiornaListbox();
        }

    }
}