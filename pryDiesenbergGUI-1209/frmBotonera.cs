using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenbergGUI_1209
{
    public partial class frmBotonera : Form
    {
        public frmBotonera()
        {
            InitializeComponent();
        }

        private void btnBotonera_click(object sender, EventArgs e)
        {

            
        }
       
        private void btnBotonera_Click_1(object sender, EventArgs e)
        {
            frmControles1 ventanaBotonera = new frmControles1();

            ventanaBotonera.vecNombres[0] = "soy hacker";

            ventanaBotonera.Show();

            int indiceVectorNombres = 0;
            while (indiceVectorNombres<ventanaBotonera.vecNombres.Length)
            {
                lstNombres.Items.Add(ventanaBotonera.vecNombres[indiceVectorNombres++]);
            }

        }
    }
    }

