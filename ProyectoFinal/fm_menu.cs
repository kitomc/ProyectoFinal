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



        


        void calculoCantidadPersona()
        {

            int x, c, d;
            int p;

            x = Convert.ToInt16(tb_CantidadP.Text);

            c = x * Convert.ToInt16(lb_cant1.Text);
            d = x * Convert.ToInt16(lb_cant2.Text);
            p = x * Convert.ToInt16(lb_cant3.Text);
            lb_cant1.Text = Convert.ToString(c);
            lb_cant2.Text = Convert.ToString(d);
            lb_cant3.Text = Convert.ToString(p);

        }


        void calculoCantidadPersona2()
        {

            int x, c, d;
            int p;

            x = Convert.ToInt16(tb_CantidadP.Text);

            c = x * Convert.ToInt16(lb_cant1.Text);
            
            lb_cant1.Text = Convert.ToString(c);
            
        }





        void Arroz()
        {
            label1 .Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            lb_um2.Visible = true ;
            lb_cant2.Visible = true;
            lb_ing2.Visible = true;


            lb_um3.Visible = true;
            lb_cant3.Visible = true;
            lb_ing3.Visible = true;

            lb_um1.Visible=true;
            lb_cant1.Visible = true;
            lb_ing1.Visible = true;


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


            lb_um1.Visible = true;
            lb_cant1.Visible = true;
            lb_ing1.Visible = true;


            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            

            

           

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
            calculoCantidadPersona2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arroz();
            calculoCantidadPersona();


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

        private void tb_CantidadP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==127)
            {
                tb_CantidadP.Clear();
            }


            button1.Visible = true;
            button2.Visible = true;
        }

        private void tb_CantidadP_TextChanged(object sender, EventArgs e)
        {
           

            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
