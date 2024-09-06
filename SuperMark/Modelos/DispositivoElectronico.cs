namespace SuperMark.Modelos
{
    public class DispositivoElectronico: Producto
    {
        public string TipoDeDispositivo { get; private set; }
        public bool TieneBluetooth { get; private set; }

        public DispositivoElectronico(int codigo, string nombre, double costo, string tipoDeDispositivo, bool tieneBluetooth): base(codigo, nombre, costo)
        {
            TipoDeDispositivo = tipoDeDispositivo;
            TieneBluetooth = tieneBluetooth;
        }

        public void MostrarDetalle()
        {
            MostrarDetalleProducto();
            Console.WriteLine($"Tipo de dispositivo: {TipoDeDispositivo}, tiene bluetooth: {(TieneBluetooth ? "si": "no")}");
        }
    }
}
