using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_Operacoes.ServicoOperacao;

namespace WCF_Operacoes
{
    public partial class frm_Operacoes : Form
    {
        public frm_Operacoes()
        {
            InitializeComponent();
        }
        ServicoOperacao.OperacaoClient cliente = new OperacaoClient("Operacao");
      
        private void btn_Somar_Click(object sender, EventArgs e)
        {
            
            txt_Total.Text = cliente.Somar(Convert.ToDouble(txt_Valor1.Text), Convert.ToDouble(txt_Valor2.Text)).ToString();
            LimparCampos();
        }

        private void btn_Subtrair_Click(object sender, EventArgs e)
        {
            txt_Total.Text = cliente.Subtrair(Convert.ToDouble(txt_Valor1.Text), Convert.ToDouble(txt_Valor2.Text)).ToString();
            LimparCampos();
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            txt_Total.Text = cliente.Divisao(Convert.ToDouble(txt_Valor1.Text), Convert.ToDouble(txt_Valor2.Text)).ToString();
            LimparCampos();
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            txt_Total.Text = cliente.Multiplicacao(Convert.ToDouble(txt_Valor1.Text), Convert.ToDouble(txt_Valor2.Text)).ToString();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txt_Valor1.Text = string.Empty;
            txt_Valor2.Text = string.Empty;
        }

        private void btn_Maiusculo_Click(object sender, EventArgs e)
        {
           
            txt_resultadoFinal.Text =  cliente.CaixaBaixa(txt_texto.Text);
            limarTexto();
        }

        private void btn_Minusculo_Click(object sender, EventArgs e)
        {
           
            txt_resultadoFinal.Text = cliente.CaixaAlta(txt_texto.Text);
            limarTexto();
        }

        private void limarTexto()
        {
            txt_texto.Text = string.Empty;
        }
    }
}
