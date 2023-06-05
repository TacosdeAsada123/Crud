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
    public partial class FGames : Form
    {
        public FGames()
        {
            InitializeComponent();
        }

        private void FGames_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mediaDataSet.Games' Puede moverla o quitarla según sea necesario.
            this.gamesTableAdapter.Fill(this.mediaDataSet.Games);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
