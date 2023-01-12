using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ajedrez.Core.Pieza;

namespace Ajedrez.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MovimientosCaballo(object sender, EventArgs e)
        {
            Caballo c = new Caballo();     

            MessageBox.Show(c.Mover());
        }
        private void MovimientosTorre(object sender, EventArgs e)
        {            
            Torre t = new Torre();            
            
            MessageBox.Show(t.Mover());            
        }
        private void MovimientosPeon(object sender, EventArgs e)
        {                        
            Peon p = new Peon();
            
            MessageBox.Show(p.Mover());
        }
    }
}
