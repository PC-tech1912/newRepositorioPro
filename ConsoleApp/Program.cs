// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Animales animal = new Carnivoros();
//Animales animal = new Animales();
var animal1 = new Animales();
Carnivoros animal2 = new Carnivoros();
Animales animal3 = animal2;
Animales animal4 = (Animales)animal2;
Animales animal5 = (Carnivoros)animal2;


animal.id_Raza = 1;
animal.Nombre = "Perro";
animal.tamaño = 50m;
animal.peso = 15;
animal.Vive = false;
animal.FechaN = new DateTime(2000, 1, 1);
animal.Estado = new Estados() { Estado = "sano", id = 1, Nombre = "JuanElperro" };
animal.videojuego = new List<VideoJuegos>();
animal.videojuego.Add(new VideoJuegos() { id_V = 1, Nombre = "GTA" });
animal.videojuego.Add(new VideoJuegos() { id_V = 2, Nombre = "DOOM" });

Console.WriteLine(animal.Nombre);
Console.WriteLine(animal.Estado.Nombre);
foreach (var elemento in animal.videojuego) {
    Console.WriteLine(elemento.Nombre);
}


public class Animales
{
    public int id_Raza;
    public string? Nombre;
    public decimal tamaño;
    public decimal peso;
    public bool Vive;
    public DateTime FechaN;
    public Carnivoros? carnivoro;
    public Estados? Estado;
    public List<VideoJuegos>? videojuego;


}
public class Carnivoros : Animales
{
    
    public decimal CarneConsu;


}

public class Estados
{
    public string? Estado;
    public int id;
    public string? Nombre;
}
public class VideoJuegos
{
    public int id_V;
    public string? Nombre;

}
