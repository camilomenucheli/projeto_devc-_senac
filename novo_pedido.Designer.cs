namespace Projeto_Final_1._0
{
    partial class frm_novo_pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_novo_pedido));
            this.label8 = new System.Windows.Forms.Label();
            this.cb_quantidade_pedido = new System.Windows.Forms.ComboBox();
            this.txt_valor_liquido = new System.Windows.Forms.MaskedTextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txt_data_pedido = new System.Windows.Forms.TextBox();
            this.txt_cod_pedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_pedido = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remover_pedido = new System.Windows.Forms.Button();
            this.btn_adicionar_pedido = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_forma_pagamento = new System.Windows.Forms.ComboBox();
            this.txt_valor_desconto = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_valor_total = new System.Windows.Forms.MaskedTextBox();
            this.txt_desconto = new System.Windows.Forms.MaskedTextBox();
            this.cb_parcelas_pedido = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_valor_parcela = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Produtos Selecionados.:";
            // 
            // cb_quantidade_pedido
            // 
            this.cb_quantidade_pedido.FormattingEnabled = true;
            this.cb_quantidade_pedido.Items.AddRange(new object[] {
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
            this.cb_quantidade_pedido.Location = new System.Drawing.Point(294, 10);
            this.cb_quantidade_pedido.Name = "cb_quantidade_pedido";
            this.cb_quantidade_pedido.Size = new System.Drawing.Size(42, 21);
            this.cb_quantidade_pedido.TabIndex = 51;
            // 
            // txt_valor_liquido
            // 
            this.txt_valor_liquido.Location = new System.Drawing.Point(94, 230);
            this.txt_valor_liquido.Mask = "$ 0000.00";
            this.txt_valor_liquido.Name = "txt_valor_liquido";
            this.txt_valor_liquido.Size = new System.Drawing.Size(66, 20);
            this.txt_valor_liquido.TabIndex = 56;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(527, 256);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 61;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(446, 256);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 60;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // txt_data_pedido
            // 
            this.txt_data_pedido.Location = new System.Drawing.Point(400, 39);
            this.txt_data_pedido.Name = "txt_data_pedido";
            this.txt_data_pedido.Size = new System.Drawing.Size(202, 20);
            this.txt_data_pedido.TabIndex = 52;
            this.txt_data_pedido.TextChanged += new System.EventHandler(this.txt_data_pedido_TextChanged);
            // 
            // txt_cod_pedido
            // 
            this.txt_cod_pedido.Location = new System.Drawing.Point(117, 10);
            this.txt_cod_pedido.Name = "txt_cod_pedido";
            this.txt_cod_pedido.Size = new System.Drawing.Size(95, 20);
            this.txt_cod_pedido.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Tipo de Pagamento.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Quantidade.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Valor Líquido.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Desconto.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Código do Produto.:";
            // 
            // dgv_pedido
            // 
            this.dgv_pedido.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Quantidade});
            this.dgv_pedido.Location = new System.Drawing.Point(15, 63);
            this.dgv_pedido.Name = "dgv_pedido";
            this.dgv_pedido.Size = new System.Drawing.Size(587, 126);
            this.dgv_pedido.TabIndex = 75;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // btn_remover_pedido
            // 
            this.btn_remover_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover_pedido.Location = new System.Drawing.Point(436, 10);
            this.btn_remover_pedido.Name = "btn_remover_pedido";
            this.btn_remover_pedido.Size = new System.Drawing.Size(75, 23);
            this.btn_remover_pedido.TabIndex = 77;
            this.btn_remover_pedido.Text = "Remover";
            this.btn_remover_pedido.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar_pedido
            // 
            this.btn_adicionar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_pedido.Location = new System.Drawing.Point(355, 10);
            this.btn_adicionar_pedido.Name = "btn_adicionar_pedido";
            this.btn_adicionar_pedido.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar_pedido.TabIndex = 76;
            this.btn_adicionar_pedido.Text = "Adicionar";
            this.btn_adicionar_pedido.UseVisualStyleBackColor = true;
            this.btn_adicionar_pedido.Click += new System.EventHandler(this.btn_adicionar_pedido_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Data.:";
            // 
            // cb_forma_pagamento
            // 
            this.cb_forma_pagamento.FormattingEnabled = true;
            this.cb_forma_pagamento.Items.AddRange(new object[] {
            "",
            "Cartão de Crédito",
            "Dinheiro",
            "Cheque"});
            this.cb_forma_pagamento.Location = new System.Drawing.Point(117, 204);
            this.cb_forma_pagamento.Name = "cb_forma_pagamento";
            this.cb_forma_pagamento.Size = new System.Drawing.Size(228, 21);
            this.cb_forma_pagamento.TabIndex = 79;
            this.cb_forma_pagamento.SelectedIndexChanged += new System.EventHandler(this.cb_forma_pagamento_SelectedIndexChanged);
            // 
            // txt_valor_desconto
            // 
            this.txt_valor_desconto.Location = new System.Drawing.Point(370, 230);
            this.txt_valor_desconto.Mask = "$ 0000.00";
            this.txt_valor_desconto.Name = "txt_valor_desconto";
            this.txt_valor_desconto.Size = new System.Drawing.Size(66, 20);
            this.txt_valor_desconto.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Valor Desconto.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Valor Total.:";
            // 
            // txt_valor_total
            // 
            this.txt_valor_total.Location = new System.Drawing.Point(517, 230);
            this.txt_valor_total.Mask = "$ 0000,00";
            this.txt_valor_total.Name = "txt_valor_total";
            this.txt_valor_total.Size = new System.Drawing.Size(85, 20);
            this.txt_valor_total.TabIndex = 82;
            // 
            // txt_desconto
            // 
            this.txt_desconto.Location = new System.Drawing.Point(231, 230);
            this.txt_desconto.Mask = "000%";
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.Size = new System.Drawing.Size(41, 20);
            this.txt_desconto.TabIndex = 84;
            // 
            // cb_parcelas_pedido
            // 
            this.cb_parcelas_pedido.FormattingEnabled = true;
            this.cb_parcelas_pedido.Items.AddRange(new object[] {
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
            "12"});
            this.cb_parcelas_pedido.Location = new System.Drawing.Point(411, 204);
            this.cb_parcelas_pedido.Name = "cb_parcelas_pedido";
            this.cb_parcelas_pedido.Size = new System.Drawing.Size(42, 21);
            this.cb_parcelas_pedido.TabIndex = 85;
            this.cb_parcelas_pedido.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Parcelas.:";
            // 
            // txt_valor_parcela
            // 
            this.txt_valor_parcela.Location = new System.Drawing.Point(536, 204);
            this.txt_valor_parcela.Mask = "$ 0000.00";
            this.txt_valor_parcela.Name = "txt_valor_parcela";
            this.txt_valor_parcela.Size = new System.Drawing.Size(66, 20);
            this.txt_valor_parcela.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Valor Parcela.:";
            // 
            // frm_novo_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 287);
            this.Controls.Add(this.txt_valor_parcela);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_parcelas_pedido);
            this.Controls.Add(this.txt_desconto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_valor_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_valor_desconto);
            this.Controls.Add(this.cb_forma_pagamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_remover_pedido);
            this.Controls.Add(this.btn_adicionar_pedido);
            this.Controls.Add(this.dgv_pedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_quantidade_pedido);
            this.Controls.Add(this.txt_valor_liquido);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_data_pedido);
            this.Controls.Add(this.txt_cod_pedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_novo_pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Pedido";
            this.Load += new System.EventHandler(this.frm_novo_pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_quantidade_pedido;
        private System.Windows.Forms.MaskedTextBox txt_valor_liquido;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_data_pedido;
        private System.Windows.Forms.TextBox txt_cod_pedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button btn_remover_pedido;
        private System.Windows.Forms.Button btn_adicionar_pedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_forma_pagamento;
        private System.Windows.Forms.MaskedTextBox txt_valor_desconto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_valor_total;
        private System.Windows.Forms.MaskedTextBox txt_desconto;
        private System.Windows.Forms.ComboBox cb_parcelas_pedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_valor_parcela;
        private System.Windows.Forms.Label label7;

    }
}