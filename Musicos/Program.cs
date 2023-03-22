class Musico
{
    public string Nombre {get; set;}

    public Musico(string nombre) => Nombre = nombre;

    public void Saludar() => Console.WriteLine($"Hola, soy {Nombre} ");

    public virtual void Tocar() => Console.WriteLine($"{Nombre} está tocando su instrumento");
}

class Baterista:Musico
{
    public string Bateria {get; set;}

    public Baterista(string nombre, string bateria):base(nombre) => Bateria = bateria;

    public override void Tocar() => Console.WriteLine($"{Nombre} está tocando su {Bateria}");
}

class Bajista:Musico //algunos dicen que no
{
    public string Bajo {get; set;}

    public Bajista(string nombre, string bajo):base(nombre) => Bajo = bajo;

    public override void Tocar() => Console.WriteLine($"{Nombre} está tocando su {Bajo}");
   
}

class Program
{
    static void Main()
    {
       List<Musico> SodaStereo = new List<Musico>();

       SodaStereo.Add(new Musico("Gustavo Cerati"));
       SodaStereo.Add(new Bajista("Zeta", "MusicMan"));
       SodaStereo.Add(new Baterista("Charlie", "Tama")); 
       
       foreach(var m in SodaStereo) m.Saludar();
                  
       foreach(var m in SodaStereo) m.Tocar(); //esto se llama Polimorfismo
    }
}