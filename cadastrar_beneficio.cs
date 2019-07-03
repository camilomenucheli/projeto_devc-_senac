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
    public partial class frm_cadastro_beneficio : Form
    {
        public frm_cadastro_beneficio()
        {
            InitializeComponent();
        }
        public void limpa()
        {
            txt_nome_beneficio.Text = "";
            txt_nome_empresa_responsavel.Text = "";
            txt_valor.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //if(nao salvo)
            if (MessageBox.Show("Deseja Salvar Benefício?", "Novo Benefício", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //salva();
                limpa();
            }
            else
            {
                limpa();
            }
        }
    }
}
