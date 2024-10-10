﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaWForms
{
    public partial class MainForm : Form
    {
        int prevYears = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCerrar_MouseHover(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clnfechaNac_DateChanged(object sender, DateRangeEventArgs e)
        {
            nudEdad.Value = clnfechaNac.SelectionStart.Year;
            prevYears=(int)nudEdad.Value;
        }

        private void nudEdad_ValueChanged(object sender, EventArgs e)
        {
            clnfechaNac.SelectionStart = clnfechaNac.SelectionStart.AddYears(prevYears-(int)nudEdad.Value);
        }
    }
}
