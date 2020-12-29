using System;
using System.Collections.Generic;

namespace OpenClassRoom_Cour_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animaux = new List<Animal>();
            Animal chien = new Chien();
            Animal tom = new Chat("Tom");
            Animal felix = new Chat("Félix");

            animaux.Add(chien);
            animaux.Add(tom);
            animaux.Add(felix);

            foreach (Animal animal in animaux)
            {
                animal.Respirer();
            }
        }
    }

    public class Animal
    {
        protected string prenom;

        public Animal()
        {
            prenom = "Marcel";
        }

        public void Respirer()
        {
            Console.WriteLine("Je suis " + prenom + " et je respire");
        }
    }

    public class Chien : Animal
    {
        public void Aboyer()
        {
            Console.WriteLine("Wouaf !");
        }
    }

    public class Chat : Animal
    {
        public Chat(string prenomDuChat)
        {
            prenom = prenomDuChat;
        }

        public void Miauler()
        {
            Console.WriteLine("Miaou");
        }
    }


}
