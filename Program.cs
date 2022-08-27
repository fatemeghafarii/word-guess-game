using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {  
            string showNames;
            string selectUser;
            // bool inArrays = true;

            int totalNames = 1; 
            int index;
            Console.WriteLine("^_^Welcome to the word guess game^_^");
            string[] names = new string[6]; 
            for(index = 0; index < names.Length; index++)
            {
                Console.WriteLine($"Enter name (totalnames : {totalNames++})");
                names[index] = Console.ReadLine();
                if(names[index] == "")
                {
                    Console.WriteLine("You should enter a word, Please try again!");
                    totalNames--;
                }
            }
            
            bool again = true;
            do
            {
                showNames = string.Join("/", names);
                Console.Write($"names is : {showNames}");

                Random random = new Random();
                var randomSystem = random.Next(names.Length);
                var selectSystem = names[randomSystem];
                Console.WriteLine();
                Console.WriteLine(selectSystem);

                Console.WriteLine("Enter your select name: ");
                selectUser = Console.ReadLine();
                
                // inArrays = names.Contains(selectUser) == true;

                int round = 0;   
                while(selectUser != selectSystem)
                {
                    Console.WriteLine($"User your select {selectUser} isn\'t equal with system\'s select");
                    Console.WriteLine("try again");
                    
                    Console.WriteLine(showNames);
                    Console.WriteLine("Enter your select name: ");
                    selectUser = Console.ReadLine();
                    round ++;
                }
                Console.WriteLine($"YOU WIN, your true guess is {selectUser}");
                Console.WriteLine($"Round: {round}");

                Console.WriteLine("Would you like to play again (Y/N)");
                var againGame = Console.ReadLine();

                again = againGame.ToUpper() == "Y";

            }while(again);  
            Console.WriteLine("Thanks for palying ^_^ !"); 

            // }while(inArrays);
            // Console.WriteLine("Invalid input");
            // Console.WriteLine($"you should be select between words in {showWords}");  
        }    
    }    
}

