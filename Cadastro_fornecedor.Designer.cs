namespace Projeto_Final_1._0
{
    partial class frm_cadastro_fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_fornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cnpj_fornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txt_razaosocial_fornecedor = new System.Windows.Forms.TextBox();
            this.txt_nome_fornecedor = new System.Windows.Forms.TextBox();
            this.txt_telefone1_fornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone2_fornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txt_pessoacontato1_fornecedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pessoacontato2_fornecedor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_cidade_fornecedor = new System.Windows.Forms.ComboBox();
            this.cb_estado_fornecedor = new System.Windows.Forms.ComboBox();
            this.txt_numero_fornecedor = new System.Windows.Forms.TextBox();
            this.txt_bairro_fornecedor = new System.Windows.Forms.TextBox();
            this.txt_rua_fornecedor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razão Social.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone 1.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pessoa de Contato 1.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone 2.:";
            // 
            // txt_cnpj_fornecedor
            // 
            this.txt_cnpj_fornecedor.Location = new System.Drawing.Point(58, 36);
            this.txt_cnpj_fornecedor.Mask = "##.###.###/####-##";
            this.txt_cnpj_fornecedor.Name = "txt_cnpj_fornecedor";
            this.txt_cnpj_fornecedor.Size = new System.Drawing.Size(111, 20);
            this.txt_cnpj_fornecedor.TabIndex = 2;
            this.txt_cnpj_fornecedor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_cnpj_fornecedor_MaskInputRejected);
            this.txt_cnpj_fornecedor.Leave += new System.EventHandler(this.txt_cnpj_fornecedor_Leave);
            // 
            // txt_razaosocial_fornecedor
            // 
            this.txt_razaosocial_fornecedor.Location = new System.Drawing.Point(257, 36);
            this.txt_razaosocial_fornecedor.Name = "txt_razaosocial_fornecedor";
            this.txt_razaosocial_fornecedor.Size = new System.Drawing.Size(345, 20);
            this.txt_razaosocial_fornecedor.TabIndex = 3;
            // 
            // txt_nome_fornecedor
            // 
            this.txt_nome_fornecedor.Location = new System.Drawing.Point(59, 6);
            this.txt_nome_fornecedor.Name = "txt_nome_fornecedor";
            this.txt_nome_fornecedor.Size = new System.Drawing.Size(543, 20);
            this.txt_nome_fornecedor.TabIndex = 1;
            // 
            // txt_telefone1_fornecedor
            // 
            this.txt_telefone1_fornecedor.Location = new System.Drawing.Point(82, 61);
            this.txt_telefone1_fornecedor.Mask = "(##) ####-####";
            this.txt_telefone1_fornecedor.Name = "txt_telefone1_fornecedor";
            this.txt_telefone1_fornecedor.Size = new System.Drawing.Size(87, 20);
            this.txt_telefone1_fornecedor.TabIndex = 4;
            // 
            // txt_telefone2_fornecedor
            // 
            this.txt_telefone2_fornecedor.Location = new System.Drawing.Point(82, 87);
            this.txt_telefone2_fornecedor.Mask = "(##) ####-####";
            this.txt_telefone2_fornecedor.Name = "txt_telefone2_fornecedor";
            this.txt_telefone2_fornecedor.Size = new System.Drawing.Size(87, 20);
            this.txt_telefone2_fornecedor.TabIndex = 6;
            // 
            // txt_pessoacontato1_fornecedor
            // 
            this.txt_pessoacontato1_fornecedor.Location = new System.Drawing.Point(293, 61);
            this.txt_pessoacontato1_fornecedor.Name = "txt_pessoacontato1_fornecedor";
            this.txt_pessoacontato1_fornecedor.Size = new System.Drawing.Size(309, 20);
            this.txt_pessoacontato1_fornecedor.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pessoa de Contato 2.:";
            // 
            // txt_pessoacontato2_fornecedor
            // 
            this.txt_pessoacontato2_fornecedor.Location = new System.Drawing.Point(293, 87);
            this.txt_pessoacontato2_fornecedor.Name = "txt_pessoacontato2_fornecedor";
            this.txt_pessoacontato2_fornecedor.Size = new System.Drawing.Size(309, 20);
            this.txt_pessoacontato2_fornecedor.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_cidade_fornecedor);
            this.groupBox1.Controls.Add(this.cb_estado_fornecedor);
            this.groupBox1.Controls.Add(this.txt_numero_fornecedor);
            this.groupBox1.Controls.Add(this.txt_bairro_fornecedor);
            this.groupBox1.Controls.Add(this.txt_rua_fornecedor);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 86);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // cb_cidade_fornecedor
            // 
            this.cb_cidade_fornecedor.Enabled = false;
            this.cb_cidade_fornecedor.FormattingEnabled = true;
            this.cb_cidade_fornecedor.ItemHeight = 13;
            this.cb_cidade_fornecedor.Items.AddRange(new object[] {
            "teste1"});
            this.cb_cidade_fornecedor.Location = new System.Drawing.Point(342, 49);
            this.cb_cidade_fornecedor.Name = "cb_cidade_fornecedor";
            this.cb_cidade_fornecedor.Size = new System.Drawing.Size(121, 21);
            this.cb_cidade_fornecedor.TabIndex = 12;
            // 
            // cb_estado_fornecedor
            // 
            this.cb_estado_fornecedor.FormattingEnabled = true;
            this.cb_estado_fornecedor.ItemHeight = 13;
            this.cb_estado_fornecedor.Items.AddRange(new object[] {
            "teste"});
            this.cb_estado_fornecedor.Location = new System.Drawing.Point(525, 49);
            this.cb_estado_fornecedor.Name = "cb_estado_fornecedor";
            this.cb_estado_fornecedor.Size = new System.Drawing.Size(56, 21);
            this.cb_estado_fornecedor.TabIndex = 11;
            this.cb_estado_fornecedor.SelectedIndexChanged += new System.EventHandler(this.cb_estado_fornecedor_SelectedIndexChanged);
            // 
            // txt_numero_fornecedor
            // 
            this.txt_numero_fornecedor.Location = new System.Drawing.Point(525, 23);
            this.txt_numero_fornecedor.Name = "txt_numero_fornecedor";
            this.txt_numero_fornecedor.Size = new System.Drawing.Size(56, 20);
            this.txt_numero_fornecedor.TabIndex = 9;
            // 
            // txt_bairro_fornecedor
            // 
            this.txt_bairro_fornecedor.Location = new System.Drawing.Point(52, 49);
            this.txt_bairro_fornecedor.Name = "txt_bairro_fornecedor";
            this.txt_bairro_fornecedor.Size = new System.Drawing.Size(232, 20);
            this.txt_bairro_fornecedor.TabIndex = 10;
            // 
            // txt_rua_fornecedor
            // 
            this.txt_rua_fornecedor.Location = new System.Drawing.Point(52, 23);
            this.txt_rua_fornecedor.Name = "txt_rua_fornecedor";
            this.txt_rua_fornecedor.Size = new System.Drawing.Size(411, 20);
            this.txt_rua_fornecedor.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(473, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Estado.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(290, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cidade.:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bairro.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Número.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rua.:";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(446, 207);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 16;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(527, 207);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_cadastro_fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 235);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_pessoacontato2_fornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_pessoacontato1_fornecedor);
            this.Controls.Add(this.txt_telefone2_fornecedor);
            this.Controls.Add(this.txt_telefone1_fornecedor);
            this.Controls.Add(this.txt_nome_fornecedor);
            this.Controls.Add(this.txt_razaosocial_fornecedor);
            this.Controls.Add(this.txt_cnpj_fornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Fornecedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_cnpj_fornecedor;
        private System.Windows.Forms.TextBox txt_razaosocial_fornecedor;
        private System.Windows.Forms.TextBox txt_nome_fornecedor;
        private System.Windows.Forms.MaskedTextBox txt_telefone1_fornecedor;
        private System.Windows.Forms.MaskedTextBox txt_telefone2_fornecedor;
        private System.Windows.Forms.TextBox txt_pessoacontato1_fornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pessoacontato2_fornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_cidade_fornecedor;
        private System.Windows.Forms.ComboBox cb_estado_fornecedor;
        private System.Windows.Forms.TextBox txt_numero_fornecedor;
        private System.Windows.Forms.TextBox txt_bairro_fornecedor;
        private System.Windows.Forms.TextBox txt_rua_fornecedor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}