using ProyectoCarrito.Class;

Carro miCarrito = new Carro("Toyota", 2022, "Azul", 180);
Carro EstefaniCarrito = new Carro("Ferrari", 2022, "Rojo", 280);
Carro Liliancarrito = new Carro("Mazda", 2005, "Negro", 250);

if (miCarrito.Modelo > EstefaniCarrito.Modelo)
{
    Console.WriteLine("El carro del profe es mas reciente");
}
else
{
    Console.WriteLine("El carro de Estefani es mas reciente");
}

Console.WriteLine($"teacher car is {miCarrito.Marca}");
Console.WriteLine($"Estafani's car is {EstefaniCarrito.Marca}");
Console.WriteLine($"Estafani's model car is {EstefaniCarrito.Modelo}");

EstefaniCarrito.EncendidoMotor();
Console.WriteLine(EstefaniCarrito.GetVelocidadActual());
//EstefaniCarrito.EncendidoMotor();


for (int i = 0; i < 5; i++)
{
    EstefaniCarrito.acelerar();

}

//EstefaniCarrito.acelerar(0);
//EstefaniCarrito.acelerar(6);
//EstefaniCarrito.acelerar(1);


for (int i = 0; i < 3; i++)
{

    EstefaniCarrito.desacelerar();

}

for (int i = 0; i < 5; i++)
{

    EstefaniCarrito.frenar();

}

EstefaniCarrito.apagarmotor();
EstefaniCarrito.apagarmotor();
EstefaniCarrito.EncendidoMotor();
EstefaniCarrito.Bocinar();

Console.WriteLine("\n");
Console.WriteLine("Carro de Lilian");
Console.WriteLine($"Marca: {Liliancarrito.Marca}");
Console.WriteLine($"Modelo: {Liliancarrito.Modelo}");
Console.WriteLine($"Color: {Liliancarrito.Color}");
Console.WriteLine($"Velocidad Maxima : {Liliancarrito.VMaxima} KM/H");

Liliancarrito.EncendidoMotor();
Liliancarrito.EncendidoMotor();
Console.WriteLine(Liliancarrito.GetVelocidadActual());

for (int i = 0; i < 15; i++)
{
    Liliancarrito.acelerar();
}
for (int i = 0; i < 10; i++)
{
    Liliancarrito.desacelerar();
}
for (int i = 0; i < 10; i++)
{
    Liliancarrito.frenar();
}
Liliancarrito.Bocinar();
Liliancarrito.apagarmotor();
Liliancarrito.apagarmotor();
