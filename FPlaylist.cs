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
    public partial class FPlaylist : Form
    {
        public FPlaylist()
        {
            InitializeComponent();
        }

        private void FPlaylist_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mediaDataSet.Playlist' Puede moverla o quitarla según sea necesario.
            this.playlistTableAdapter.Fill(this.mediaDataSet.Playlist);
            // TODO: esta línea de código carga datos en la tabla 'mediaDataSet.Medios' Puede moverla o quitarla según sea necesario.
            this.mediosTableAdapter.Fill(this.mediaDataSet.Medios);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
