using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Entidades;

namespace miUserControl
{

    public partial class Form1 : Form
    {
        private UserControls.miSuperGrilla miSuperGrilla1;

        //Perro[] arrayPerros = new Perro[10];

        Auto[] arrayAutos = new Auto[10];

        public Form1()
        {

            //Perro p1 = new Perro();
            //p1.Edad = 1;
            //p1.Nombre = "Toto";
            //p1.Raza = "Bulldog";

            //Perro p2 = new Perro();
            //p2.Edad = 1;
            //p2.Nombre = "Sultan";
            //p2.Raza = "Ovejero Aleman";

            //arrayPerros.SetValue(p1, 0);
            //arrayPerros.SetValue(p2, 1);

            Auto p1 = new Auto();
            p1.CantPuertas = 3;
            p1.Marca = "Fiat";
            p1.Modelo = "Punto";

            Auto p2 = new Auto();
            p2.CantPuertas = 5;
            p2.Marca = "Jeep";
            p2.Modelo = "Renagade";

            Auto p3 = new Auto();
            p3.CantPuertas = 5;
            p3.Marca = "Aston Martin";
            p3.Modelo = "ZZAA";

            arrayAutos.SetValue(p1, 0);
            arrayAutos.SetValue(p2, 1);
            arrayAutos.SetValue(p3, 2);



            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instancio miSuperGrilla
            this.miSuperGrilla1 = new UserControls.miSuperGrilla(arrayAutos);

          //configuro miSuperGrilla
            this.miSuperGrilla1.Location = new System.Drawing.Point(13, 13);
            this.miSuperGrilla1.Name = "miSuperGrilla1";
            this.miSuperGrilla1.Size = new System.Drawing.Size(595, 254);
            this.miSuperGrilla1.TabIndex = 1;
            //Asigno propiedades
            this.miSuperGrilla1.Titulo = "Mis Autos";
            this.miSuperGrilla1.Comparador = Auto.OrdenarPorMarca;
            //agrego el control al formulario
            this.Controls.Add(this.miSuperGrilla1);
        }
    }
}
