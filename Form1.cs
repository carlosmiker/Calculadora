using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);
            switch(operacion)
                {
                case "+":
                    resultado=primero+segundo;
                    pantalla.Text=resultado.ToString();
                    
                    break;
                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();

                    break;
                case "x":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();

                    break;
                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();

                    break;
                
                    }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + "0";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
          
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + "9";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + "4";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            
            pantalla.Text = pantalla.Text + ".";
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            
            operacion = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            
            operacion = "x";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            
            operacion = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

       
        private void bntlimpiar_Click(object sender, EventArgs e)
        {
       
            pantalla.Clear();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
           
            if (pantalla.TextLength > 0)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.TextLength - 1, 1);
            }
            if (pantalla.Text.Length == 0)
            {
                pantalla.Text = "";
                
                //inicio = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
