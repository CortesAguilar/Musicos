abstract class Musico //clases abstactas solo pueden generar subclases, pero no objetos directamente.
{                     //clases no abstractas admiten polimorfismo en sus objetos.
    public string Nombre {get; set;}

    public Musico(string nombre) => Nombre = nombre;

    public virtual string GetSaludo() => "Hola, soy " + Nombre;

     public virtual void Saludar() => Console.WriteLine(GetSaludo()); //refactorizando el saludo para reutilizar.

    public /*virtual*/ abstract void Tocar(); // Console.WriteLine($"{Nombre} está tocando su instrumento");

    /*  Metodos abstractos: Deben estar en clases abstractas para existir. 
                            Metodos abstractos no tienen implementación.
                            Deben obligatoriamente redefinirse en subclases
     
        Metodos virtuales:  Dan la opción de redefinirse en subclases
            */
}



class Baterista:Musico
{
    public string Bateria {get; set;}

    public Baterista(string nombre, string bateria):base(nombre) => Bateria = bateria;

    public override /*new*/ void Tocar() => Console.WriteLine($"{Nombre} está tocando su {Bateria}");
    //para implementar metodos abstractos debemos de usar la palabra reservada override (redefinir/sobreescribir)

    public override string GetSaludo() => base.GetSaludo() + " y soy baterísta" ;
    public override void Saludar() => Console.WriteLine(GetSaludo());
}

class Guitarrista:Musico
{
    public string Guitarra {get; set;}

    public Guitarrista(string nombre, string guitarra):base(nombre) => Guitarra = guitarra;

    public override /*new*/ void Tocar() => Console.WriteLine($"{Nombre} está tocando su {Guitarra}");
    //para implementar metodos abstractos debemos de usar la palabra reservada override (redefinir/sobreescribir)

     public override string GetSaludo() => base.GetSaludo() + " y soy guitarrista, che" ;
    public override void Saludar() => Console.WriteLine(GetSaludo());
}

class Bajista:Musico
{
    public string Bajo {get; set;}

    public Bajista(string nombre, string bajo):base(nombre) => Bajo = bajo;

    public override void Tocar() => Console.WriteLine($"{Nombre} está tocando su {Bajo}");

     public override string GetSaludo() => base.GetSaludo() + " y lamentablemente soy bajista" ;
    public override void Saludar() => Console.WriteLine(GetSaludo());
}

class Program
{
    static void Main()
    {
       List<Musico> SodaStereo = new List<Musico>(); //Se puede crear listas de clases abstractas. (referencias)

       SodaStereo.Add(new Guitarrista("Gustavo Cerati", "Gibson"));
       SodaStereo.Add(new Bajista("Zeta", "MusicMan"));
       SodaStereo.Add(new Baterista("Charlie", "Tama")); 
       
       foreach(var m in SodaStereo) m.Saludar();
                  
       foreach(var m in SodaStereo) m.Tocar(); /*Polimorfismo: Los objetos pueden variar su comportamiento
                                                               dependiendo del contexto. (clase/subclase)*/
    }
}