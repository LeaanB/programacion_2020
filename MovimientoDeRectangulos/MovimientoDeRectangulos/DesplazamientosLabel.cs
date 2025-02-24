﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimientoDeRectangulos
{
    public partial class FrmDesplazamiento : Form
    {
        public FrmDesplazamiento()
        {
            InitializeComponent();
        }

        private void BtnBlanco_Click(object sender, EventArgs e)
        {
            int AnchoFormulario = 0;
            AnchoFormulario = this.Width;
            int AnchoLabel = LblBlanco.Width;
            int AnchoBorde = 330;
            int X = 0;
            int Paso = 2;

            while (X < AnchoFormulario - AnchoLabel - AnchoBorde)
            {
                this.LblBlanco.Left = X;
                this.Refresh();
                X = X + Paso;
            }
        }

        private void BtnNegro_Click(object sender, EventArgs e)
        {
            int AnchoFor = 30;
            AnchoFor = this.Width;
            int AnchoLab = LblNegro.Width;
            int AnchoBor = 490;
            int X = 0;
            int Paso = 2;
            

            while (X < AnchoFor - AnchoLab - AnchoBor)
            {
                this.LblNegro.Top = X;
                this.Refresh();
                X = X + Paso;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BtnTxt_Click(object sender, EventArgs e)
        {
            this.LblText.Text = "Se ha formado una T";
        }

    }
    
}
