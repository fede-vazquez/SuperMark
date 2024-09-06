using SuperMark.Modelos;

class Program
{
    static void Main()
    {
        Administrador admin1 = new Administrador("Juan Perez", DateTime.Now, "45.345.678");
        Administrador admin2 = new Administrador("Pepito Fuentes", DateTime.Now, "53.345.678");

        Alimento jorgitos = new Alimento(1, "Jorgitos", 2000, "Masitas", 120);
        Alimento panDulce = new Alimento(2, "Pan dulce", 3500, "Pan", 250);

        DispositivoElectronico celular = new DispositivoElectronico(3, "Sambung galaxy", 500000, "Celular", true);

        Ropa pantalon = new Ropa(4, "Jean", 12000, "Invierno", "Pantalon", 52);


        Tienda superMark = new Tienda("Super mark", admin1, jorgitos);
        superMark.AgregarProducto(panDulce);
        superMark.AgregarProducto(celular);
        superMark.AgregarProducto(pantalon);
    }
}