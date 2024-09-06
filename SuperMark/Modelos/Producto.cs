namespace SuperMark.Modelos
{
    public class Producto
    {
        public int Codigo {  get; private set; }
        public string Nombre { get; private set; }
        public double Precio { get; private set; }

        public Producto(int codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }

        public void ModificarPrecioProducto(double nuevoPrecio) => Precio = nuevoPrecio;
        public void ModificarNombreProducto(string nuevoNombre) => Nombre = nuevoNombre; 

        public void MostrarDetalleProducto()
        {
            Console.WriteLine($"Codigo: {Codigo}, Nombre: {Nombre}, Costo{Costo}");
        }
    }
}