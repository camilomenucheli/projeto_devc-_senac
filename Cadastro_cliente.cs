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
    public partial class frm_cadastro_cliente : Form
    {
        //variaveis
        int telefone1,telefone2;
        double cpf, cnpj;
        string cliente, pessoa_contato, email, razao_social, nome_fantasia,vsql,endereco_cobranca,endereco_correspondencia,endereco_entrega;

        SqlCommand dbcmd = null;
        SqlConnection sqlconn = null; //conexão sql nula
        const string strConn = @"Data Source=MOG0499671W10-1;Initial Catalog=bd_cliente;Integrated Security=True"; //endereço do banco de dados

        public frm_cadastro_cliente()
        {
            InitializeComponent();
        }
        //inserir, salvar
        #region
        public void salvar()
        {
            sqlconn = new SqlConnection(strConn);
            dbcmd = new SqlCommand();
            try
            {
                if (rb_pessoa_fisica.Checked == true)
                {
                    cliente = txt_nome_cliente.Text;
                    cpf = Convert.ToDouble(txt_cpf_cliente.Text);
                    pessoa_contato=txt_pessoacontato_cliente.Text;
                    email = txt_email_cliente.Text;
                    endereco_cobranca = txt_rua_cobranca.Text + " - "+ txt_numero_cobranca+ " "+ txt_bairro_cobranca.Text;
                    endereco_correspondencia = txt_rua_correspondencia.Text + " - " + txt_numero_correspondencia + " " + txt_bairro_correspondencia.Text;
                    endereco_entrega = txt_rua_entrega.Text + " - " + txt_numero_entrega + " " + txt_bairro_entrega.Text;
                    telefone1 = Convert.ToInt32(txt_telefone1_cliente.Text);
                    telefone2 = Convert.ToInt32(txt_telefone2_cliente.Text);
                    vsql = "insert into cliente(cliente,pessoa_contato,email,data_cadastramento) values ('" + cliente + "','" + pessoa_contato + "','" + email + "',getdate())";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    vsql = "insert into cliente_fisica(cpf) values ('" + cpf + "')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    vsql = "insert into endereco_cliente(id_tipo_endereco,endereco,cidade) values (1,'" + endereco_cobranca + "','" + cb_cidade_cobranca + "')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    vsql = "insert into endereco_cliente(id_tipo_endereco,endereco,cidade) values (2,'" + endereco_correspondencia + "','" + cb_cidade_cobranca + "')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    vsql = "insert into endereco_cliente(id_tipo_endereco,endereco,cidade) values (3,'" + endereco_entrega + "','" + cb_cidade_cobranca + "')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    vsql = "insert into telefone_cliente(telefone1,telefone2) values ('" + telefone1 + "','"+telefone2+"')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                }
                if (rb_pessoa_juridica.Checked == true)
                {
                    cliente = txt_nome_cliente.Text;
                    cnpj = Convert.ToDouble(txt_cnpj_cliente.Text);
                    pessoa_contato = txt_pessoacontato_cliente.Text;
                    email = txt_email_cliente.Text;
                    nome_fantasia = txt_nomefantasia_cliente.Text;
                    razao_social = txt_razao_social_cliente.Text;
                    endereco_cobranca = txt_rua_cobranca.Text + " - " + txt_numero_cobranca + " " + txt_bairro_cobranca.Text;
                    endereco_correspondencia = txt_rua_correspondencia.Text + " - " + txt_numero_correspondencia + " " + txt_bairro_correspondencia.Text;
                    endereco_entrega = txt_rua_entrega.Text + " - " + txt_numero_entrega + " " + txt_bairro_entrega.Text;
                    vsql = "insert into cliente(cliente,pessoa_contato,email,data_cadastramento) values ('" + cliente + "','" + pessoa_contato + "','" + email + "',getdate())";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    vsql = "insert into cliente_juridica(cnpj,nome_fantasia,razao_social) values ('" + cnpj + "','"+nome_fantasia+"','"+razao_social+"')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    vsql = "insert into endereco_cliente(id_tipo_endereco,endereco,cidade) values (1,'" + endereco_cobranca + "','" + cb_cidade_cobranca + "')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    vsql = "insert into endereco_cliente(id_tipo_endereco,endereco,cidade) values (2,'" + endereco_correspondencia + "','" + cb_cidade_cobranca + "')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                    vsql = "insert into endereco_cliente(id_tipo_endereco,endereco,cidade) values (3,'" + endereco_entrega + "','" + cb_cidade_cobranca + "')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    vsql = "insert into telefone_cliente(telefone1,telefone2) values ('" + telefone1 + "','" + telefone2 + "')";
                    dbcmd.CommandText = vsql;
                    dbcmd.Connection = sqlconn;
                    sqlconn.Open();
                    dbcmd.ExecuteNonQuery();
                    sqlconn.Close();
                }
            }
            catch (SqlException errorsql)
            {
                MessageBox.Show(errorsql + "");
            }
        }

        #endregion
        //valida cpf e cnpj
        #region
        public static bool validaCNPJ(string cnpj)

        {

            int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};

            int[] multiplicador2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};

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

            for(int i=0; i<12; i++)

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
            resto = 11-resto;
            }
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);

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
        #endregion
        #region
        public void desabilita_cliente()
        {
            lbl_cpf_cliente.Visible = false;
            txt_cpf_cliente.Enabled = false;
            txt_cpf_cliente.Visible = false;
            lbl_cnpj_cliente.Visible = false;
            txt_cnpj_cliente.Enabled = false;
            txt_cnpj_cliente.Visible = false;
            lbl_nomefantasia_cliente.Visible = false;
            txt_nomefantasia_cliente.Enabled = false;
            txt_nomefantasia_cliente.Visible = false;
            lbl_razao_social_cliente.Visible = false;
            txt_razao_social_cliente.Enabled = false;
            txt_razao_social_cliente.Visible = false;

        }

        private void rb_pessoa_fisica_CheckedChanged(object sender, EventArgs e)
        {
            desabilita_cliente();
            lbl_cpf_cliente.Visible = true;
            txt_cpf_cliente.Enabled = true;
            txt_cpf_cliente.Visible = true;
            txt_cnpj_cliente.Text = "";
            txt_nomefantasia_cliente.Text = "";
            txt_razao_social_cliente.Text = "";
        }

        private void frm_cadastro_cliente_Load(object sender, EventArgs e)
        {
            desabilita_cliente();
        }

        private void rb_pessoa_juridica_CheckedChanged(object sender, EventArgs e)
        {
            desabilita_cliente();
            lbl_cnpj_cliente.Visible = true;
            txt_cnpj_cliente.Enabled = true;
            txt_cnpj_cliente.Visible = true;
            lbl_nomefantasia_cliente.Visible = true;
            txt_nomefantasia_cliente.Enabled = true;
            txt_nomefantasia_cliente.Visible = true;
            lbl_razao_social_cliente.Visible = true;
            txt_razao_social_cliente.Enabled = true;
            txt_razao_social_cliente.Visible = true;
            txt_cpf_cliente.Text = "";
        }

        private void btn_cancelar_cliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cb_estado_correspondencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_cidade_correspondencia.Enabled = true;
        }

        private void cb_estado_cobranca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_cidade_cobranca.Enabled = true;
        }

        private void cb_estado_entrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_cidade_entrega.Enabled = true;
        }

        private void cb_cidade_cobranca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja usar os mesmos dados nos demais endereços?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txt_rua_correspondencia.Text = txt_rua_cobranca.Text;
                txt_numero_correspondencia.Text = txt_numero_cobranca.Text;
                txt_bairro_correspondencia.Text = txt_bairro_cobranca.Text;
                cb_cidade_correspondencia.Text = cb_cidade_cobranca.Text;
                cb_estado_correspondencia.Text = cb_estado_cobranca.Text;
                txt_rua_entrega.Text = txt_rua_cobranca.Text;
                txt_numero_entrega.Text = txt_numero_cobranca.Text;
                txt_bairro_entrega.Text = txt_bairro_cobranca.Text;
                cb_cidade_entrega.Text = cb_cidade_cobranca.Text;
                cb_estado_entrega.Text = cb_estado_cobranca.Text;
            }
        }

        private void frm_cadastro_cliente_Load_1(object sender, EventArgs e)
        {
            desabilita_cliente();
        }

        private void lbl_cpf_cliente_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_cpf_cliente_Leave(object sender, EventArgs e)
        {
            txt_cpf_cliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cpf = txt_cpf_cliente.Text;
            if (validaCPF(cpf) == false)
            {
                txt_cpf_cliente.Text = "";
                txt_cpf_cliente.Focus();
                MessageBox.Show("Digite um CPF Valido", "CPF Invalido");
            }
        }

        private void txt_cnpj_cliente_Leave_1(object sender, EventArgs e)
        {
            txt_cnpj_cliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cnpj = txt_cnpj_cliente.Text;
            if (validaCNPJ(cnpj) == false)
            {
                txt_cnpj_cliente.Text = "";
                txt_cpf_cliente.Focus();
                MessageBox.Show("Digite um CNPJ Valido", "CNPJ Invalido");
            }
        }

        private void txt_cnpj_cliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        #endregion

        private void btn_salvar_cliente_Click(object sender, EventArgs e)
        {
            if(rb_pessoa_fisica.Checked==false && rb_pessoa_juridica.Checked==false)
            {
                    MessageBox.Show("Escolha entre Pessoa Fisica ou Pessoa Juridica");
            }
            else
            {
            if (rb_pessoa_fisica.Checked == true)
            {
                if (txt_nome_cliente.Text != "" && txt_cpf_cliente.Text != "" && txt_telefone1_cliente.Text != "" && txt_rua_entrega.Text != "")
                {
                    salvar();
                }
                else
                {
                    MessageBox.Show("Digite Todos os Campos");
                }
            }
                if (rb_pessoa_juridica.Checked == true)
                {
                    if (txt_nome_cliente.Text != "" && txt_cnpj_cliente.Text != "" && txt_telefone1_cliente.Text != "" && txt_rua_entrega.Text != "")
                    {
                        salvar();
                    }
                    else
                    {
                        MessageBox.Show("Digite Todos os Campos");
                    }
                }
            }
        }
    }
}

