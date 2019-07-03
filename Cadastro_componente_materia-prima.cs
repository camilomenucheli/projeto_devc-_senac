using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_1._0
{
    public partial class fmr_cadastro_componente_materia_prima : Form
    {
        public fmr_cadastro_componente_materia_prima()
        {
            InitializeComponent();
        }

        private void Cadastro_componente_materia_prima_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_materia_prima_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar o cadastro?", "Cancelar Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
