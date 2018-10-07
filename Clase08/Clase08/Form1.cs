using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operacion;//ESto es un name space, que referencia a otra clase

namespace Clase08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ////Instanciamos el objeto para ver que podemos instanciar desde otra clase
            //Calculo triangulo = new Calculo();
            //triangulo.CalcularArea();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Objeto
            Calculo triangulo = new Calculo();
            //
            triangulo.Base = Convert.ToDouble(textBox1.Text);
            triangulo.Altura = double.Parse(textBox2.Text);

            //MessageBox.Show("Base: " + triangulo.Base +" Altura: " + triangulo.Altura);

            if (radioButton1.Checked)
            {
                var perimetro = triangulo.CalcularPerimetro(triangulo.Base, triangulo.Altura);
                lblResultado.Text = "Resultado: " + Math.Round(perimetro, 3);
            }

            else if (radioButton2.Checked)
            {   //Vamos a obtener area, con el metodo calcular area, y asignamos los parametros
                var area = triangulo.CalcularArea(triangulo.Base, triangulo.Altura);
                lblResultado.Text = "Resultado: " + area;
            }
            else if (radioButton3.Checked)
            {
                var hipotenusa = triangulo.CalcularHipotenusa(triangulo.Base, triangulo.Altura);
                lblResultado.Text = "Resultado: " + Math.Round(hipotenusa, 3);
            }

        }
    }

}
