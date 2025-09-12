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
    public partial class frmControles1 : Form
    {
        public frmControles1()
        {
            InitializeComponent();
        }
        string[] vecNombres = new string[3];
        int indice = 0;
        private void frmControles1_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "luka";
            vecNombres[1] = "josefina";
            vecNombres[2] = "pablo";

            lblResultado.Text = vecNombres[0];

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            if (vecNombres.Length > indice)
            {
                lblResultado.Text = vecNombres[indice];
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (vecNombres.Length > 0 && indice > 0 )
            {
                indice--;
                lblResultado.Text = vecNombres[indice];
            }
            else
            {
                btnAtras.Enabled = false;  
            }
            }
        }
    }

