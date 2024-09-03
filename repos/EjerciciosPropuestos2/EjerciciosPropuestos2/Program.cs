using EjerciciosPropuestos2_Auro_Ben;

namespace EjerciciosPropuestos2
{

    /**
     Crear programa para facturas de donde obtendremos el total de cada factura.
Se podrán registrar facturas con los siguientes detalles:
NumeroFactura, Fecha, NombreProveedor, NombreProducto,
TotalUnidadesCompradas, TotalPrecioUnitario, % de IVA.
Crear método que calcula el total de la factura (le pasaremos unidades, precio e iva y calcula:
Total factura: unidadescompradas * precio unitario - (unidadescompradas * precio unitario * %iva).
Crear 2 facturas del año 2024.
Crear 2 facturas del año 2023.
Calcular el total gastado en cada año.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Producto producto1 = new Producto(1,"Patatas Fritas",1.40);
            Producto producto2 = new Producto(2, "Coca Cola", 1.20);
            Producto producto3 = new Producto(3, "Helado vainilla", 3.50);
            Producto producto4 = new Producto(4, "Pipas", 1.15);
            Producto producto5 = new Producto(5, "Bizcochos", 2.20);
            Producto producto6 = new Producto(6, "Cacahuetes", 2.10);

            Proveedor proveedor1 = new Proveedor(1,"SP Products");
            Proveedor proveedor2 = new Proveedor(2,"HF Supplies");
            Proveedor proveedor3 = new Proveedor(3, "NV Products");
            List<Producto> productos1 = new List<Producto>();
            List<Proveedor> proveedores1 = new List<Proveedor>();
            List<Producto> productos2 = new List<Producto>();
            List<Proveedor> proveedores2 = new List<Proveedor>();
            productos1.Add(producto1);
            productos1.Add(producto2);
            productos1.Add(producto3);
            proveedores1.Add(proveedor1);
            proveedores1.Add(proveedor2);
            proveedores1.Add(proveedor3);

            productos2.Add(producto4);
            productos2.Add(producto5);
            productos2.Add(producto6);
            proveedores2.Add(proveedor1);
            proveedores2.Add(proveedor2);
            proveedores2.Add(proveedor3);

            Factura factura1 = new Factura(1, "Compra 1",DateTime.Parse("2023-02-06"),productos1,proveedores1,0.1);
            Factura factura2 = new Factura(1, "Compra 2", DateTime.Parse("2024-02-06"), productos2, proveedores2, 0.1);

            Console.WriteLine(factura1.ToString());
            factura1.ToString2();
            Console.WriteLine("Total de la factura: "+ Math.Round(factura1.total_factura(), 2) + "$");

            Console.WriteLine(factura2.ToString());
            factura2.ToString2();
            Console.WriteLine("Total de la factura : " + Math.Round(factura2.total_factura(),2)+"$");

            Console.WriteLine("Total gastado entre 2023 y 2024: "+ Math.Round(factura1.total_factura()+ factura2.total_factura()),2);
        }
    }
}
