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
    public partial class frm_login : Form
    {
        SqlConnection sqlconn = null; //conexão sql nula
        private string strConn = @"Data Source=MOG0499671W10-1;Initial Catalog=bd_cliente;Integrated Security=True"; //endereço do banco de dados
        private string Conn_sql = string.Empty; // variavel que recebe comandos sql

        public frm_login()
        {
            InitializeComponent();
        }
        public void logar()
        {
            try
            {
                sqlconn = new SqlConnection(strConn);
                string usuario, senha;
                usuario = txt_Usuario.Text;
                senha = txt_Senha.Text;
                //alterar tudo em relação ao banco
                Conn_sql = "select count (cod) from funcionario where usuario=@usuario and senha=@senha";
                SqlCommand cmd = new SqlCommand(Conn_sql, sqlconn);//busca o comando no banco sqlconn e executa o comando com sql
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                sqlconn.Open();//abre o banco
                int v = (int)cmd.ExecuteScalar();
                if (v > 0)
                {
                    new frm_inicial(usuario).Show();
                    txt_Usuario.Text = "";
                    txt_Senha.Text = "";
                    this.Visible = false;
                }
                else
                {
                    autentica();
                }
            }
            catch (SqlException errosql)
            {
                MessageBox.Show(errosql + "Erro na conexão do banco"); // trata o erro do bloco executado no try
            }
        }

        public void autentica()
        {
            MessageBox.Show("Login e Senha Incorretos");
            txt_Usuario.Text = "";
            txt_Senha.Text = "";
            txt_Usuario.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            if (txt_Usuario.Text == "")
            {
                lbl_exlogin.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //logar();
            if (txt_Usuario.Text == "admin") 
            {
                if (txt_Senha.Text == "admin")
                {
                    new frm_inicial(txt_Usuario.Text).Show();
                    Close();
                }
                else
                {
                    autentica();
                }
            }
            else 
            { 
                autentica(); 
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void txt_Senha_Enter(object sender, EventArgs e)
        {       //AVISA SE O CAPSLOCK ESTA LIGADO, 
                Timer t = new Timer();
                t.Interval = 300;
                ToolTip tt = new ToolTip();
                tt.IsBalloon = true;
                tt.OwnerDraw = true;
                t.Tick += delegate
                {
                    if (Control.IsKeyLocked(Keys.CapsLock))
                        //SE NECESSÁRIO COLOCAR A MENSAGEM DE Caps-Lock ativado. NÃO UTILIZEI POR OPÇÃO DE
                        // JA TER A MENSAGEM TRAZIDA AUTOMATICAMENTE PELO WINDOWS APENAS COLOCANDO AS ASPAS.
                        tt.Show("", this, txt_Senha.Location + txt_Senha.Size);
                    else
                        tt.Hide(this);
                };
                t.Start();
      }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            lbl_exlogin.Visible = false;
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                lbl_exlogin.Visible = true;
            }
        }
    }
}
