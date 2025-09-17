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
        public string[] vecNombres = new string[3];
        int indice = 0;
        private void frmControles1_Load(object sender, EventArgs e)
        {
            //vecNombres[0] = "luka";
            vecNombres[1] = "josefina";
            vecNombres[2] = "pablo";

            lblResultado.Text = vecNombres[0];

            int indiceCombo = 0;

            while (indiceCombo<vecNombres.Length)
            {
                txtNombresR.Items.Add(vecNombres[indiceCombo++]);
            }

        }
        //
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            if (vecNombres.Length > indice)
            {
                lblResultado.Text = vecNombres[indice];
                btnAtras.Enabled = true;
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
                if (indice==0) 
            {
                btnAtras.Enabled = false;  
            }
                if (indice < vecNombres.Length)
                {
                    btnSiguiente.Enabled = true;
                }
            }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lblResultado.Text = vecNombres[vecNombres.Length - 1];
            indice = 2;
            btnAtras.Enabled = true;
            btnSiguiente.Enabled = false;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            lblResultado.Text = vecNombres[0];
            indice = 0;
            btnSiguiente.Enabled = true;
            btnAtras.Enabled = false;
        }
    }
    }

