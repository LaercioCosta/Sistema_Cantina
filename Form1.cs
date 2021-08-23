using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {
        string[] produto = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length == 3)
            {
                int indice = 0;
                for(int prod = 1;prod < codigo.Length; prod++)
                {
                    if(txtCodigo.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if(indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                }
                else
                {
                    lstCaixa.Items.Add(txtCodigo.Text + " -- " + produto[indice] + " -- RS:" + valor[indice]);

                    soma = soma + valor[indice];
                    label3.Text = ("Valor Total R$: " + soma);
                    picImagem.ImageLocation = "G:/Estudo/Fundação Bradesco/Sistema Cantina/img/" + codigo[indice] + ".jpg";
                    txtCodigo.Text = "";
                    txtCodigo.Focus();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarArray();
            soma = 0;
        }
        private void carregarArray()
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produto[1] = "Pastel";
            produto[2] = "Coxinha";
            produto[3] = "Refrigerante";
            produto[4] = "Hot-dog";
            produto[5] = "Suco";

            valor[1] = 2.50;
            valor[2] = 2.50;
            valor[3] = 5.00;
            valor[4] = 3.00;
            valor[5] = 2.50;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lstCaixa.Items.Clear();
            soma = 0;
            label3.Text = "Valor Total R$: ";
            txtCodigo.Focus();
        }
    }
}
