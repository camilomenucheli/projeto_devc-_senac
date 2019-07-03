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
    public partial class frm_cadastro_componente : Form
    {
        public frm_cadastro_componente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastro_materia_prima_Click(object sender, EventArgs e)
        {
            Close();
            new fmr_cadastro_componente_materia_prima().ShowDialog();
          
        }

        private void btn_cadastro_maquina_Click(object sender, EventArgs e)
        {
            Close();
            new frm_cadastro_componente_maquina().ShowDialog();
            
        }

        private void frm_cadastro_componente_Load(object sender, EventArgs e)
        {

        }
    }
}
