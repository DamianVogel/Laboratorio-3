﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _dni;
        private string _fotoAlumno;
        private string _nombre;


        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._fotoAlumno = ruta;
      
        }
        
        
        
        public string Apellido { get { return this._apellido; } set { this._apellido = value; } }
         

        public int Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

     

        public string FotoAlumno
        {
            get { return this._fotoAlumno; }
            set { this._fotoAlumno = value; }
        }

         
        public string Nombre
        {
            get { return this._nombre; }
            set {  this._nombre= value; }
        }
        

    
    }
}
