namespace Projeto_Final_1._0
{
    partial class frm_solicita_manutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_solicita_manutencao));
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cancelar_solicita = new System.Windows.Forms.Button();
            this.btn_solicitar_manutencao = new System.Windows.Forms.Button();
            this.txt_data_solicita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cod_maquina = new System.Windows.Forms.TextBox();
            this.txt_cnpj_fornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "Data.:";
            // 
            // btn_cancelar_solicita
            // 
            this.btn_cancelar_solicita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_solicita.Location = new System.Drawing.Point(415, 171);
            this.btn_cancelar_solicita.Name = "btn_cancelar_solicita";
            this.btn_cancelar_solicita.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_solicita.TabIndex = 6;
            this.btn_cancelar_solicita.Text = "Cancelar";
            this.btn_cancelar_solicita.UseVisualStyleBackColor = true;
            this.btn_cancelar_solicita.Click += new System.EventHandler(this.btn_cancelar_solicita_Click);
            // 
            // btn_solicitar_manutencao
            // 
            this.btn_solicitar_manutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_solicitar_manutencao.Location = new System.Drawing.Point(287, 171);
            this.btn_solicitar_manutencao.Name = "btn_solicitar_manutencao";
            this.btn_solicitar_manutencao.Size = new System.Drawing.Size(122, 23);
            this.btn_solicitar_manutencao.TabIndex = 5;
            this.btn_solicitar_manutencao.Text = "Solicitar Manutenção";
            this.btn_solicitar_manutencao.UseVisualStyleBackColor = true;
            // 
            // txt_data_solicita
            // 
            this.txt_data_solicita.Location = new System.Drawing.Point(54, 173);
            this.txt_data_solicita.Name = "txt_data_solicita";
            this.txt_data_solicita.Size = new System.Drawing.Size(202, 20);
            this.txt_data_solicita.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Código da Máquina.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "CNPJ Empresa Responsável.:";
            // 
            // txt_cod_maquina
            // 
            this.txt_cod_maquina.Location = new System.Drawing.Point(395, 6);
            this.txt_cod_maquina.Name = "txt_cod_maquina";
            this.txt_cod_maquina.Size = new System.Drawing.Size(95, 20);
            this.txt_cod_maquina.TabIndex = 2;
            // 
            // txt_cnpj_fornecedor
            // 
            this.txt_cnpj_fornecedor.Location = new System.Drawing.Point(167, 6);
            this.txt_cnpj_fornecedor.Mask = "##.###.###/####-##";
            this.txt_cnpj_fornecedor.Name = "txt_cnpj_fornecedor";
            this.txt_cnpj_fornecedor.Size = new System.Drawing.Size(111, 20);
            this.txt_cnpj_fornecedor.TabIndex = 1;
            this.txt_cnpj_fornecedor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_cnpj_fornecedor_MaskInputRejected);
            this.txt_cnpj_fornecedor.Leave += new System.EventHandler(this.txt_cnpj_fornecedor_Leave);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(15, 52);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(475, 113);
            this.txt_descricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Descrição.:";
            // 
            // frm_solicita_manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_cnpj_fornecedor);
            this.Controls.Add(this.txt_cod_maquina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_cancelar_solicita);
            this.Controls.Add(this.btn_solicitar_manutencao);
            this.Controls.Add(this.txt_data_solicita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_solicita_manutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicita Manutenção";
            this.Load += new System.EventHandler(this.Solicita_manutencao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cancelar_solicita;
        private System.Windows.Forms.Button btn_solicitar_manutencao;
        private System.Windows.Forms.TextBox txt_data_solicita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod_maquina;
        private System.Windows.Forms.MaskedTextBox txt_cnpj_fornecedor;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label2;
    }
}