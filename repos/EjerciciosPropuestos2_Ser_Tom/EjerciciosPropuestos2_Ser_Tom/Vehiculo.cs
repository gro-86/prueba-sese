using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPropuestos2_Ser_Tom
{

    //matricula, tipo, modelo, marca
    internal class Vehiculo
    {
        private string matricula;
        private string tipo;
        private string modelo;
        private string marca;

        public string Matricula
        {

            get { return matricula; }
            set { matricula = value; }

        }

        public string Tipo
        {

            get { return tipo; }
            set { tipo = value; }

        }

        public string Modelo
        {

            get { return modelo; }
            set { modelo = value; }

        }

        public string Marca
        {

            get { return marca; }
            set { marca = value; }

        }

        public Vehiculo() { 
        
        
        }

        public Vehiculo(string matricula, string tipo, string modelo, string marca) { 
        
            this.matricula = matricula;
            this.tipo = tipo;
            this.modelo = modelo;
            this.marca = marca;
        
        }

        public string ToString()
        {


            return 
                "\nMatricula - "+matricula+
                "\nTipo - "+tipo+
                "\nModelo - "+modelo+
                "\nMarca - "+marca;
        }

    }
}
