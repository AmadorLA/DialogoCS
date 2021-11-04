using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace DialogoCS
{
    public partial class Form1 : Form
    {
        Articulo[] a;
        int p = 0;
        public Form1()
        {
            InitializeComponent();
            a = new Articulo[5];

        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog btnAbrir = new OpenFileDialog();
            if (btnAbrir.ShowDialog() == DialogResult.OK) 
            {
                string direction = btnAbrir.FileName;

                Process proceso = new Process();
                proceso.StartInfo.FileName = direction;
                proceso.Start();
            }
            
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
          if  (dialogo.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo = new StreamWriter(dialogo.FileName)) 
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] != null)
                        {
                            archivo.WriteLineAsync(a[i].ToString());
                        }
                       
                    }
                }
            }
        }

            private void btnInsertar_Click(object sender, EventArgs e)
        {
            Articulo n = new Articulo();
            n.Nombre = txtNombre.Text;
            n.Precio = double.Parse( txtPrecio.Text);

            a[p] = n;
            lstArreglo.Items.Add(a[p]);

            p++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
