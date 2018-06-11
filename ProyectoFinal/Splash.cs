using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{

    
    public partial class Splash : Form
    {

        int c = 0;




        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

            




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;

            if (c<15)
            {

                timer1.Stop();
                fm_menu frm = new fm_menu();

                frm.Show(this);
                this.Hide();

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
