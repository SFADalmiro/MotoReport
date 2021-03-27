using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Motoreport
{
    public partial class List_TRP : Form
    {
        private ConnectDB SqlKernel;
        FormInf frmInf;
        public List_TRP()
        {
            SqlKernel = new ConnectDB();
            if (SqlKernel.InitializeDB())
            {
                MessageBox.Show("Todo Ok");
            }
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir de la aplicación?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void newInfo_Click(object sender, EventArgs e)
        {
            frmInf = new FormInf();
            frmInf.Show();
        }
    }
}
