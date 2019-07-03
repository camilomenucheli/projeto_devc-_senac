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
    public partial class frm_cadastro_produto : Form
    {
        public frm_cadastro_produto()
        {
            InitializeComponent();
        }

        private void cb_medida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_medida.Text == "Metros")
            {
                lbl_metros.Visible = true;
                lbl_centimetros.Visible = false;
                lbl_milimitros.Visible = false;
            }
            if (cb_medida.Text == "Centímetros")
            {
                lbl_metros.Visible = false;
                lbl_centimetros.Visible = true;
                lbl_milimitros.Visible = false;
            }
            if (cb_medida.Text == "Milímetros")
            {
                lbl_metros.Visible = false;
                lbl_centimetros.Visible = false;
                lbl_milimitros.Visible = true;
            }
            txt_dimensoes1_produto.Enabled = true;
            txt_dimensoes2_produto.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string dimensao = txt_dimensoes1_produto.Text + "x"+txt_dimensoes2_produto.Text+cb_medida.Text;
        }
    }
}
