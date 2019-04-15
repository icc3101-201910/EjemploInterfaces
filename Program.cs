using System;

namespace ConsoleApp13
{

    public class Mamifero
    {
        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento instintivo básico para sobrevivir...");
        }
    }

    class Humano : Mamifero
    {
        public override void pensar()
        {
            Console.WriteLine("Pensamiento inteligente (¿?)");
        }

        public void Hablar()
        {

        }
    }

    class Gorila : Mamifero
    {
        public override void pensar()
        {
            Console.WriteLine("Pensamiento más avanzado, puedo hacer cosas más complejas que muchos animales");
        }
    }

    class Caballo : Mamifero
    {

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Persona miPersona = new Persona();
            IComportamientoHumano c = new Persona();
            Programar p = new Persona();
            p.EscribeHelloWorld();
        }
    }
}