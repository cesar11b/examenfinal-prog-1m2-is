using Examen_final_1m2_is_yader_jose__cesar_vivas_.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final_1m2_is_yader_jose__cesar_vivas_
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarEst_Click(object sender, EventArgs e)
        {

            Agregar Cambio = new Agregar();
            Cambio.ShowDialog();

        }
    }
}
