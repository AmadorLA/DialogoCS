using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogoCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK) ;
            {
                MessageBox.Show(dialogo.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
          if  (dialogo.ShowDialog() == DialogResult.OK);
            {
                MessageBox.Show(dialogo.FileName);
            }
        }
    }
}
