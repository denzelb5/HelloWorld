using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string color;
            string answer;
            string response;

            Console.WriteLine("Hello!  Choose your preferred dialect: Pirate, British, or Southern.");
            response = Console.ReadLine().ToLower();

            switch (response)
            {
                case "pirate":
                    Console.WriteLine("Ahoy Matey! wha' be yer name?");
                    break;

                case "british":
                    Console.WriteLine("Jolly good chap!  Might I ask your name?");
                    break;

                default:
                    Console.WriteLine("Howdy!  What's your name sugar?");
                    break;
            }

            
            name = Console.ReadLine();
            //Console.ReadKey(); // What happens if you run the app without this line?
            Console.WriteLine($"Welcome {name}!");
            Console.WriteLine("What is your favorite color?");
            color = Console.ReadLine();
            Console.WriteLine($"Would you like to have a {color} animal? Type yes or no.");
            answer = Console.ReadLine();

            if (answer == "yes")
            {

                var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Dog", "Cat" };


                foreach (var animal in animals)
                {
                    var numSyllables = 0;
                    foreach (char wc in animal)
                    {


                        if (wc == 'a' || wc == 'e' || wc == 'i' || wc == 'o' || wc == 'u')
                        {
                            numSyllables++;

                        }
                    }

                    if (numSyllables >= 2)
                    {

                        
                        Console.WriteLine(animal);
                    }

                }

                Random Rand = new Random();
                int index = Rand.Next(0, (animals.Length - 1));
                Console.WriteLine($"You have a {color} {animals[index]}");

            }


        }
    }

}