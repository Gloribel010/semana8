// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Almacen.Models;

using (AlmacenContext db = new AlmacenContext())
{
    Producto producto = new Producto();

    Console.WriteLine("Ingresar nombre del producto");
    producto.Nombre = Console.ReadLine();

    Console.WriteLine("Ingresar la descripcion");
    producto.Descripcion = Console.ReadLine();

    Console.WriteLine("Ingresar el precio");
    producto.Precio = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Ingresar la cantidad de producto");
    producto.Stock = Convert.ToInt32(Console.ReadLine());

    db.Productos.Add(producto);
    db.SaveChanges();


}
