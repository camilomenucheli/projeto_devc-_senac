namespace Projeto_Final_1._0
{
    partial class frm_cadastro_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.rb_pessoa_fisica = new System.Windows.Forms.RadioButton();
            this.rb_pessoa_juridica = new System.Windows.Forms.RadioButton();
            this.txt_email_cliente = new System.Windows.Forms.TextBox();
            this.txt_pessoacontato_cliente = new System.Windows.Forms.TextBox();
            this.txt_bairro_cobranca = new System.Windows.Forms.TextBox();
            this.txt_rua_cobranca = new System.Windows.Forms.TextBox();
            this.txt_numero_cobranca = new System.Windows.Forms.TextBox();
            this.txt_numero_correspondencia = new System.Windows.Forms.TextBox();
            this.txt_bairro_correspondencia = new System.Windows.Forms.TextBox();
            this.txt_rua_correspondencia = new System.Windows.Forms.TextBox();
            this.txt_numero_entrega = new System.Windows.Forms.TextBox();
            this.txt_bairro_entrega = new System.Windows.Forms.TextBox();
            this.txt_rua_entrega = new System.Windows.Forms.TextBox();
            this.txt_nomefantasia_cliente = new System.Windows.Forms.TextBox();
            this.txt_razao_social_cliente = new System.Windows.Forms.TextBox();
            this.lbl_cpf_cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_end_cobranca = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_estado_cobranca = new System.Windows.Forms.ComboBox();
            this.cb_cidade_cobranca = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_end_correspondencia = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_estado_correspondencia = new System.Windows.Forms.ComboBox();
            this.cb_cidade_correspondencia = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_end_entrega = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_estado_entrega = new System.Windows.Forms.ComboBox();
            this.cb_cidade_entrega = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_salvar_cliente = new System.Windows.Forms.Button();
            this.btn_cancelar_cliente = new System.Windows.Forms.Button();
            this.txt_cpf_cliente = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone1_cliente = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone2_cliente = new System.Windows.Forms.MaskedTextBox();
            this.lbl_cnpj_cliente = new System.Windows.Forms.Label();
            this.txt_cnpj_cliente = new System.Windows.Forms.MaskedTextBox();
            this.lbl_nomefantasia_cliente = new System.Windows.Forms.Label();
            this.lbl_razao_social_cliente = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tb_end_cobranca.SuspendLayout();
            this.tb_end_correspondencia.SuspendLayout();
            this.tb_end_entrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome.:";
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(59, 6);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(544, 20);
            this.txt_nome_cliente.TabIndex = 0;
            // 
            // rb_pessoa_fisica
            // 
            this.rb_pessoa_fisica.AutoSize = true;
            this.rb_pessoa_fisica.Location = new System.Drawing.Point(59, 35);
            this.rb_pessoa_fisica.Name = "rb_pessoa_fisica";
            this.rb_pessoa_fisica.Size = new System.Drawing.Size(92, 17);
            this.rb_pessoa_fisica.TabIndex = 1;
            this.rb_pessoa_fisica.TabStop = true;
            this.rb_pessoa_fisica.Text = "Pessoa Física";
            this.rb_pessoa_fisica.UseVisualStyleBackColor = true;
            this.rb_pessoa_fisica.CheckedChanged += new System.EventHandler(this.rb_pessoa_fisica_CheckedChanged);
            // 
            // rb_pessoa_juridica
            // 
            this.rb_pessoa_juridica.AutoSize = true;
            this.rb_pessoa_juridica.Location = new System.Drawing.Point(157, 35);
            this.rb_pessoa_juridica.Name = "rb_pessoa_juridica";
            this.rb_pessoa_juridica.Size = new System.Drawing.Size(101, 17);
            this.rb_pessoa_juridica.TabIndex = 2;
            this.rb_pessoa_juridica.TabStop = true;
            this.rb_pessoa_juridica.Text = "Pessoa Jurídica";
            this.rb_pessoa_juridica.UseVisualStyleBackColor = true;
            this.rb_pessoa_juridica.CheckedChanged += new System.EventHandler(this.rb_pessoa_juridica_CheckedChanged);
            // 
            // txt_email_cliente
            // 
            this.txt_email_cliente.Location = new System.Drawing.Point(242, 136);
            this.txt_email_cliente.Name = "txt_email_cliente";
            this.txt_email_cliente.Size = new System.Drawing.Size(361, 20);
            this.txt_email_cliente.TabIndex = 9;
            // 
            // txt_pessoacontato_cliente
            // 
            this.txt_pessoacontato_cliente.Location = new System.Drawing.Point(307, 110);
            this.txt_pessoacontato_cliente.Name = "txt_pessoacontato_cliente";
            this.txt_pessoacontato_cliente.Size = new System.Drawing.Size(296, 20);
            this.txt_pessoacontato_cliente.TabIndex = 7;
            // 
            // txt_bairro_cobranca
            // 
            this.txt_bairro_cobranca.Location = new System.Drawing.Point(52, 40);
            this.txt_bairro_cobranca.Name = "txt_bairro_cobranca";
            this.txt_bairro_cobranca.Size = new System.Drawing.Size(199, 20);
            this.txt_bairro_cobranca.TabIndex = 13;
            // 
            // txt_rua_cobranca
            // 
            this.txt_rua_cobranca.Location = new System.Drawing.Point(43, 14);
            this.txt_rua_cobranca.Name = "txt_rua_cobranca";
            this.txt_rua_cobranca.Size = new System.Drawing.Size(403, 20);
            this.txt_rua_cobranca.TabIndex = 11;
            // 
            // txt_numero_cobranca
            // 
            this.txt_numero_cobranca.Location = new System.Drawing.Point(508, 14);
            this.txt_numero_cobranca.Name = "txt_numero_cobranca";
            this.txt_numero_cobranca.Size = new System.Drawing.Size(69, 20);
            this.txt_numero_cobranca.TabIndex = 12;
            // 
            // txt_numero_correspondencia
            // 
            this.txt_numero_correspondencia.Location = new System.Drawing.Point(508, 14);
            this.txt_numero_correspondencia.Name = "txt_numero_correspondencia";
            this.txt_numero_correspondencia.Size = new System.Drawing.Size(69, 20);
            this.txt_numero_correspondencia.TabIndex = 18;
            // 
            // txt_bairro_correspondencia
            // 
            this.txt_bairro_correspondencia.Location = new System.Drawing.Point(52, 40);
            this.txt_bairro_correspondencia.Name = "txt_bairro_correspondencia";
            this.txt_bairro_correspondencia.Size = new System.Drawing.Size(199, 20);
            this.txt_bairro_correspondencia.TabIndex = 19;
            // 
            // txt_rua_correspondencia
            // 
            this.txt_rua_correspondencia.Location = new System.Drawing.Point(43, 14);
            this.txt_rua_correspondencia.Name = "txt_rua_correspondencia";
            this.txt_rua_correspondencia.Size = new System.Drawing.Size(403, 20);
            this.txt_rua_correspondencia.TabIndex = 17;
            // 
            // txt_numero_entrega
            // 
            this.txt_numero_entrega.Location = new System.Drawing.Point(508, 14);
            this.txt_numero_entrega.Name = "txt_numero_entrega";
            this.txt_numero_entrega.Size = new System.Drawing.Size(69, 20);
            this.txt_numero_entrega.TabIndex = 24;
            // 
            // txt_bairro_entrega
            // 
            this.txt_bairro_entrega.Location = new System.Drawing.Point(52, 40);
            this.txt_bairro_entrega.Name = "txt_bairro_entrega";
            this.txt_bairro_entrega.Size = new System.Drawing.Size(199, 20);
            this.txt_bairro_entrega.TabIndex = 25;
            // 
            // txt_rua_entrega
            // 
            this.txt_rua_entrega.Location = new System.Drawing.Point(43, 14);
            this.txt_rua_entrega.Name = "txt_rua_entrega";
            this.txt_rua_entrega.Size = new System.Drawing.Size(403, 20);
            this.txt_rua_entrega.TabIndex = 23;
            // 
            // txt_nomefantasia_cliente
            // 
            this.txt_nomefantasia_cliente.Location = new System.Drawing.Point(288, 58);
            this.txt_nomefantasia_cliente.Name = "txt_nomefantasia_cliente";
            this.txt_nomefantasia_cliente.Size = new System.Drawing.Size(315, 20);
            this.txt_nomefantasia_cliente.TabIndex = 4;
            // 
            // txt_razao_social_cliente
            // 
            this.txt_razao_social_cliente.Location = new System.Drawing.Point(94, 84);
            this.txt_razao_social_cliente.Name = "txt_razao_social_cliente";
            this.txt_razao_social_cliente.Size = new System.Drawing.Size(509, 20);
            this.txt_razao_social_cliente.TabIndex = 5;
            // 
            // lbl_cpf_cliente
            // 
            this.lbl_cpf_cliente.AutoSize = true;
            this.lbl_cpf_cliente.Location = new System.Drawing.Point(20, 61);
            this.lbl_cpf_cliente.Name = "lbl_cpf_cliente";
            this.lbl_cpf_cliente.Size = new System.Drawing.Size(33, 13);
            this.lbl_cpf_cliente.TabIndex = 4;
            this.lbl_cpf_cliente.Text = "CPF.:";
            this.lbl_cpf_cliente.Leave += new System.EventHandler(this.lbl_cpf_cliente_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone 2.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone 1.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pessoa de Contato.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email.:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_end_cobranca);
            this.tabControl1.Controls.Add(this.tb_end_correspondencia);
            this.tabControl1.Controls.Add(this.tb_end_entrega);
            this.tabControl1.Location = new System.Drawing.Point(12, 165);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 100);
            this.tabControl1.TabIndex = 22;
            // 
            // tb_end_cobranca
            // 
            this.tb_end_cobranca.Controls.Add(this.label10);
            this.tb_end_cobranca.Controls.Add(this.cb_estado_cobranca);
            this.tb_end_cobranca.Controls.Add(this.cb_cidade_cobranca);
            this.tb_end_cobranca.Controls.Add(this.label9);
            this.tb_end_cobranca.Controls.Add(this.txt_numero_cobranca);
            this.tb_end_cobranca.Controls.Add(this.label8);
            this.tb_end_cobranca.Controls.Add(this.txt_bairro_cobranca);
            this.tb_end_cobranca.Controls.Add(this.label6);
            this.tb_end_cobranca.Controls.Add(this.txt_rua_cobranca);
            this.tb_end_cobranca.Controls.Add(this.label7);
            this.tb_end_cobranca.Location = new System.Drawing.Point(4, 22);
            this.tb_end_cobranca.Name = "tb_end_cobranca";
            this.tb_end_cobranca.Padding = new System.Windows.Forms.Padding(3);
            this.tb_end_cobranca.Size = new System.Drawing.Size(583, 74);
            this.tb_end_cobranca.TabIndex = 0;
            this.tb_end_cobranca.Text = "Endereço Cobrança";
            this.tb_end_cobranca.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Estado.:";
            // 
            // cb_estado_cobranca
            // 
            this.cb_estado_cobranca.FormattingEnabled = true;
            this.cb_estado_cobranca.Items.AddRange(new object[] {
            "",
            "SP"});
            this.cb_estado_cobranca.Location = new System.Drawing.Point(488, 40);
            this.cb_estado_cobranca.Name = "cb_estado_cobranca";
            this.cb_estado_cobranca.Size = new System.Drawing.Size(88, 21);
            this.cb_estado_cobranca.TabIndex = 14;
            this.cb_estado_cobranca.SelectedIndexChanged += new System.EventHandler(this.cb_estado_cobranca_SelectedIndexChanged);
            // 
            // cb_cidade_cobranca
            // 
            this.cb_cidade_cobranca.Enabled = false;
            this.cb_cidade_cobranca.FormattingEnabled = true;
            this.cb_cidade_cobranca.Items.AddRange(new object[] {
            "",
            "Mogi Guaçu"});
            this.cb_cidade_cobranca.Location = new System.Drawing.Point(309, 40);
            this.cb_cidade_cobranca.Name = "cb_cidade_cobranca";
            this.cb_cidade_cobranca.Size = new System.Drawing.Size(121, 21);
            this.cb_cidade_cobranca.TabIndex = 15;
            this.cb_cidade_cobranca.SelectedIndexChanged += new System.EventHandler(this.cb_cidade_cobranca_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cidade.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Número.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rua.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bairro.:";
            // 
            // tb_end_correspondencia
            // 
            this.tb_end_correspondencia.Controls.Add(this.label11);
            this.tb_end_correspondencia.Controls.Add(this.cb_estado_correspondencia);
            this.tb_end_correspondencia.Controls.Add(this.cb_cidade_correspondencia);
            this.tb_end_correspondencia.Controls.Add(this.label12);
            this.tb_end_correspondencia.Controls.Add(this.txt_numero_correspondencia);
            this.tb_end_correspondencia.Controls.Add(this.label13);
            this.tb_end_correspondencia.Controls.Add(this.txt_bairro_correspondencia);
            this.tb_end_correspondencia.Controls.Add(this.label14);
            this.tb_end_correspondencia.Controls.Add(this.txt_rua_correspondencia);
            this.tb_end_correspondencia.Controls.Add(this.label15);
            this.tb_end_correspondencia.Location = new System.Drawing.Point(4, 22);
            this.tb_end_correspondencia.Name = "tb_end_correspondencia";
            this.tb_end_correspondencia.Padding = new System.Windows.Forms.Padding(3);
            this.tb_end_correspondencia.Size = new System.Drawing.Size(583, 74);
            this.tb_end_correspondencia.TabIndex = 1;
            this.tb_end_correspondencia.Text = "Endereço Correspondência";
            this.tb_end_correspondencia.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Estado.:";
            // 
            // cb_estado_correspondencia
            // 
            this.cb_estado_correspondencia.FormattingEnabled = true;
            this.cb_estado_correspondencia.Items.AddRange(new object[] {
            "",
            "SP"});
            this.cb_estado_correspondencia.Location = new System.Drawing.Point(488, 40);
            this.cb_estado_correspondencia.Name = "cb_estado_correspondencia";
            this.cb_estado_correspondencia.Size = new System.Drawing.Size(88, 21);
            this.cb_estado_correspondencia.TabIndex = 20;
            this.cb_estado_correspondencia.SelectedIndexChanged += new System.EventHandler(this.cb_estado_correspondencia_SelectedIndexChanged);
            // 
            // cb_cidade_correspondencia
            // 
            this.cb_cidade_correspondencia.Enabled = false;
            this.cb_cidade_correspondencia.FormattingEnabled = true;
            this.cb_cidade_correspondencia.Items.AddRange(new object[] {
            "",
            "Mogi Guaçu"});
            this.cb_cidade_correspondencia.Location = new System.Drawing.Point(309, 40);
            this.cb_cidade_correspondencia.Name = "cb_cidade_correspondencia";
            this.cb_cidade_correspondencia.Size = new System.Drawing.Size(121, 21);
            this.cb_cidade_correspondencia.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Cidade.:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(452, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Número.:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Rua.:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Bairro.:";
            // 
            // tb_end_entrega
            // 
            this.tb_end_entrega.Controls.Add(this.label16);
            this.tb_end_entrega.Controls.Add(this.cb_estado_entrega);
            this.tb_end_entrega.Controls.Add(this.cb_cidade_entrega);
            this.tb_end_entrega.Controls.Add(this.label17);
            this.tb_end_entrega.Controls.Add(this.txt_numero_entrega);
            this.tb_end_entrega.Controls.Add(this.label18);
            this.tb_end_entrega.Controls.Add(this.txt_bairro_entrega);
            this.tb_end_entrega.Controls.Add(this.label19);
            this.tb_end_entrega.Controls.Add(this.txt_rua_entrega);
            this.tb_end_entrega.Controls.Add(this.label20);
            this.tb_end_entrega.Location = new System.Drawing.Point(4, 22);
            this.tb_end_entrega.Name = "tb_end_entrega";
            this.tb_end_entrega.Size = new System.Drawing.Size(583, 74);
            this.tb_end_entrega.TabIndex = 2;
            this.tb_end_entrega.Text = "Endereço Entrega";
            this.tb_end_entrega.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(436, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Estado.:";
            // 
            // cb_estado_entrega
            // 
            this.cb_estado_entrega.FormattingEnabled = true;
            this.cb_estado_entrega.Items.AddRange(new object[] {
            "",
            "SP"});
            this.cb_estado_entrega.Location = new System.Drawing.Point(488, 40);
            this.cb_estado_entrega.Name = "cb_estado_entrega";
            this.cb_estado_entrega.Size = new System.Drawing.Size(88, 21);
            this.cb_estado_entrega.TabIndex = 26;
            this.cb_estado_entrega.SelectedIndexChanged += new System.EventHandler(this.cb_estado_entrega_SelectedIndexChanged);
            // 
            // cb_cidade_entrega
            // 
            this.cb_cidade_entrega.Enabled = false;
            this.cb_cidade_entrega.FormattingEnabled = true;
            this.cb_cidade_entrega.Items.AddRange(new object[] {
            "",
            "Mogi Guaçu"});
            this.cb_cidade_entrega.Location = new System.Drawing.Point(309, 40);
            this.cb_cidade_entrega.Name = "cb_cidade_entrega";
            this.cb_cidade_entrega.Size = new System.Drawing.Size(121, 21);
            this.cb_cidade_entrega.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(257, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Cidade.:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(452, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Número.:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Rua.:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Bairro.:";
            // 
            // btn_salvar_cliente
            // 
            this.btn_salvar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_cliente.Location = new System.Drawing.Point(443, 271);
            this.btn_salvar_cliente.Name = "btn_salvar_cliente";
            this.btn_salvar_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_cliente.TabIndex = 29;
            this.btn_salvar_cliente.Text = "Salvar";
            this.btn_salvar_cliente.UseVisualStyleBackColor = true;
            this.btn_salvar_cliente.Click += new System.EventHandler(this.btn_salvar_cliente_Click);
            // 
            // btn_cancelar_cliente
            // 
            this.btn_cancelar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_cliente.Location = new System.Drawing.Point(524, 271);
            this.btn_cancelar_cliente.Name = "btn_cancelar_cliente";
            this.btn_cancelar_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_cliente.TabIndex = 30;
            this.btn_cancelar_cliente.Text = "Cancelar";
            this.btn_cancelar_cliente.UseVisualStyleBackColor = true;
            this.btn_cancelar_cliente.Click += new System.EventHandler(this.btn_cancelar_cliente_Click);
            // 
            // txt_cpf_cliente
            // 
            this.txt_cpf_cliente.Location = new System.Drawing.Point(59, 58);
            this.txt_cpf_cliente.Mask = "###,###,###-##";
            this.txt_cpf_cliente.Name = "txt_cpf_cliente";
            this.txt_cpf_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf_cliente.TabIndex = 3;
            this.txt_cpf_cliente.Leave += new System.EventHandler(this.txt_cpf_cliente_Leave);
            // 
            // txt_telefone1_cliente
            // 
            this.txt_telefone1_cliente.Location = new System.Drawing.Point(83, 110);
            this.txt_telefone1_cliente.Mask = "(##) ####-####";
            this.txt_telefone1_cliente.Name = "txt_telefone1_cliente";
            this.txt_telefone1_cliente.Size = new System.Drawing.Size(109, 20);
            this.txt_telefone1_cliente.TabIndex = 6;
            // 
            // txt_telefone2_cliente
            // 
            this.txt_telefone2_cliente.Location = new System.Drawing.Point(83, 136);
            this.txt_telefone2_cliente.Mask = "(##) ####-####";
            this.txt_telefone2_cliente.Name = "txt_telefone2_cliente";
            this.txt_telefone2_cliente.Size = new System.Drawing.Size(109, 20);
            this.txt_telefone2_cliente.TabIndex = 8;
            // 
            // lbl_cnpj_cliente
            // 
            this.lbl_cnpj_cliente.AutoSize = true;
            this.lbl_cnpj_cliente.Location = new System.Drawing.Point(13, 61);
            this.lbl_cnpj_cliente.Name = "lbl_cnpj_cliente";
            this.lbl_cnpj_cliente.Size = new System.Drawing.Size(40, 13);
            this.lbl_cnpj_cliente.TabIndex = 115;
            this.lbl_cnpj_cliente.Text = "CNPJ.:";
            // 
            // txt_cnpj_cliente
            // 
            this.txt_cnpj_cliente.Location = new System.Drawing.Point(59, 58);
            this.txt_cnpj_cliente.Mask = "##.###.###/####-##";
            this.txt_cnpj_cliente.Name = "txt_cnpj_cliente";
            this.txt_cnpj_cliente.Size = new System.Drawing.Size(126, 20);
            this.txt_cnpj_cliente.TabIndex = 3;
            this.txt_cnpj_cliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_cnpj_cliente_MaskInputRejected);
            this.txt_cnpj_cliente.Leave += new System.EventHandler(this.txt_cnpj_cliente_Leave_1);
            // 
            // lbl_nomefantasia_cliente
            // 
            this.lbl_nomefantasia_cliente.AutoSize = true;
            this.lbl_nomefantasia_cliente.Location = new System.Drawing.Point(198, 61);
            this.lbl_nomefantasia_cliente.Name = "lbl_nomefantasia_cliente";
            this.lbl_nomefantasia_cliente.Size = new System.Drawing.Size(84, 13);
            this.lbl_nomefantasia_cliente.TabIndex = 117;
            this.lbl_nomefantasia_cliente.Text = "Nome Fantasia.:";
            // 
            // lbl_razao_social_cliente
            // 
            this.lbl_razao_social_cliente.AutoSize = true;
            this.lbl_razao_social_cliente.Location = new System.Drawing.Point(12, 87);
            this.lbl_razao_social_cliente.Name = "lbl_razao_social_cliente";
            this.lbl_razao_social_cliente.Size = new System.Drawing.Size(76, 13);
            this.lbl_razao_social_cliente.TabIndex = 119;
            this.lbl_razao_social_cliente.Text = "Razão Social.:";
            // 
            // frm_cadastro_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 301);
            this.Controls.Add(this.txt_razao_social_cliente);
            this.Controls.Add(this.lbl_razao_social_cliente);
            this.Controls.Add(this.txt_nomefantasia_cliente);
            this.Controls.Add(this.lbl_nomefantasia_cliente);
            this.Controls.Add(this.txt_cnpj_cliente);
            this.Controls.Add(this.lbl_cnpj_cliente);
            this.Controls.Add(this.txt_telefone2_cliente);
            this.Controls.Add(this.txt_telefone1_cliente);
            this.Controls.Add(this.txt_cpf_cliente);
            this.Controls.Add(this.btn_cancelar_cliente);
            this.Controls.Add(this.btn_salvar_cliente);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_email_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pessoacontato_cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_cpf_cliente);
            this.Controls.Add(this.rb_pessoa_juridica);
            this.Controls.Add(this.rb_pessoa_fisica);
            this.Controls.Add(this.txt_nome_cliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_cliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frm_cadastro_cliente_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tb_end_cobranca.ResumeLayout(false);
            this.tb_end_cobranca.PerformLayout();
            this.tb_end_correspondencia.ResumeLayout(false);
            this.tb_end_correspondencia.PerformLayout();
            this.tb_end_entrega.ResumeLayout(false);
            this.tb_end_entrega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome_cliente;
        private System.Windows.Forms.RadioButton rb_pessoa_fisica;
        private System.Windows.Forms.RadioButton rb_pessoa_juridica;
        private System.Windows.Forms.Label lbl_cpf_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pessoacontato_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_end_cobranca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_estado_cobranca;
        private System.Windows.Forms.ComboBox cb_cidade_cobranca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_numero_cobranca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_bairro_cobranca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_rua_cobranca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tb_end_correspondencia;
        private System.Windows.Forms.Button btn_salvar_cliente;
        private System.Windows.Forms.Button btn_cancelar_cliente;
        private System.Windows.Forms.MaskedTextBox txt_cpf_cliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_estado_correspondencia;
        private System.Windows.Forms.ComboBox cb_cidade_correspondencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_numero_correspondencia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_bairro_correspondencia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_rua_correspondencia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tb_end_entrega;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_estado_entrega;
        private System.Windows.Forms.ComboBox cb_cidade_entrega;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_numero_entrega;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_bairro_entrega;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_rua_entrega;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox txt_telefone1_cliente;
        private System.Windows.Forms.MaskedTextBox txt_telefone2_cliente;
        private System.Windows.Forms.Label lbl_cnpj_cliente;
        private System.Windows.Forms.MaskedTextBox txt_cnpj_cliente;
        private System.Windows.Forms.Label lbl_nomefantasia_cliente;
        private System.Windows.Forms.TextBox txt_nomefantasia_cliente;
        private System.Windows.Forms.TextBox txt_razao_social_cliente;
        private System.Windows.Forms.Label lbl_razao_social_cliente;
    }
}