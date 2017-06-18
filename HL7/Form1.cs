using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace HL7
{
    public partial class Form1 : Form
    {
        List<String> listaFicheiros = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Testar ficheiros
            /*
            foreach (String m in listaFicheiros)
            {
                MessageBox.Show(m);
            }*/

            MessageHL7 msg;
            try
            {
                OpenFileDialog ficheiro = new OpenFileDialog();

                if (ficheiro.ShowDialog() == DialogResult.OK)
                {
                    //Lê mensagem do ficheiro
                    String mensagem = File.ReadAllText(ficheiro.FileName);

                    rtbMensagem.Text = mensagem;
                    txtCaminho.Text = ficheiro.FileName;

                    msg = new MessageHL7(mensagem);

                    txtNrSegmentos.Text = Convert.ToString(msg.TotalSegmentos());
                    txtTipoMensagem.Text = msg.TipoMensagem();
                    txtVersao.Text = msg.Versao();

                    foreach (SegmentHL7 s in msg.ListaSegmentos)
                    {
                        listBox1.Items.Add(s.PrimeiroCampoSegmento());
                    }

                }
            }
            catch (MSHException x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Guarda o caminho de todos os ficheiros
            string[] ficheiro = System.IO.Directory.GetFiles(Application.StartupPath + "\\MensagensHL7");

            foreach (String s in ficheiro)
            {
                //Verificar se o ficheiro já existe na lista
                if (!listaFicheiros.Contains(s))
                {
                    listaFicheiros.Add(s);
                    /*String mensagem = File.ReadAllText(s);
                    MessageHL7 msg = new MessageHL7(mensagem);*/
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtbMensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVersao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoMensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNrSegmentos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
