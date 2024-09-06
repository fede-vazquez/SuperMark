namespace SuperMark.Modelos
{
    public class Tienda
    {
        public string Nombre { get; private set; }
        public List<Administrador> Administradores { get; private set; } = new List<Administrador>();
        public List<Producto> Productos { get; private set; } = new List<Producto>();

        public Tienda(string nombre, Administrador administrador, Producto producto)
        {
            Nombre = nombre;
            Administradores.Add(administrador);
            Productos.Add(producto);
        }
        public Tienda(string nombre, List<Administrador> administradores, List<Producto> productos)
        {
            Nombre = nombre;
            Administradores.AddRange(administradores);
            Productos.AddRange(productos);
        }

        public void AgregarAdministrador(Administrador administrador) => Administradores.Add(administrador);
        public void AgregarProducto(Producto producto) => Productos.Add(producto);
        public void AgregarProducto(List<Producto> producto) => Productos.AddRange(producto);

        public void EliminarProducto(Producto producto) => Productos.Remove(producto);
    }
}
