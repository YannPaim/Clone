using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeianFilms
{
    public partial class Programa : Form
    {
        public Programa()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "Venow";
            txtDescrisao.Text = "O jornalista investigativo Eddie Brock\né possuído por uma forma alienígena\nsimbionte, ganhando poderes-sobre\nhumanos. Perverso, sombrio e\nalimentado pela raiva, Venom tenta\ncontrolar os novos e perigosos\npoderes inebriantes de Eddie.";
            estrelinhas.Text = "☆☆☆☆☆";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "Jurassic Park";
            txtDescrisao.Text = "Os paleontólogos Alan Grant, Ellie Sattler\ne o matemático Ian Malcolm fazem parte\nde um seleto grupo escolhido para visitar\numa ilha habitada por dinossauros criados\na partir de DNA pré - histórico.O idealizador\ndo projeto e bilionário John Hammond\ngarante a todos que a instalação é\ncompletamente segura.Mas após uma\nqueda de energia, os visitantes descobrem,\naos poucos, que vários predadores ferozes\nestão soltos e à caça.";
            estrelinhas.Text = "☆☆☆☆☆";
        }

        private void imgAvengers_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "Vingadores:Ultimato";
            txtDescrisao.Text = "Após Thanos eliminar metade das\ncriaturas vivas, os Vingadores têm\nde lidar com a perda de amigos e\nentes queridos. Com Tony Stark\nvagando perdido no espaço sem\nágua e comida, Steve Rogers e\nNatasha Romanov lideram a\nresistência contra o titã louco.";
            estrelinhas.Text = "☆☆☆☆☆";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(boxNota.Text == "0")
            {
                estrelinhas.Text = "☆☆☆☆☆";
            }
            else if (boxNota.Text == "1")
            {
                estrelinhas.Text = "★☆☆☆☆";
            }
            else if (boxNota.Text == "2")
            {
                estrelinhas.Text = "★★☆☆☆";
            }
            else if (boxNota.Text == "3")
            {
                estrelinhas.Text = "★★★☆☆";
            }
            else if (boxNota.Text == "4")
            {
                estrelinhas.Text = "★★★★☆";
            }
            else if (boxNota.Text == "5")
            {
                estrelinhas.Text = "★★★★★";
            }
            else
            {
                estrelinhas.Text = "Erro!";
            }
        }
    }
}
