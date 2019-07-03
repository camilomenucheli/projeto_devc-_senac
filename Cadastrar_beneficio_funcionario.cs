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
    public partial class frm_cadastro_beneficio_funcionario : Form
    {
        public frm_cadastro_beneficio_funcionario()
        {
            InitializeComponent();
        }
        public void limpa()
        {
            txt_cod_funcionario_beneficio.Text = "";
            txt_empresa_responsavel.Text = "";
            txt_nome_funcionario.Text = "";
            txt_valor.Text = "";
            cb_beneficio.Text = "";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_salvar_dependente_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_novo_dependente_Click(object sender, EventArgs e)
        {
            //if(não salvo)
            //{
            if (MessageBox.Show("Deseja Salvar Dependentes?", "Novo Dependente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //salva();
                limpa();
            }
            else
            {
                limpa();
            }
            //}
        }

        private void frm_cadastrar_beneficio_funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
