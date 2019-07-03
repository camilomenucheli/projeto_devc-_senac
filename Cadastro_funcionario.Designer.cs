namespace Projeto_Final_1._0
{
    partial class frm_cadastro_funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_funcionario));
            this.txt_telefone1_funcionario = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf_funcionario = new System.Windows.Forms.MaskedTextBox();
            this.btn_cancelar_cliente = new System.Windows.Forms.Button();
            this.btn_salvar_cliente = new System.Windows.Forms.Button();
            this.txt_qualificacao_funcionario = new System.Windows.Forms.TextBox();
            this.txt_nome_funcionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_cpf_cliente = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_data_funcionario = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cb_cargo_funcionario = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_salario_funcionario = new System.Windows.Forms.MaskedTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_estado_funcionario = new System.Windows.Forms.ComboBox();
            this.cb_cidade_funcionario = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_numero_funcionario = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_bairro_funcionario = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_rua_funcionario = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_telefone2_funcionario = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_telefone1_funcionario
            // 
            this.txt_telefone1_funcionario.Location = new System.Drawing.Point(258, 59);
            this.txt_telefone1_funcionario.Mask = "(##) ####-####";
            this.txt_telefone1_funcionario.Name = "txt_telefone1_funcionario";
            this.txt_telefone1_funcionario.Size = new System.Drawing.Size(130, 20);
            this.txt_telefone1_funcionario.TabIndex = 6;
            // 
            // txt_cpf_funcionario
            // 
            this.txt_cpf_funcionario.Location = new System.Drawing.Point(59, 31);
            this.txt_cpf_funcionario.Mask = "###,###,###-##";
            this.txt_cpf_funcionario.Name = "txt_cpf_funcionario";
            this.txt_cpf_funcionario.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf_funcionario.TabIndex = 2;
            this.txt_cpf_funcionario.Leave += new System.EventHandler(this.txt_cpf_funcionario_Leave);
            // 
            // btn_cancelar_cliente
            // 
            this.btn_cancelar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_cliente.Location = new System.Drawing.Point(524, 305);
            this.btn_cancelar_cliente.Name = "btn_cancelar_cliente";
            this.btn_cancelar_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_cliente.TabIndex = 139;
            this.btn_cancelar_cliente.Text = "Cancelar";
            this.btn_cancelar_cliente.UseVisualStyleBackColor = true;
            this.btn_cancelar_cliente.Click += new System.EventHandler(this.btn_cancelar_cliente_Click);
            // 
            // btn_salvar_cliente
            // 
            this.btn_salvar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_cliente.Location = new System.Drawing.Point(443, 305);
            this.btn_salvar_cliente.Name = "btn_salvar_cliente";
            this.btn_salvar_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_cliente.TabIndex = 138;
            this.btn_salvar_cliente.Text = "Salvar";
            this.btn_salvar_cliente.UseVisualStyleBackColor = true;
            this.btn_salvar_cliente.Click += new System.EventHandler(this.btn_salvar_cliente_Click);
            // 
            // txt_qualificacao_funcionario
            // 
            this.txt_qualificacao_funcionario.Location = new System.Drawing.Point(18, 104);
            this.txt_qualificacao_funcionario.Multiline = true;
            this.txt_qualificacao_funcionario.Name = "txt_qualificacao_funcionario";
            this.txt_qualificacao_funcionario.Size = new System.Drawing.Size(585, 105);
            this.txt_qualificacao_funcionario.TabIndex = 7;
            // 
            // txt_nome_funcionario
            // 
            this.txt_nome_funcionario.Location = new System.Drawing.Point(59, 6);
            this.txt_nome_funcionario.Name = "txt_nome_funcionario";
            this.txt_nome_funcionario.Size = new System.Drawing.Size(544, 20);
            this.txt_nome_funcionario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Nome.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 133;
            this.label3.Text = "Telefone 1.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Telefone 2.:";
            // 
            // lbl_cpf_cliente
            // 
            this.lbl_cpf_cliente.AutoSize = true;
            this.lbl_cpf_cliente.Location = new System.Drawing.Point(13, 35);
            this.lbl_cpf_cliente.Name = "lbl_cpf_cliente";
            this.lbl_cpf_cliente.Size = new System.Drawing.Size(33, 13);
            this.lbl_cpf_cliente.TabIndex = 126;
            this.lbl_cpf_cliente.Text = "CPF.:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(165, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 13);
            this.label21.TabIndex = 141;
            this.label21.Text = "Data Admissão.:";
            // 
            // txt_data_funcionario
            // 
            this.txt_data_funcionario.Location = new System.Drawing.Point(255, 32);
            this.txt_data_funcionario.Name = "txt_data_funcionario";
            this.txt_data_funcionario.Size = new System.Drawing.Size(100, 20);
            this.txt_data_funcionario.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(362, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 143;
            this.label22.Text = "Cargo.:";
            // 
            // cb_cargo_funcionario
            // 
            this.cb_cargo_funcionario.FormattingEnabled = true;
            this.cb_cargo_funcionario.Location = new System.Drawing.Point(408, 32);
            this.cb_cargo_funcionario.Name = "cb_cargo_funcionario";
            this.cb_cargo_funcionario.Size = new System.Drawing.Size(194, 21);
            this.cb_cargo_funcionario.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 145;
            this.label23.Text = "Salário.:";
            // 
            // txt_salario_funcionario
            // 
            this.txt_salario_funcionario.Location = new System.Drawing.Point(59, 59);
            this.txt_salario_funcionario.Mask = "$ 00000,00";
            this.txt_salario_funcionario.Name = "txt_salario_funcionario";
            this.txt_salario_funcionario.Size = new System.Drawing.Size(120, 20);
            this.txt_salario_funcionario.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 13);
            this.label24.TabIndex = 148;
            this.label24.Text = "Qualificação Prof.:";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(458, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 159;
            this.label16.Text = "Estado.:";
            // 
            // cb_estado_funcionario
            // 
            this.cb_estado_funcionario.FormattingEnabled = true;
            this.cb_estado_funcionario.Items.AddRange(new object[] {
            "",
            "SP"});
            this.cb_estado_funcionario.Location = new System.Drawing.Point(510, 241);
            this.cb_estado_funcionario.Name = "cb_estado_funcionario";
            this.cb_estado_funcionario.Size = new System.Drawing.Size(88, 21);
            this.cb_estado_funcionario.TabIndex = 11;
            this.cb_estado_funcionario.SelectedIndexChanged += new System.EventHandler(this.cb_estado_entrega_SelectedIndexChanged);
            // 
            // cb_cidade_funcionario
            // 
            this.cb_cidade_funcionario.Enabled = false;
            this.cb_cidade_funcionario.FormattingEnabled = true;
            this.cb_cidade_funcionario.Items.AddRange(new object[] {
            "",
            "Mogi Guaçu"});
            this.cb_cidade_funcionario.Location = new System.Drawing.Point(331, 241);
            this.cb_cidade_funcionario.Name = "cb_cidade_funcionario";
            this.cb_cidade_funcionario.Size = new System.Drawing.Size(121, 21);
            this.cb_cidade_funcionario.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(279, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 157;
            this.label17.Text = "Cidade.:";
            // 
            // txt_numero_funcionario
            // 
            this.txt_numero_funcionario.Location = new System.Drawing.Point(530, 215);
            this.txt_numero_funcionario.Name = "txt_numero_funcionario";
            this.txt_numero_funcionario.Size = new System.Drawing.Size(69, 20);
            this.txt_numero_funcionario.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(474, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 154;
            this.label18.Text = "Número.:";
            // 
            // txt_bairro_funcionario
            // 
            this.txt_bairro_funcionario.Location = new System.Drawing.Point(59, 241);
            this.txt_bairro_funcionario.Name = "txt_bairro_funcionario";
            this.txt_bairro_funcionario.Size = new System.Drawing.Size(214, 20);
            this.txt_bairro_funcionario.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 218);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 151;
            this.label19.Text = "Rua.:";
            // 
            // txt_rua_funcionario
            // 
            this.txt_rua_funcionario.Location = new System.Drawing.Point(52, 215);
            this.txt_rua_funcionario.Name = "txt_rua_funcionario";
            this.txt_rua_funcionario.Size = new System.Drawing.Size(416, 20);
            this.txt_rua_funcionario.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 244);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 150;
            this.label20.Text = "Bairro.:";
            // 
            // txt_telefone2_funcionario
            // 
            this.txt_telefone2_funcionario.Location = new System.Drawing.Point(472, 59);
            this.txt_telefone2_funcionario.Mask = "(##) ####-####";
            this.txt_telefone2_funcionario.Name = "txt_telefone2_funcionario";
            this.txt_telefone2_funcionario.Size = new System.Drawing.Size(130, 20);
            this.txt_telefone2_funcionario.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 61);
            this.groupBox1.TabIndex = 160;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 161;
            this.label4.Text = "Usuário.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 162;
            this.label5.Text = "Senha.:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(61, 24);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(150, 20);
            this.txt_usuario.TabIndex = 164;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(267, 24);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(152, 20);
            this.txt_senha.TabIndex = 165;
            // 
            // frm_cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_telefone2_funcionario);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cb_estado_funcionario);
            this.Controls.Add(this.cb_cidade_funcionario);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_numero_funcionario);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_bairro_funcionario);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_rua_funcionario);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txt_salario_funcionario);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cb_cargo_funcionario);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_data_funcionario);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt_telefone1_funcionario);
            this.Controls.Add(this.txt_cpf_funcionario);
            this.Controls.Add(this.btn_cancelar_cliente);
            this.Controls.Add(this.btn_salvar_cliente);
            this.Controls.Add(this.txt_qualificacao_funcionario);
            this.Controls.Add(this.txt_nome_funcionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cpf_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionário";
            this.Load += new System.EventHandler(this.Cadastro_funcionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_telefone1_funcionario;
        private System.Windows.Forms.MaskedTextBox txt_cpf_funcionario;
        private System.Windows.Forms.Button btn_cancelar_cliente;
        private System.Windows.Forms.Button btn_salvar_cliente;
        private System.Windows.Forms.TextBox txt_qualificacao_funcionario;
        private System.Windows.Forms.TextBox txt_nome_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_cpf_cliente;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_data_funcionario;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cb_cargo_funcionario;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox txt_salario_funcionario;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_estado_funcionario;
        private System.Windows.Forms.ComboBox cb_cidade_funcionario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_numero_funcionario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_bairro_funcionario;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_rua_funcionario;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox txt_telefone2_funcionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}