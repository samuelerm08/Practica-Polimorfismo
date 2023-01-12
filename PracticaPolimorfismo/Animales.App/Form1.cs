using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animales.Core.Animales;

namespace Animales.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VerConejo(object sender, EventArgs e)
        {
            Conejo c = new Conejo("2 años", "1kg", "15cm", 10);

            MessageBox.Show($"{c.ImprimirPropiedades()}\n{Environment.NewLine}" +
                            $"{c.ImprimirComida()}");           
        }

        private void VerLoro(object sender, EventArgs e)
        {
            Loro l = new Loro("100 años", "300kg", "5m", 30);
            MessageBox.Show($"{l.ImprimirPropiedades()}\n{Environment.NewLine}" +
                            $"{l.ImprimirComida()}");            
        }

        private void VerLeon(object sender, EventArgs e)
        {
            Leon leon = new Leon("50 años", "200kg", "15m", 38);
            MessageBox.Show($"{leon.ImprimirPropiedades()}\n{Environment.NewLine}" +
                            $"{leon.ImprimirComida()}");            
        }
    }
}
