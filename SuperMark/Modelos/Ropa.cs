namespace SuperMark.Modelos
{
    public class Ropa : Producto
    {
        public string Temporada { get; private set; }
        public string TipoPrenda { get; private set; }
        public int Talle { get; private set; }

        public Ropa(int codigo, string nombre, double costo, string temporada, string tipoPrenda, int talle) : base(codigo, nombre, costo)
        {
            Temporada = temporada;
            TipoPrenda = tipoPrenda;
            Talle = talle;
        }

        public void MostrarDetalle()
        {
            MostrarDetalleProducto();
            Console.WriteLine($"Temporada: {Temporada}, tipo de prenda: {TipoPrenda}, talle: {Talle}");
        }
    }
}
