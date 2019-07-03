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
    public partial class frm_apresenta : Form
    {
        public frm_apresenta()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tm_inicio.Interval == 10000)
            {
                tm_inicio.Stop();
                this.Visible = false;
                new frm_login().ShowDialog();
            }
        }

        private void frm_apresenta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_apresenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Obrigado por testar nossa ferramenta. A Menucheli TI agradece!", "Versão de teste");
        }
    }
}
