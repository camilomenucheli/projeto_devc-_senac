namespace Projeto_Final_1._0
{
    partial class frm_cadastro_dependentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_dependentes));
            this.btn_novo_dependente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cod_funcionario_dependente = new System.Windows.Forms.TextBox();
            this.txt_idade_dependente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_grau_familiaridade_dependente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome_dependente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar_dependente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_novo_dependente
            // 
            this.btn_novo_dependente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_dependente.Location = new System.Drawing.Point(12, 12);
            this.btn_novo_dependente.Name = "btn_novo_dependente";
            this.btn_novo_dependente.Size = new System.Drawing.Size(75, 23);
            this.btn_novo_dependente.TabIndex = 0;
            this.btn_novo_dependente.Text = "Novo";
            this.btn_novo_dependente.UseVisualStyleBackColor = true;
            this.btn_novo_dependente.Click += new System.EventHandler(this.btn_novo_dependente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cód Funcionário.:";
            // 
            // txt_cod_funcionario_dependente
            // 
            this.txt_cod_funcionario_dependente.Location = new System.Drawing.Point(189, 14);
            this.txt_cod_funcionario_dependente.Name = "txt_cod_funcionario_dependente";
            this.txt_cod_funcionario_dependente.Size = new System.Drawing.Size(89, 20);
            this.txt_cod_funcionario_dependente.TabIndex = 1;
            // 
            // txt_idade_dependente
            // 
            this.txt_idade_dependente.Location = new System.Drawing.Point(58, 66);
            this.txt_idade_dependente.Name = "txt_idade_dependente";
            this.txt_idade_dependente.Size = new System.Drawing.Size(78, 20);
            this.txt_idade_dependente.TabIndex = 3;
            this.txt_idade_dependente.TextChanged += new System.EventHandler(this.txt_idade_dependente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idade.:";
            // 
            // txt_grau_familiaridade_dependente
            // 
            this.txt_grau_familiaridade_dependente.Location = new System.Drawing.Point(250, 66);
            this.txt_grau_familiaridade_dependente.Name = "txt_grau_familiaridade_dependente";
            this.txt_grau_familiaridade_dependente.Size = new System.Drawing.Size(352, 20);
            this.txt_grau_familiaridade_dependente.TabIndex = 4;
            this.txt_grau_familiaridade_dependente.TextChanged += new System.EventHandler(this.txt_grau_familiaridade_dependente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grau Familíaridade.:";
            // 
            // txt_nome_dependente
            // 
            this.txt_nome_dependente.Location = new System.Drawing.Point(121, 40);
            this.txt_nome_dependente.Name = "txt_nome_dependente";
            this.txt_nome_dependente.Size = new System.Drawing.Size(481, 20);
            this.txt_nome_dependente.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome Dependente.:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(527, 92);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar_dependente
            // 
            this.btn_salvar_dependente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_dependente.Location = new System.Drawing.Point(446, 92);
            this.btn_salvar_dependente.Name = "btn_salvar_dependente";
            this.btn_salvar_dependente.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar_dependente.TabIndex = 5;
            this.btn_salvar_dependente.Text = "Salvar";
            this.btn_salvar_dependente.UseVisualStyleBackColor = true;
            // 
            // frm_cadastro_dependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 124);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar_dependente);
            this.Controls.Add(this.txt_nome_dependente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_grau_familiaridade_dependente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idade_dependente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cod_funcionario_dependente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_novo_dependente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_dependentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Dependentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novo_dependente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cod_funcionario_dependente;
        private System.Windows.Forms.TextBox txt_idade_dependente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_grau_familiaridade_dependente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome_dependente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar_dependente;
    }
}