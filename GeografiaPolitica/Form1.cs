using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeografiaPolitica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String image = "";
        String text = "";

        public void alterContries(String contry, String txt) {

            image = contry + ".png";

            if (brasil.Checked == true)
            {
                contry = "brasil";
                text = "O país é o quinto maior do mundo em área territorial, com 8 510 345,538 km² " +
                    "O Brasil tem um sistema denso e complexo de rios, um dos mais extensos do mundo, com oito grandes bacias hidrográficas. " +
                    "A organização político-administrativa da República Federativa do Brasil compreende a União, os estados," +
                    "o Distrito Federal e os municípios, todos autônomos, nos termos da constituição. " +
                    "Todos os membros do executivo e do legislativo são eleitos diretamente.";
            }
            else if (chile.Checked == true)
            {
                contry = "chile";
                text = "O território chileno é cortado ao norte pelo Trópico de Capricórnio." +
                    "Vários rios de curta extensão e de baixo fluxo cortam seu território," +
                    " que comumente fluem da cordilheira dos Andes até o Oceano Pacífico, no sentido leste-oeste." +
                    "A atual Constituição do Chile foi aprovada em um plebiscito nacional fortemente contestado em setembro de 1980." +
                    "O poder executivo é chefiado pelo Presidente da República, que é o chefe de Estado e o chefe de governo.";
            }
            else if (mexico.Checked == true)
            {
                contry = "mexico";
                text = "O México é um país situado entre os Estados Unidos e a América Central.o " +
                    "No norte, o país divide uma fronteira de 3 141 quilômetros com os Estados Unidos. " +
                    "O México é atravessado de norte a sul por duas cadeias de montanhas conhecidas como Sierra Madre Oriental e Sierra Madre Ocidental." +
                    "Ruínas antigas, como Teotihuacán e a cidade maia de Chichén Itzá, estão espalhadas pelo país. " +
                    "Os Estados Unidos Mexicanos são uma federação cujo governo é representativo, democrático e republicano. " +
                    "Três partidos têm sido historicamente os partidos dominantes na política mexicana.";
            }
            else if (argentina.Checked == true)
            {
                contry = "argentina";
                text = "A Argentina está situada no sul da América do Sul, com a Cordilheira dos Andes a oeste. " +
                    "O ponto mais alto acima do nível do mar é o Monte Aconcágua, na província de Mendoza. " +
                    "Plantas subtropicais dominam o Gran Chaco, no norte, com o gênero de árvores Dalbergia. " +
                    "O governo nacional é composto por três ramos:" +
                    "Poder Executivo, Judiciário e Legislativo.";
            }

            pbImagem.Load("../../Resources/" + image);
            txtTexto.Text = text;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            alterContries("brasil", text);
        }

        private void gbPais_Enter(object sender, EventArgs e)
        {

        }

        private void chile_CheckedChanged(object sender, EventArgs e)
        {
            alterContries("chile", text);
        }

        private void mexico_CheckedChanged(object sender, EventArgs e)
        {
            alterContries("mexico", text);
        }

        private void argentina_CheckedChanged(object sender, EventArgs e)
        {
            alterContries("argentina", text);
        }

        private void pbImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
