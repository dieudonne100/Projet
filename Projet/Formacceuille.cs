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
    public partial class Formacceuille : Form
    {
        public Formacceuille()
        {
            InitializeComponent();
            clientDesigrn();
        } 
        private void clientDesigrn()
        {
            panelArticle.Visible = false;
            PanelClient.Visible = false;
            panelcommande.Visible = false;
            panelFacture.Visible = false;

        }
        private void Sousnemu(){
            if (panelArticle.Visible == true) { 
                panelArticle.Visible = false;
                            }
            if (panelcommande.Visible == true)
            {
                panelcommande.Visible=false;
            }
            if (panelFacture.Visible == true)
            {
                panelFacture.Visible = false;
            }
            if (PanelClient.Visible == true)
            {
                PanelClient.Visible = false;
            }
        }
        private void voirSousnemu( Panel sousnemu)
        {
            if (sousnemu.Visible == false)
            {
                Sousnemu();
                sousnemu.Visible =true;
            }
            else
            {
                sousnemu.Visible = false;
            }
        }

       

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Sousnemu();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Sousnemu();

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Sousnemu();

        }

        private void btnArtilces_Click(object sender, EventArgs e)
        {
            voirSousnemu(panelArticle);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            voirSousnemu(PanelClient);
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            voirSousnemu(panelcommande);
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            voirSousnemu(panelFacture);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            FormConnexion frm = new FormConnexion();
            frm.Show();
        }
    }
}

