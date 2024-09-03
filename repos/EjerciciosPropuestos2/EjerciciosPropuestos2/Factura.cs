using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 NumeroFactura, Fecha, NombreProveedor, NombreProducto,
TotalUnidadesCompradas, TotalPrecioUnitario, % de IVA.
Crear método que calcula el total de la factura (le pasaremos unidades, precio e iva y calcula:
Total factura: unidadescompradas * precio unitario - (unidadescompradas * precio unitario * %iva)
 */

namespace EjerciciosPropuestos2_Auro_Ben
{
    internal class Factura
    {
        private int id_factura;
        private string nombre_factura;
        private DateTime fecha;
        private List<Producto> productos;
        private List<Proveedor> proveedores;
        private double iva;

        public int Id_Factura { 
        
            get { return id_factura; }  
            set { id_factura = value; }
        
        }

        public string Nombre_Factura
        {

            get { return nombre_factura; }
            set { nombre_factura = value; }

        }

        public DateTime Fecha
        {

            get { return fecha; }
            set { fecha = value; }

        }

        public double Iva
        {

            get { return iva; }
            set { iva = value; }

        }

        public List<Producto> Productos
        {

            get { return productos; }
            set { productos = value; }

        }

        public List<Proveedor> Proveedores
        {

            get { return proveedores; }
            set { proveedores = value; }

        }

        public Factura() {
        
        
        }

        public Factura(int id_factura, string nombre_factura, DateTime fecha, List<Producto> productos, List<Proveedor> proveedores, double iva)
        {
            this.id_factura = id_factura;
            this.nombre_factura = nombre_factura;
            this.fecha = fecha;
            this.productos = productos;
            this.proveedores = proveedores;
            this.iva = iva;
        }

        public double total_factura() {
            /**
             unidadescompradas * precio unitario - (unidadescompradas * precio unitario * %iva)
             */
            double total_precio = 0;
            int total_unidades = productos.Count;
            
            List<int> prod_precio = new List<int>();

            for(int x=0;x<productos.Count;x++) {

                total_precio += productos[x].Precio;
            
            }

            return (total_unidades * total_precio)-(total_unidades*total_precio*iva);
        }

        public string ToString() {


            return "Descripción factura: "+nombre_factura+ "\nFecha: "+DateOnly.FromDateTime(fecha);
        }

        public void ToString2()
        {
            Console.WriteLine("=================================================");
            foreach (Producto pro in Productos) {

                Console.WriteLine("Producto - "+pro.Nombre_Producto+"\nPrecio - "+pro.Precio);
            
            }
            Console.WriteLine("=================================================");
            foreach (Proveedor prov in Proveedores)
            {

                Console.WriteLine("Nombre prooveedor - " + prov.Nombre_Proveedor );

            }

        }

    }
}
