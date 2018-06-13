using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario
{
    public partial class Form1 : Form
    {
        private IMario objPersonagem;
        String estado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonCogumelo_Click(object sender, EventArgs e)
        {
            estado = objPersonagem.RetornarTipo();
            textBoxStatus.Text = Convert.ToString(estado);
            objPersonagem = objPersonagem.PegarCogumelo();
            estado = "PEGA GROW UP";
            textBoxAção.Text = Convert.ToString(estado);
            estado = objPersonagem.RetornarTipo();
            textBoxNovoStatus.Text = Convert.ToString(estado);
            
        }

        private void buttonSuperStar_Click(object sender, EventArgs e)
        {
            estado = objPersonagem.RetornarTipo();
            textBoxStatus.Text = Convert.ToString(estado);
            objPersonagem = objPersonagem.PegarEstrela();
            estado = "PEGA SUPER STAR";
            textBoxAção.Text = Convert.ToString(estado);
            estado = objPersonagem.RetornarTipo();
            textBoxNovoStatus.Text = Convert.ToString(estado);
            
        }

        private void buttonFireFlower_Click(object sender, EventArgs e)
        {
            estado = objPersonagem.RetornarTipo();
            textBoxStatus.Text = Convert.ToString(estado);
            objPersonagem = objPersonagem.PegarFlorDeFogo();
            estado = "PEGA FIRE FLOWER";
            textBoxAção.Text = Convert.ToString(estado);
            estado = objPersonagem.RetornarTipo();
            textBoxNovoStatus.Text = Convert.ToString(estado);
            
        }

        private void buttonDano_Click(object sender, EventArgs e)
        {
            estado = objPersonagem.RetornarTipo();
            textBoxStatus.Text = Convert.ToString(estado);
            objPersonagem = objPersonagem.ReceberDano();
            estado = "ATINGIDO";
            textBoxAção.Text = Convert.ToString(estado);
            estado = objPersonagem.RetornarTipo();
            textBoxNovoStatus.Text = Convert.ToString(estado);
            if (textBoxNovoStatus.Text == "MARIO MORTO")
            {
                estado = "GAME OVER";
                textBoxStatus.Text = Convert.ToString(estado);
                textBoxAção.Text = Convert.ToString(estado);
                textBoxNovoStatus.Text = Convert.ToString(estado);
                MessageBox.Show("GAME OVER");
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            objPersonagem = new clsTMario();
            estado = objPersonagem.RetornarTipo();
            textBoxStatus.Text = Convert.ToString(estado);
            estado = "";
            textBoxAção.Text = Convert.ToString(estado);
            textBoxNovoStatus.Text = Convert.ToString(estado);
        }
    }
}
