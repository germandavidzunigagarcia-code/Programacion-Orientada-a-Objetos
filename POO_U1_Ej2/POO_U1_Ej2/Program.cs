using POO_U1_Ej2.Enum;
namespace POO_U1_Ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("German David Zuniga Garcia");
            Console.WriteLine("20242001475");
            try
            {
                //Con parametros
                Vehiculo car1 = new Vehiculo("Toyota", "Corola", "Rojo", "0501FD", 2021, Estado.Detenido);
                car1.Tipo = TipoVehiculo.Turismo;
                Console.WriteLine("--------Informacion del carro---------");
                Console.WriteLine($"Marca {car1.Marca}");
                Console.WriteLine($"Modelo: {car1.Modelo}");
                Console.WriteLine($"Color {car1.Color}");
                Console.WriteLine($"Placa {car1.Placa}");
                Console.WriteLine($"Anio: {car1.Anio}");
                Console.WriteLine($"Tipo: {car1.Tipo}");
                Console.WriteLine($"Estado: {car1.Estado}");

                car1.Acelerar();
                Console.WriteLine(car1.Estado);
                car1.Frenar();
                Console.WriteLine(car1.Estado);

                //Sin parametros
                Console.WriteLine("----Informacion del automovil----");
                Console.WriteLine($"Marca: {car1.Marca = "Nissan"}");
                Console.WriteLine($"Modelo: {car1.Modelo = "Frontier"}");
                Console.WriteLine($"Color: {car1.Color = "Negro"}");
                Console.WriteLine($"Placa: {car1.Placa = "7777"}");
                Console.WriteLine($"Anio: {car1.Anio = 2019}");
                Console.WriteLine($"Tipo: {car1.Tipo = TipoVehiculo.PickUp}");
                Console.WriteLine($"Estado: {car1.Estado}");

                car1.Acelerar();
                Console.WriteLine(car1.Estado);
                car1.Frenar();
                Console.WriteLine(car1.Estado);

            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
