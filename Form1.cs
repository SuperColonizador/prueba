using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Boton1 frm = new Frm_Boton1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBoton2 frm = new FrmBoton2();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FrmBoton3 frm = new FrmBoton3();
            //frm.Show();
           // PRUEBA COMENTARIO
        }
    }
}
