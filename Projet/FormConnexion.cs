using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Formacceuille frm = new Formacceuille();
            frm.Show();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
