using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analizador_Palindromo
{
    public partial class Form1 : Form
    {
        clsAnalizador AnalizadorText;
        public Form1()
        {
            InitializeComponent();
            AnalizadorText = new clsAnalizador();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            string oracion = txtOracion.Text;
            AnalizadorText.separadorCh(oracion);
            txtOracion.Clear();
            string resultado = AnalizadorText.comparadorCh();
            txtResultado.Text = resultado;
        }
    }
}
