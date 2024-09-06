namespace SuperMark.Modelos
{
    public class Alimento : Producto
    {
        public string TipoDeAlimento { get; private set; }
        public int PesoEnGramos { get; private set; }
        
        public Alimento(int codigo, string nombre, double costo, string tipoDeAlimento, int pesoEnGramos): base(codigo, nombre, costo)
        {
            TipoDeAlimento = tipoDeAlimento;
            PesoEnGramos = pesoEnGramos;
        }
        
        public void MostrarDetalles()
        {
            MostrarDetalleProducto();
            Console.WriteLine($"Tipo de alimento: {TipoDeAlimento}, peso en gramos: {PesoEnGramos}");
        }
    }
}