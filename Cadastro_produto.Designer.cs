namespace Projeto_Final_1._0
{
    partial class frm_cadastro_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_produto));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txt_observacao_produto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tipo_prdoduto = new System.Windows.Forms.TextBox();
            this.txt_nome_produto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dimensoes1_produto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_milimitros = new System.Windows.Forms.Label();
            this.lbl_centimetros = new System.Windows.Forms.Label();
            this.lbl_metros = new System.Windows.Forms.Label();
            this.cb_medida = new System.Windows.Forms.ComboBox();
            this.txt_tempomedio_produto = new System.Windows.Forms.MaskedTextBox();
            this.txt_preco_produto = new System.Windows.Forms.MaskedTextBox();
            this.cb_quantidade_produto = new System.Windows.Forms.ComboBox();
            this.txt_dimensoes2_produto = new System.Windows.Forms.TextBox();
            this.txt_pesovolume_produto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(527, 179);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(446, 179);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 10;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txt_observacao_produto
            // 
            this.txt_observacao_produto.Location = new System.Drawing.Point(12, 109);
            this.txt_observacao_produto.Multiline = true;
            this.txt_observacao_produto.Name = "txt_observacao_produto";
            this.txt_observacao_produto.Size = new System.Drawing.Size(590, 64);
            this.txt_observacao_produto.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Peso Volume Min.:";
            // 
            // txt_tipo_prdoduto
            // 
            this.txt_tipo_prdoduto.Location = new System.Drawing.Point(107, 37);
            this.txt_tipo_prdoduto.Name = "txt_tipo_prdoduto";
            this.txt_tipo_prdoduto.Size = new System.Drawing.Size(202, 20);
            this.txt_tipo_prdoduto.TabIndex = 2;
            // 
            // txt_nome_produto
            // 
            this.txt_nome_produto.Location = new System.Drawing.Point(59, 11);
            this.txt_nome_produto.Name = "txt_nome_produto";
            this.txt_nome_produto.Size = new System.Drawing.Size(421, 20);
            this.txt_nome_produto.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tempo Médio Produção.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipo de Produto.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantidade.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Preço.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dimensões.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome.:";
            // 
            // txt_dimensoes1_produto
            // 
            this.txt_dimensoes1_produto.Enabled = false;
            this.txt_dimensoes1_produto.Location = new System.Drawing.Point(384, 38);
            this.txt_dimensoes1_produto.Name = "txt_dimensoes1_produto";
            this.txt_dimensoes1_produto.Size = new System.Drawing.Size(37, 20);
            this.txt_dimensoes1_produto.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(423, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "x";
            // 
            // lbl_milimitros
            // 
            this.lbl_milimitros.AutoSize = true;
            this.lbl_milimitros.Location = new System.Drawing.Point(475, 41);
            this.lbl_milimitros.Name = "lbl_milimitros";
            this.lbl_milimitros.Size = new System.Drawing.Size(23, 13);
            this.lbl_milimitros.TabIndex = 40;
            this.lbl_milimitros.Text = "mm";
            this.lbl_milimitros.Visible = false;
            // 
            // lbl_centimetros
            // 
            this.lbl_centimetros.AutoSize = true;
            this.lbl_centimetros.Location = new System.Drawing.Point(475, 41);
            this.lbl_centimetros.Name = "lbl_centimetros";
            this.lbl_centimetros.Size = new System.Drawing.Size(21, 13);
            this.lbl_centimetros.TabIndex = 41;
            this.lbl_centimetros.Text = "cm";
            this.lbl_centimetros.Visible = false;
            // 
            // lbl_metros
            // 
            this.lbl_metros.AutoSize = true;
            this.lbl_metros.Location = new System.Drawing.Point(475, 41);
            this.lbl_metros.Name = "lbl_metros";
            this.lbl_metros.Size = new System.Drawing.Size(15, 13);
            this.lbl_metros.TabIndex = 42;
            this.lbl_metros.Text = "m";
            this.lbl_metros.Visible = false;
            // 
            // cb_medida
            // 
            this.cb_medida.FormattingEnabled = true;
            this.cb_medida.Items.AddRange(new object[] {
            "Metros",
            "Centímetros",
            "Milímetros"});
            this.cb_medida.Location = new System.Drawing.Point(502, 37);
            this.cb_medida.Name = "cb_medida";
            this.cb_medida.Size = new System.Drawing.Size(100, 21);
            this.cb_medida.TabIndex = 3;
            this.cb_medida.SelectedIndexChanged += new System.EventHandler(this.cb_medida_SelectedIndexChanged);
            // 
            // txt_tempomedio_produto
            // 
            this.txt_tempomedio_produto.Location = new System.Drawing.Point(263, 63);
            this.txt_tempomedio_produto.Mask = "00d00h00m";
            this.txt_tempomedio_produto.Name = "txt_tempomedio_produto";
            this.txt_tempomedio_produto.Size = new System.Drawing.Size(83, 20);
            this.txt_tempomedio_produto.TabIndex = 7;
            // 
            // txt_preco_produto
            // 
            this.txt_preco_produto.Location = new System.Drawing.Point(59, 63);
            this.txt_preco_produto.Mask = "$ 0000,00";
            this.txt_preco_produto.Name = "txt_preco_produto";
            this.txt_preco_produto.Size = new System.Drawing.Size(66, 20);
            this.txt_preco_produto.TabIndex = 6;
            // 
            // cb_quantidade_produto
            // 
            this.cb_quantidade_produto.FormattingEnabled = true;
            this.cb_quantidade_produto.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cb_quantidade_produto.Location = new System.Drawing.Point(560, 10);
            this.cb_quantidade_produto.Name = "cb_quantidade_produto";
            this.cb_quantidade_produto.Size = new System.Drawing.Size(42, 21);
            this.cb_quantidade_produto.TabIndex = 1;
            // 
            // txt_dimensoes2_produto
            // 
            this.txt_dimensoes2_produto.Enabled = false;
            this.txt_dimensoes2_produto.Location = new System.Drawing.Point(436, 38);
            this.txt_dimensoes2_produto.Name = "txt_dimensoes2_produto";
            this.txt_dimensoes2_produto.Size = new System.Drawing.Size(37, 20);
            this.txt_dimensoes2_produto.TabIndex = 5;
            // 
            // txt_pesovolume_produto
            // 
            this.txt_pesovolume_produto.Location = new System.Drawing.Point(453, 63);
            this.txt_pesovolume_produto.Name = "txt_pesovolume_produto";
            this.txt_pesovolume_produto.Size = new System.Drawing.Size(149, 20);
            this.txt_pesovolume_produto.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Observações.:";
            // 
            // frm_cadastro_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 211);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_pesovolume_produto);
            this.Controls.Add(this.txt_dimensoes2_produto);
            this.Controls.Add(this.cb_quantidade_produto);
            this.Controls.Add(this.txt_preco_produto);
            this.Controls.Add(this.txt_tempomedio_produto);
            this.Controls.Add(this.cb_medida);
            this.Controls.Add(this.lbl_metros);
            this.Controls.Add(this.lbl_centimetros);
            this.Controls.Add(this.lbl_milimitros);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_dimensoes1_produto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_observacao_produto);
            this.Controls.Add(this.txt_tipo_prdoduto);
            this.Controls.Add(this.txt_nome_produto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_observacao_produto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tipo_prdoduto;
        private System.Windows.Forms.TextBox txt_nome_produto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dimensoes1_produto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_milimitros;
        private System.Windows.Forms.Label lbl_centimetros;
        private System.Windows.Forms.Label lbl_metros;
        private System.Windows.Forms.ComboBox cb_medida;
        private System.Windows.Forms.MaskedTextBox txt_tempomedio_produto;
        private System.Windows.Forms.MaskedTextBox txt_preco_produto;
        private System.Windows.Forms.ComboBox cb_quantidade_produto;
        private System.Windows.Forms.TextBox txt_dimensoes2_produto;
        private System.Windows.Forms.TextBox txt_pesovolume_produto;
        private System.Windows.Forms.Label label8;

    }
}