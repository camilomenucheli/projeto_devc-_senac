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
    public partial class frm_cadastro_dependentes : Form
    {
        public frm_cadastro_dependentes()
        {
            InitializeComponent();
        }

        public void limpa()
        {
            txt_cod_funcionario_dependente.Text = "";
            txt_nome_dependente.Text = "";
            txt_idade_dependente.Text = "";
            txt_grau_familiaridade_dependente.Text = "";
        }

        private void txt_idade_dependente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_grau_familiaridade_dependente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_dependente_Click(object sender, EventArgs e)
        {
            //if(nao salvo)
            if (MessageBox.Show("Deseja Salvar Dependentes?", "Novo Dependente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //salva();
                limpa();
            }
            else
            {
                limpa();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
