using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patientenverwaltung
{
    public partial class New_patient : Form
    {
        public New_patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_persoenliches.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel_persoenliches_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
