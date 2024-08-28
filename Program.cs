using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Aquarium2._0;
using static Aquarium2._0.Type;
using Type = Aquarium2._0.Type;


Tank tank = new Tank();
Main();
void Main()
 {
     while (true)
     {
        Console.Clear();
        Console.WriteLine("This is an aquarium where you can view some fish!");
         Console.WriteLine("\n\tThe fish are very excited to see you! \n");

         tank.FishListed();

        MainMenu();
     }
 }


 void MainMenu()
 {
     Console.WriteLine("You can see some more information about the fish we have in this tank!");
     Console.WriteLine("Just choose what fish you'd like to see some more info about!");
     Console.WriteLine("You can also write exit and leave the aquarium.");
     var MenuInput = Console.ReadLine().ToLower();

     switch (MenuInput)
     {
        case "pufferfish":
            tank.PrintChoiceFish(Type.TypeName.Pufferfish);
            break;
        case "hammerhead":
            tank.PrintChoiceFish(Type.TypeName.Hammerhead);
            break;
        case "goldfish":
            tank.PrintChoiceFish(Type.TypeName.Goldfish);
            break;
        case "jellyfish":
            tank.PrintChoiceFish(Type.TypeName.Jellyfish);
            break;
        case "tigershark":
            tank.PrintChoiceFish(Type.TypeName.Tigershark);
            break;
        case "exit":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Please input either the name of a fish or exit.");
            break;
     }
     



 }