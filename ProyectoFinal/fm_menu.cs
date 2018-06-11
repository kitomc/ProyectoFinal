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
    public partial class fm_menu : Form
    {
        public fm_menu()
        {
            InitializeComponent();
        }

        void Arroz()
        {
            lb_um2.Visible = true ;
            lb_cant2.Visible = true;
            lb_ing2.Visible = true;


            lb_um3.Visible = true;
            lb_cant3.Visible = true;
            lb_ing3.Visible = true;


            lb_um1.Text = "Libras";
            lb_cant1.Text = "2";
            lb_ing1.Text = "Carne de Res";

            lb_um2.Text = "Tasas";
            lb_cant2.Text = "2";
            lb_ing2.Text = "Habichuelas";


            lb_um3.Text = "Tazas";
            lb_cant3.Text = "4";
            lb_ing3.Text = "Arroz";


           

        }




 




        void Cazabe()
        {
            lb_um1.Text = "Unidad";
            lb_cant1.Text = "1";
            lb_ing1.Text = "Yuca";

            lb_um2.Visible=false;
            lb_cant2.Visible = false;
            lb_ing2.Visible = false;


            lb_um3.Visible = false;
            lb_cant3.Visible = false;
            lb_ing3.Visible = false;




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cazabe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arroz();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void lb_cant2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
