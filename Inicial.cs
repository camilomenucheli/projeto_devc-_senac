using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Final_1._0
{
    public partial class frm_inicial : Form
    {
        //variaveis para consulta
        #region
        int id_cliente,id_funcionario;
        string nome_cliente,nome_funcionario; //nomes
        #endregion  
        string vsql;
        SqlCommand dbcmd = null;
        SqlConnection sqlconn = null; //conexão sql nula
        const string strConn = @"Data Source=MOG0499671W10-1;Initial Catalog=bd_cliente;Integrated Security=True"; //endereço do banco de dados
        private string usuario;

        public frm_inicial()
        {
            InitializeComponent();
        }

        public frm_inicial(string usuario)
        {
            InitializeComponent();
            lblss_nome_usuario.Text = usuario;
        }
        //consulta()
        #region
        public void consulta_cliente()
        {
            sqlconn = new SqlConnection(strConn);
            dbcmd = new SqlCommand();
            try
            {
                id_cliente = Convert.ToInt32(txt_pes_cod_cliente.Text);
                nome_cliente = txt_pes_nome_cliente.Text;
                if (txt_pes_cod_cliente.Text != "" && txt_pes_nome_cliente.Text != "")
                {
                    vsql = "select * from cliente where id_cliente like '%" + id_cliente + "% and %" + nome_cliente + "'";
                }
                else
                {
                    if (txt_pes_cod_cliente.Text != "")
                    {
                        vsql = "select * from cliente where id_cliente like '%" + id_cliente + "%'";
                    }
                    if (txt_pes_nome_cliente.Text != "")
                    {
                        vsql = "select * from cliente where cliente like '%" + nome_cliente + "%'";
                    }
                }
                dbcmd.CommandText = vsql;
                dbcmd.Connection = sqlconn;
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(dbcmd);
                DataTable cliente = new DataTable();
                da.Fill(cliente);
                dgv_cliente.DataSource = cliente;
            }
            catch (SqlException erroconsulta)
            {
                MessageBox.Show(erroconsulta + "Consulta não executada");
            }
        }
        public void consulta_funcionario()
        {
            sqlconn = new SqlConnection(strConn);
            dbcmd = new SqlCommand();
            try
            {
                id_funcionario = Convert.ToInt32(txt_pes_cod_funcionario.Text);
                nome_funcionario = txt_pes_nome_funcionario.Text;
                if (txt_pes_cod_funcionario.Text != "" && txt_pes_nome_funcionario.Text != "")
                {
                    vsql = "select * from funcionario where id_funcionario like '%" + id_funcionario + "% and %" + nome_funcionario + "'";
                }
                else
                {

                    if (txt_pes_cod_funcionario.Text != "")
                    {
                        vsql = "select * from funcionario where id_funcionario like '%" + id_funcionario + "%'";
                    }
                    if (txt_pes_nome_funcionario.Text != "")
                    {
                        vsql = "select * from funcioanrio where funcionario like '%" + nome_funcionario + "%'";
                    }

                }
                dbcmd.CommandText = vsql;
                dbcmd.Connection = sqlconn;
                sqlconn.Open();
                SqlDataAdapter da = new SqlDataAdapter(dbcmd);
                DataTable funcionario = new DataTable();
                da.Fill(funcionario);
                dgv_funcionario.DataSource = funcionario;
            }
            catch (SqlException erroconsulta)
            {
                MessageBox.Show(erroconsulta + "Consulta não executada");
            }
        }

        
        #endregion

        public void calendario()
        {
            if (mc_inicial.Enabled == false)
            {
                mc_inicial.Visible = true;
                mc_inicial.Enabled = true;
            }
            else
            {
                mc_inicial.Visible = false;
                mc_inicial.Enabled = false;
            }
        }
        
        public void desabilita()
        {
            pcb_icone_esqueda.Visible = true;
            pcb_fundo_inicial.Visible = false;
            lbl_pesquisa.Visible = false;
            mc_inicial.Visible = false;
            mc_inicial.Enabled = false;

            btn_cadastrar_funcionario.Enabled = false;
            btn_cadastrar_funcionario.Visible = false;
            btn_editar_funcionario.Enabled = false;
            btn_editar_funcionario.Visible = false;
            lbl_pes_cod_funcionario.Enabled = false;
            lbl_pes_cod_funcionario.Visible = false;
            txt_pes_cod_funcionario.Enabled = false;
            txt_pes_cod_funcionario.Visible = false;
            lbl_pes_nome_funcionario.Enabled = false;
            lbl_pes_nome_funcionario.Visible = false;
            txt_pes_nome_funcionario.Enabled = false;
            txt_pes_nome_funcionario.Visible = false;
            btn_buscar_funcionario.Enabled = false;
            btn_buscar_funcionario.Visible = false;
            txt_pes_nome_funcionario.Text = "";
            txt_pes_cod_funcionario.Text = "";
            dgv_funcionario.Enabled = false;
            dgv_funcionario.Visible = false;

            btn_cadastrar_cliente.Enabled = false;
            btn_cadastrar_cliente.Visible = false;
            btn_editar_cliente.Enabled = false;
            btn_editar_cliente.Visible = false;
            lbl_pes_cod_cliente.Enabled = false;
            lbl_pes_cod_cliente.Visible = false;
            lbl_pes_nome_cliente.Enabled = false;
            lbl_pes_nome_cliente.Visible = false;
            txt_pes_cod_cliente.Enabled = false;
            txt_pes_cod_cliente.Visible = false;
            txt_pes_nome_cliente.Enabled = false;
            txt_pes_nome_cliente.Visible = false;
            btn_buscar_cliente.Enabled = false;
            btn_buscar_cliente.Visible = false;
            txt_pes_cod_cliente.Text = "";
            txt_pes_nome_cliente.Text = "";
            dgv_cliente.Enabled = false;
            dgv_cliente.Visible = false;

            btn_cadastrar_fornecedor.Enabled = false;
            btn_cadastrar_fornecedor.Visible = false;
            btn_editar_fornecedor.Enabled = false;
            btn_editar_fornecedor.Visible = false;
            lbl_pes_cod_fornecedor.Enabled = false;
            lbl_pes_cod_fornecedor.Visible = false;
            lbl_pes_nome_fornecedor.Enabled = false;
            lbl_pes_nome_fornecedor.Visible = false;
            txt_pes_cod_fornecedor.Enabled = false;
            txt_pes_cod_fornecedor.Visible = false;
            txt_pes_nome_fornecedor.Enabled = false;
            txt_pes_nome_fornecedor.Visible = false;
            btn_buscar_fornecedor.Enabled = false;
            btn_buscar_fornecedor.Visible = false;
            txt_pes_cod_fornecedor.Text = "";
            txt_pes_nome_fornecedor.Text = "";

            btn_novo_pedido.Enabled = false;
            btn_novo_pedido.Visible = false;
            lbl_pes_cod_pedido.Enabled = false;
            lbl_pes_cod_pedido.Visible = false;
            txt_pes_cod_pedido.Enabled = false;
            txt_pes_cod_pedido.Visible = false;
            lbl_pes_nome_pedido.Enabled = false;
            lbl_pes_nome_pedido.Visible = false;
            txt_pes_nome_pedido.Enabled = false;
            txt_pes_nome_pedido.Visible = false;
            btn_buscar_pedido.Enabled = false;
            btn_buscar_pedido.Visible = false;
            txt_pes_cod_pedido.Text = "";
            txt_pes_nome_pedido.Text = "";

            btn_cadastrar_componente.Enabled = false;
            btn_cadastrar_componente.Visible = false;
            btn_editar_componente.Enabled = false;
            btn_editar_componente.Visible = false;
            lbl_pes_cod_componente.Enabled = false;
            lbl_pes_cod_componente.Visible = false;
            txt_pes_cod_componente.Enabled = false;
            txt_pes_cod_componente.Visible = false;
            lbl_pes_nome_componente.Enabled = false;
            lbl_pes_nome_componente.Visible = false;
            txt_pes_nome_componente.Enabled = false;
            txt_pes_nome_componente.Visible = false;
            btn_buscar_componente.Enabled = false;
            btn_buscar_componente.Visible = false;
            tbc_componente.Enabled = false;
            tbc_componente.Visible = false;
            txt_pes_cod_componente.Text = "";
            txt_pes_nome_componente.Text = "";

            btn_solicitar_manutencao.Enabled = false;
            btn_solicitar_manutencao.Visible = false;
            lbl_pes_cod_manutencao.Enabled = false;
            lbl_pes_cod_manutencao.Visible = false;
            txt_pes_cod_manutencao.Enabled = false;
            txt_pes_cod_manutencao.Visible = false;
            lbl_pes_nome_manutencao.Enabled = false;
            lbl_pes_nome_manutencao.Visible = false;
            txt_pes_nome_manutencao.Enabled = false;
            txt_pes_nome_manutencao.Visible = false;
            btn_buscar_manutencao.Enabled = false;
            btn_buscar_manutencao.Visible = false;
            txt_pes_cod_manutencao.Text = "";
            txt_pes_nome_manutencao.Text = "";

            lbl_pes_cod_producao.Enabled = false;
            lbl_pes_cod_producao.Visible = false;
            txt_pes_cod_producao.Enabled = false;
            txt_pes_cod_producao.Visible = false;
            lbl_pes_nome_producao.Enabled = false;
            lbl_pes_nome_producao.Visible = false;
            txt_pes_nome_producao.Enabled = false;
            txt_pes_nome_producao.Visible = false;
            btn_buscar_producao.Enabled = false;
            btn_buscar_producao.Visible = false;
            tbc_producao.Enabled = false;
            tbc_producao.Visible = false;
            txt_pes_cod_producao.Text = "";
            txt_pes_nome_producao.Text = "";

            btn_cadastrar_produto.Enabled = false;
            btn_cadastrar_produto.Visible = false;
            btn_editar_produto.Enabled = false;
            btn_editar_produto.Visible = false;
            lbl_pes_cod_produto.Enabled = false;
            lbl_pes_cod_produto.Visible = false;
            txt_pes_cod_produto.Enabled = false;
            txt_pes_cod_produto.Visible = false;
            lbl_pes_nome_produto.Enabled = false;
            lbl_pes_nome_produto.Visible = false;
            txt_pes_nome_produto.Enabled = false;
            txt_pes_nome_produto.Visible = false;
            btn_buscar_produto.Enabled = false;
            btn_buscar_produto.Visible = false;
            txt_pes_cod_produto.Text = "";
            txt_pes_nome_produto.Text = "";
        }
        #region
        private void frm_inicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tm_inicial_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = (DateTime.Now.ToString("HH:mm:ss"));
            lbl_data.Text = (DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_inicial_Load(object sender, EventArgs e)
        {
            desabilita();
            pcb_fundo_inicial.Visible = true;
            lbl_pesquisa.Visible = false;
            pcb_icone_esqueda.Visible = false;
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            desabilita();
            lbl_pesquisa.Visible = true;
            btn_cadastrar_cliente.Enabled = true; 
            btn_cadastrar_cliente.Visible = true;
            btn_editar_cliente.Enabled = true; 
            btn_editar_cliente.Visible = true;
            lbl_pes_cod_cliente.Enabled = true;
            lbl_pes_cod_cliente.Visible = true;
            lbl_pes_nome_cliente.Enabled = true;
            lbl_pes_nome_cliente.Visible = true;
            txt_pes_cod_cliente.Enabled = true;
            txt_pes_cod_cliente.Visible = true;
            txt_pes_nome_cliente.Enabled = true;
            txt_pes_nome_cliente.Visible = true;
            btn_buscar_cliente.Enabled = true;
            btn_buscar_cliente.Visible = true;
            dgv_cliente.Enabled = true;
            dgv_cliente.Visible = true;
        }

        private void ntn_funcionarios_Click(object sender, EventArgs e)
        {
            desabilita();
            lbl_pesquisa.Visible = true;
            btn_cadastrar_funcionario.Enabled = true;
            btn_cadastrar_funcionario.Visible = true;
            btn_editar_funcionario.Enabled = true;
            btn_editar_funcionario.Visible = true;
            lbl_pes_cod_funcionario.Enabled = true;
            lbl_pes_cod_funcionario.Visible = true;
            txt_pes_cod_funcionario.Enabled = true;
            txt_pes_cod_funcionario.Visible = true;
            lbl_pes_nome_funcionario.Enabled = true;
            lbl_pes_nome_funcionario.Visible = true;
            txt_pes_nome_funcionario.Enabled = true;
            txt_pes_nome_funcionario.Visible = true;
            btn_buscar_funcionario.Enabled = true;
            btn_buscar_funcionario.Visible = true;
            dgv_funcionario.Enabled = true;
            dgv_funcionario.Visible = true;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desabilita();
            pcb_fundo_inicial.Visible = true;
            pcb_icone_esqueda.Visible = false;
        }

        private void btn_fornecedores_Click(object sender, EventArgs e)
        {
            desabilita();
            lbl_pesquisa.Visible = true;
            btn_cadastrar_fornecedor.Enabled = true;
            btn_cadastrar_fornecedor.Visible = true;
            btn_editar_fornecedor.Enabled = true;
            btn_editar_fornecedor.Visible = true;
            lbl_pes_cod_fornecedor.Enabled = true;
            lbl_pes_cod_fornecedor.Visible = true;
            txt_pes_cod_fornecedor.Enabled = true;
            txt_pes_cod_fornecedor.Visible = true;
            lbl_pes_nome_fornecedor.Enabled = true;
            lbl_pes_nome_fornecedor.Visible = true;
            txt_pes_nome_fornecedor.Enabled = true;
            txt_pes_nome_fornecedor.Visible = true;
            btn_buscar_fornecedor.Enabled = true;
            btn_buscar_fornecedor.Visible = true;
        }

        private void btn_cadastrar_fornecedor_Click(object sender, EventArgs e)
        {
            new frm_cadastro_fornecedor().ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Enabled = false;
                this.Visible = false;
                new frm_login().ShowDialog();
            }
            else
            {
            }
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            string app = @"c:\windows\system32\calc.exe";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);
        }

        private void btn_pedidos_Click(object sender, EventArgs e)
        {
            desabilita();
            lbl_pesquisa.Visible = true;
            btn_novo_pedido.Enabled = true;
            btn_novo_pedido.Visible = true;
            lbl_pes_cod_pedido.Enabled = true;
            lbl_pes_cod_pedido.Visible = true;
            txt_pes_cod_pedido.Enabled = true;
            txt_pes_cod_pedido.Visible = true;
            lbl_pes_nome_pedido.Enabled = true;
            lbl_pes_nome_pedido.Visible = true;
            txt_pes_nome_pedido.Enabled = true;
            txt_pes_nome_pedido.Visible = true;
            btn_buscar_pedido.Enabled = true;
            btn_buscar_pedido.Visible = true;
        }

        private void btn_componentes_Click(object sender, EventArgs e)
        {
            desabilita();
            lbl_pesquisa.Visible = true;
            btn_cadastrar_componente.Enabled = true;
            btn_cadastrar_componente.Visible = true;
            btn_editar_componente.Enabled = true;
            btn_editar_componente.Visible = true;
            lbl_pes_cod_componente.Enabled = true;
            lbl_pes_cod_componente.Visible = true;
            txt_pes_cod_componente.Enabled = true;
            txt_pes_cod_componente.Visible = true;
            lbl_pes_nome_componente.Enabled = true;
            lbl_pes_nome_componente.Visible = true;
            txt_pes_nome_componente.Enabled = true;
            txt_pes_nome_componente.Visible = true;
            btn_buscar_componente.Enabled = true;
            btn_buscar_componente.Visible = true;
            tbc_componente.Enabled = true;
            tbc_componente.Visible = true;
        }

        private void btn_manutenções_Click(object sender, EventArgs e)
        {
            desabilita();
            lbl_pesquisa.Visible = true;
            btn_solicitar_manutencao.Enabled = true;
            btn_solicitar_manutencao.Visible = true;
            lbl_pes_cod_manutencao.Enabled = true;
            lbl_pes_cod_manutencao.Visible = true;
            txt_pes_cod_manutencao.Enabled = true;
            txt_pes_cod_manutencao.Visible = true;
            lbl_pes_nome_manutencao.Enabled = true;
            lbl_pes_nome_manutencao.Visible = true;
            txt_pes_nome_manutencao.Enabled = true;
            txt_pes_nome_manutencao.Visible = true;
            btn_buscar_manutencao.Enabled = true;
            btn_buscar_manutencao.Visible = true;
        }

        private void btn_producao_Click(object sender, EventArgs e)
        {
            desabilita();
            lbl_pes_cod_producao.Enabled = true;
            lbl_pes_cod_producao.Visible = true;
            txt_pes_cod_producao.Enabled = true;
            txt_pes_cod_producao.Visible = true;
            lbl_pes_nome_producao.Enabled = true;
            lbl_pes_nome_producao.Visible = true;
            txt_pes_nome_producao.Enabled = true;
            txt_pes_nome_producao.Visible = true;
            btn_buscar_producao.Enabled = true;
            btn_buscar_producao.Visible = true;
            tbc_producao.Enabled = true;
            tbc_producao.Visible = true;
        }
        private void btn_produtos_Click(object sender, EventArgs e)
        {
            desabilita();
            lbl_pesquisa.Visible = true;
            btn_cadastrar_produto.Enabled = true;
            btn_cadastrar_produto.Visible = true;
            btn_editar_produto.Enabled = true;
            btn_editar_produto.Visible = true;
            lbl_pes_cod_produto.Enabled = true;
            lbl_pes_cod_produto.Visible = true;
            txt_pes_cod_produto.Enabled = true;
            txt_pes_cod_produto.Visible = true;
            lbl_pes_nome_produto.Enabled = true;
            lbl_pes_nome_produto.Visible = true;
            txt_pes_nome_produto.Enabled = true;
            txt_pes_nome_produto.Visible = true;
            btn_buscar_produto.Enabled = true;
            btn_buscar_produto.Visible = true;
            txt_pes_cod_produto.Text = "";
            txt_pes_nome_produto.Text = "";
        }

        private void btn_calendario_Click(object sender, EventArgs e)
        {
            calendario();
        }

        private void lbl_data_Click(object sender, EventArgs e)
        {
            calendario();
        }
        
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }

        private void btn_clienteTSM_Click(object sender, EventArgs e)
        {
            new frm_cadastro_cliente().ShowDialog();
        }

        private void btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            new frm_cadastro_cliente().ShowDialog();
        }

        private void btn_fornecedorTSM_Click(object sender, EventArgs e)
        {
            new frm_cadastro_fornecedor().ShowDialog();
        }

        private void btn_cadastrar_produto_Click(object sender, EventArgs e)
        {
            new frm_cadastro_produto().ShowDialog();
        }

        private void btn_novo_pedido_Click(object sender, EventArgs e)
        {
            new frm_novo_pedido().ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_cadastro_produto().ShowDialog();
        }

        private void btn_pedidoTSM_Click(object sender, EventArgs e)
        {
            new frm_novo_pedido().ShowDialog();
        }

        private void btn_manutencaoTSM_Click(object sender, EventArgs e)
        {
            new frm_solicita_manutencao().Show();
        }

        private void btn_solicitar_manutencao_Click(object sender, EventArgs e)
        {
            new frm_solicita_manutencao().ShowDialog();
        }

      
        private void btn_produtoTSM_Click_Click(object sender, EventArgs e)
        {
            new frm_cadastro_produto().ShowDialog();
        }

        private void btn_cadastrar_componente_Click(object sender, EventArgs e)
        {
            new frm_cadastro_componente().ShowDialog();
        }

        private void btn_materia_primaTSM_Click(object sender, EventArgs e)
        {
            new fmr_cadastro_componente_materia_prima().Show();
        }

        private void btn_componenteTSM_Click(object sender, EventArgs e)
        {
            new frm_cadastro_componente().ShowDialog();
        }

        private void btn_maquinaTSM_Click(object sender, EventArgs e)
        {
            new frm_cadastro_componente_maquina().Show();
        }

        private void btn_funcionarioTSM_Click(object sender, EventArgs e)
        {
            new frm_cadastro_funcionario().Show();    
        }

        private void btn_cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            new frm_cadastro_funcionario().Show();  
        }

        private void dependenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_cadastro_dependentes().Show();
        }

        private void btn_beneficiosTSM_Click(object sender, EventArgs e)
        {
            new frm_cadastro_beneficio().ShowDialog();
        }
        #endregion
        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            consulta_cliente();
        }

        private void frm_inicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_buscar_funcionario_Click(object sender, EventArgs e)
        {
            consulta_funcionario();
        }      
    }
}