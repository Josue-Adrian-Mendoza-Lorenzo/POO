using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {   //Inicia el cursor en el primer texbox
            txtInicial.Select();
        }
        //Boton Convertidor
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Condicion cuando eliga Temperatura
            if (cbElegir.Text == "Temperatura")
            {//Tarea terminar los otros, reutilizar la descripcion y el tipo, nota usted esta convirtiendo. este 
                //Inicializamos el objeto temp
                Temperatura temp = new Temperatura();
                temp.Tipo = "Este conversor solo convierte de Celcius a Farenheit";
                temp.Grados = double.Parse( txtInicial.Text);
                temp.Descripcion = decimal.Parse(txtInicial.Text);
                //El lblDescripcion.Text almacena el valor del metodo definir operacion de la clase padre Conversor
                lblDescripcion.Text = temp.DefinirOperacion();
                //Musetra resultados en label
                lblResultado.Text = "Resultado: " + Convert.ToString(temp.DefinirConversion());
                //Muestra en otra nota el tipo de conversion
                lblDecripcion2.Text = temp.Tipo;
                //Para no poner valores en la otra casilla, posteriormente de presionar
                txtSecundario.Enabled = false;
                //Limpiar textbox
                txtSecundario.Clear();
            }

            else if (cbElegir.Text == "Medidas")
            {   //convertir Metros a centimetros, nota solo se convierte a , descripcion
                //Instanciacion
                Medida med = new Medida();
                //Asignar valores y captura
                med.Tipo = "Este conversor solo convierte de m a cm";
                med.Cantidad = double.Parse(txtInicial.Text);
                med.Descripcion = decimal.Parse(txtInicial.Text);
                //El lblDescripcion.Text almacena el valor del metodo definir operacion de la clase padre Conversor
                lblDescripcion.Text = med.DefinirOperacion();
                //Muestra resultados en lbl
                lblResultado.Text = "Resultado: " + Convert.ToString(med.DefinirConversion());
                //Para no poner valores en la otra casilla, posteriormente de presionar
                txtSecundario.Enabled = false;
                //Muestra en otra nota el tipo de conversion
                lblDecripcion2.Text = med.Tipo;
                //Limpia textbox
                txtSecundario.Clear();
            }
            else if (cbElegir.Text == "Divisas")
            {   //pesos a dolares,  divisas utilizaremos lblSecundario, el resultado se mostrara en lblSecundario = tipo de cambio
                //Instanciacion
                Moneda mon = new Moneda();
                //Asignar valores y captura
                mon.Tipo = "Este conversor solo convierte de Pesos Mexicanos a Dolar Estadounidense";
                mon.Cantidad = double.Parse(txtInicial.Text);
                mon.Descripcion = decimal.Parse(txtInicial.Text);
                //El lblDescripcion.Text almacena el valor del metodo definir operacion de la clase padre Conversor
                lblDescripcion.Text = mon.DefinirOperacion();
                //limpia label
                lblResultado.Text = "";
                //Muestra resultados en lbl
                txtSecundario.Text = "Resultado: " + Convert.ToString((mon.DefinirConversion()));
                //Muestra en otra nota el tipo de conversion
                lblDecripcion2.Text = mon.Tipo;
                //Activa lblSecundario
                txtSecundario.Enabled = true;
            }
            else
            {
                //Muestra mensaje en caso de no elegir una opcion
                MessageBox.Show("Seleccione un elemento a convertir.");
            }
        }

       
    }
}
