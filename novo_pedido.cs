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
    public partial class frm_novo_pedido : Form
    {
        public frm_novo_pedido()
        {
            InitializeComponent();
        }
        public void limpar()
        {
            txt_cod_pedido.Text = "";
            cb_quantidade_pedido.Text = "";
        }

        private void btn_adicionar_pedido_Click(object sender, EventArgs e)
        {
            dgv_pedido.Rows.Add(txt_cod_pedido.Text, cb_quantidade_pedido.Text );
            limpar();
            txt_cod_pedido. Focus();
        }

        private void frm_novo_pedido_Load(object sender, EventArgs e)
        {
            txt_data_pedido.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o Pedido?", "Cancelar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_forma_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_forma_pagamento.Text == "Dinheiro")
            {
                cb_parcelas_pedido.Text = "1";
                cb_parcelas_pedido.Enabled = false;
                txt_desconto.Text = " 10";
            }
            //double valorLiquido= Convert.ToDouble(txt_valor_liquido.Text);
        }

        private void txt_data_pedido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
