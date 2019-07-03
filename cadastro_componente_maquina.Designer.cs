namespace Projeto_Final_1._0
{
    partial class frm_cadastro_componente_maquina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_componente_maquina));
            this.btn_cancelar_materia_prima = new System.Windows.Forms.Button();
            this.btn_salvar_materia_prima = new System.Windows.Forms.Button();
            this.txt_nome_fornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cod_fornecedor_maquina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome_maquina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_data_compra_maquina = new System.Windows.Forms.MaskedTextBox();
            this.txt_fim_garantia_maquina = new System.Windows.Forms.MaskedTextBox();
            this.txt_tempo_vida_maquina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancelar_materia_prima
            // 
            this.btn_cancelar_materia_prima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_materia_prima.Location = new System.Drawing.Point(528, 91);
            this.btn_cancelar_materia_prima.Name = "btn_cancelar_materia_prima";
            this.btn_cancelar_materia_prima.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar_materia_prima.TabIndex = 28;
            this.btn_cancelar_materia_prima.Text = "Cancelar";
            this.btn_cancelar_materia_prima.UseVisualStyleBackColor = true;
            this.btn_cancelar_materia_prima.Click += new System.EventHandler(this.btn_cancelar_materia_prima_Click);
            // 
            // btn_salvar_materia_prima
            // 
            this.btn_salvar_materia_prima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_materia_prima.Location = new System.Drawing.Point(447, 91);
            this.btn_salvar_materia_prima.Name = "btn_salvar_materia_prima";
            this.btn_salvar_materia_prima.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_materia_prima.TabIndex = 27;
            this.btn_salvar_materia_prima.Text = "Salvar";
            this.btn_salvar_materia_prima.UseVisualStyleBackColor = true;
            // 
            // txt_nome_fornecedor
            // 
            this.txt_nome_fornecedor.Location = new System.Drawing.Point(316, 33);
            this.txt_nome_fornecedor.Name = "txt_nome_fornecedor";
            this.txt_nome_fornecedor.Size = new System.Drawing.Size(287, 20);
            this.txt_nome_fornecedor.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nome Fornecedor.:";
            // 
            // txt_cod_fornecedor_maquina
            // 
            this.txt_cod_fornecedor_maquina.Location = new System.Drawing.Point(106, 33);
            this.txt_cod_fornecedor_maquina.Name = "txt_cod_fornecedor_maquina";
            this.txt_cod_fornecedor_maquina.Size = new System.Drawing.Size(100, 20);
            this.txt_cod_fornecedor_maquina.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cód Fornecedor.:";
            // 
            // txt_nome_maquina
            // 
            this.txt_nome_maquina.Location = new System.Drawing.Point(60, 7);
            this.txt_nome_maquina.Name = "txt_nome_maquina";
            this.txt_nome_maquina.Size = new System.Drawing.Size(543, 20);
            this.txt_nome_maquina.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tempo Vida.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fim Garantia.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Data de Compra.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome.:";
            // 
            // txt_data_compra_maquina
            // 
            this.txt_data_compra_maquina.Location = new System.Drawing.Point(106, 65);
            this.txt_data_compra_maquina.Mask = "00/00/0000";
            this.txt_data_compra_maquina.Name = "txt_data_compra_maquina";
            this.txt_data_compra_maquina.Size = new System.Drawing.Size(81, 20);
            this.txt_data_compra_maquina.TabIndex = 3;
            this.txt_data_compra_maquina.ValidatingType = typeof(System.DateTime);
            // 
            // txt_fim_garantia_maquina
            // 
            this.txt_fim_garantia_maquina.Location = new System.Drawing.Point(271, 65);
            this.txt_fim_garantia_maquina.Mask = "00/00/0000";
            this.txt_fim_garantia_maquina.Name = "txt_fim_garantia_maquina";
            this.txt_fim_garantia_maquina.Size = new System.Drawing.Size(81, 20);
            this.txt_fim_garantia_maquina.TabIndex = 4;
            this.txt_fim_garantia_maquina.ValidatingType = typeof(System.DateTime);
            // 
            // txt_tempo_vida_maquina
            // 
            this.txt_tempo_vida_maquina.Location = new System.Drawing.Point(434, 65);
            this.txt_tempo_vida_maquina.Name = "txt_tempo_vida_maquina";
            this.txt_tempo_vida_maquina.Size = new System.Drawing.Size(168, 20);
            this.txt_tempo_vida_maquina.TabIndex = 5;
            // 
            // frm_cadastro_componente_maquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 120);
            this.Controls.Add(this.txt_tempo_vida_maquina);
            this.Controls.Add(this.txt_fim_garantia_maquina);
            this.Controls.Add(this.txt_data_compra_maquina);
            this.Controls.Add(this.btn_cancelar_materia_prima);
            this.Controls.Add(this.btn_salvar_materia_prima);
            this.Controls.Add(this.txt_nome_fornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cod_fornecedor_maquina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nome_maquina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_componente_maquina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Máquina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar_materia_prima;
        private System.Windows.Forms.Button btn_salvar_materia_prima;
        private System.Windows.Forms.TextBox txt_nome_fornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cod_fornecedor_maquina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome_maquina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_data_compra_maquina;
        private System.Windows.Forms.MaskedTextBox txt_fim_garantia_maquina;
        private System.Windows.Forms.TextBox txt_tempo_vida_maquina;
    }
}