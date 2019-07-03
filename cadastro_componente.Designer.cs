namespace Projeto_Final_1._0
{
    partial class frm_cadastro_componente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_componente));
            this.btn_cadastro_materia_prima = new System.Windows.Forms.Button();
            this.btn_cadastro_maquina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cadastro_materia_prima
            // 
            this.btn_cadastro_materia_prima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastro_materia_prima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro_materia_prima.Location = new System.Drawing.Point(12, 34);
            this.btn_cadastro_materia_prima.Name = "btn_cadastro_materia_prima";
            this.btn_cadastro_materia_prima.Size = new System.Drawing.Size(133, 33);
            this.btn_cadastro_materia_prima.TabIndex = 0;
            this.btn_cadastro_materia_prima.Text = "Matéria-Prima";
            this.btn_cadastro_materia_prima.UseVisualStyleBackColor = true;
            this.btn_cadastro_materia_prima.Click += new System.EventHandler(this.btn_cadastro_materia_prima_Click);
            // 
            // btn_cadastro_maquina
            // 
            this.btn_cadastro_maquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastro_maquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro_maquina.Location = new System.Drawing.Point(163, 34);
            this.btn_cadastro_maquina.Name = "btn_cadastro_maquina";
            this.btn_cadastro_maquina.Size = new System.Drawing.Size(133, 33);
            this.btn_cadastro_maquina.TabIndex = 1;
            this.btn_cadastro_maquina.Text = "Máquina";
            this.btn_cadastro_maquina.UseVisualStyleBackColor = true;
            this.btn_cadastro_maquina.Click += new System.EventHandler(this.btn_cadastro_maquina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deseja cadastrar qual tipo de componente?";
            // 
            // frm_cadastro_componente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 77);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastro_maquina);
            this.Controls.Add(this.btn_cadastro_materia_prima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_cadastro_componente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Componente";
            this.Load += new System.EventHandler(this.frm_cadastro_componente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastro_materia_prima;
        private System.Windows.Forms.Button btn_cadastro_maquina;
        private System.Windows.Forms.Label label1;
    }
}