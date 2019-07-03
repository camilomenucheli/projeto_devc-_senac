using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_1._0
{
    public partial class frm_cadastro_fornecedor : Form
    {
        public frm_cadastro_fornecedor()
        {
            InitializeComponent();
        }
        public static bool validaCNPJ(string cnpj)
        {

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;

            int resto;

            string digito;

            string tempCnpj;

            cnpj = cnpj.Trim();

            cnpj = cnpj.Replace(".", "").Replace("‐", "").Replace("/", "");

            if (cnpj.Length != 14)

                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;

            for (int i = 0; i < 12; i++)

                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;

            soma = 0;

            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            }
            resto = (soma % 11);

            if (resto < 2)

                resto = 0;

            else
            {
                resto = 11 - resto;
            }
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);

        }

        private void cb_estado_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_cidade_fornecedor.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txt_cnpj_fornecedor_Leave(object sender, EventArgs e)
        {
            txt_cnpj_fornecedor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cnpj = txt_cnpj_fornecedor.Text;
            if (validaCNPJ(cnpj) == false)
            {
                txt_cnpj_fornecedor.Text = "";
                txt_cnpj_fornecedor.Focus();
                MessageBox.Show("Digite um CNPJ Valido", "CNPJ Invalido");
            } 
        }

        private void txt_cnpj_fornecedor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
