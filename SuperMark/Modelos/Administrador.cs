namespace SuperMark.Modelos
{
    public class Administrador
    {
        public string Nombre { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public string Documento { get; private set; }

        public Administrador(string nombre, DateTime fechaNacimiento, string documento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Documento = documento;
        }
    }
}
