using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFesta
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
           
            string nome = txbNome.Text; 
            //obter idade do txb 
            int year = (int)txbAno.Value;
            int idd;
            //verificar idade 
            idd = (DateTime.Now.Year - year);
            if (idd >= 18)
            {
                lblapv.Text = "**Saudações!**";
                pibIcone.Image = Properties.Resources.ok;
                lblcpt.Text = txbNome.Text +" "+ txbSobrenome.Text; 
                lblmidd.Text = idd.ToString();  

            } 
            else
            {
                lblapv.Text = "xxNegado!xx";
                pibIcone.Image = Properties.Resources.erro;
            }
        }

        private void txbIdade_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pibIcone.Image = Properties.Resources.lapis_e_regua_cruzados;
            lblcpt.Text = "";
            lblapv.Text = "";
            lblmidd.Text = "";
        }   

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void lblSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close(); 
        }

        private void lblSobrenome_Click(object sender, EventArgs e)
        {

        }

        
    }
}
