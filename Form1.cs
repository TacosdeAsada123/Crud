using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizengDisgment();
        }
        private void customizengDisgment()
        {
            panelMediosSub.Visible = false;
            panelPLay.Visible = false;
            panelGaming.Visible = false;
        }
        private void hideMenu()
        {
           if(panelMediosSub.Visible == true)
                panelMediosSub.Visible = false;
           if(panelPLay.Visible == true)
                panelPLay.Visible = false;
           if(panelGaming.Visible == true)
                panelGaming.Visible = false;
        }
        private void showsubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideMenu();
                submenu.Visible = true;

            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnMedios_Click(object sender, EventArgs e)
        {
            showsubMenu(panelMediosSub);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openForm(new FMediaList());

            hideMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            hideMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            hideMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            hideMenu();
        }


        private void PLaylistManagement_Click(object sender, EventArgs e)
        {
            showsubMenu(panelPLay);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openForm(new FPlaylist());
            hideMenu();
        }



        private void button8_Click(object sender, EventArgs e)
        {

            hideMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            hideMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            hideMenu();
        }


        private void btnGames_Click(object sender, EventArgs e)
        {

            openForm(new FGames());
            showsubMenu(panelGaming);
;       }

       
        private void button14_Click(object sender, EventArgs e)
        {
           
            hideMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            hideMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            hideMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
          
            hideMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private Form activateForm = null;
        private void openForm(Form phijo)
        {
            if(activateForm != null)
            
                activateForm.Close();
                activateForm = phijo;
                phijo.TopLevel = false;
                phijo.FormBorderStyle = FormBorderStyle.None;
                phijo.Dock = DockStyle.Fill;
                PanelHijo.Controls.Add(phijo);
                PanelHijo.Tag = phijo;
                phijo.BringToFront();
                phijo.Show();
            

        }

        private void PanelReproductor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
