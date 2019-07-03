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
    public partial class frm_cadastro_funcionario : Form
    {
        public frm_cadastro_funcionario()
        {
            InitializeComponent();
        }
        public static bool validaCPF(string CPF)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int Soma;
            int resto;
            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");
            if (CPF.Length != 11)
                return false;
            TempCPF = CPF.Substring(0, 9);
            Soma = 0;

            for (int i = 0; i < 9; i++)
            {
                Soma += int.Parse(TempCPF[i].ToString()) * mt1[i];
            }
            resto = Soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            Digito = resto.ToString();
            TempCPF = TempCPF + Digito;
            Soma = 0;
            for (int i = 0; i < 10; i++)
            {
                Soma += int.Parse(TempCPF[i].ToString()) * mt2[i];
            }
            resto = Soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }
            Digito = Digito + resto.ToString();
            return CPF.EndsWith(Digito);
        }

        private void Cadastro_funcionario_Load(object sender, EventArgs e)
        {
            txt_data_funcionario.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void cb_estado_entrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_cidade_funcionario.Enabled = true;
        }

        private void txt_cpf_funcionario_Leave(object sender, EventArgs e)
        {
            txt_cpf_funcionario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = txt_cpf_funcionario.Text;
            if (validaCPF(cpf) == false)
            {
                txt_cpf_funcionario.Text = "";
                txt_cpf_funcionario.Focus();
                MessageBox.Show("Digite um CPF Valido", "CPF Invalido");
            }
        }

        private void btn_cancelar_cliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_salvar_cliente_Click(object sender, EventArgs e)
        {
            //messageBox entra depois de salvar no banco..
            
            if (MessageBox.Show("Deseja Cadastrar Dependentes?", "Cancelar Dependentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frm_cadastro_dependentes().ShowDialog();
            }

            if (MessageBox.Show("Deseja Cadastrar Benefício?", "Cancelar Benefício", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new frm_cadastro_beneficio_funcionario().ShowDialog();
            }
        }
    }
}
