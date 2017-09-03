using System;

namespace health
{
    class Program
    {
        static void Main(string[] args)
        { //Start the program with Clear();
            Console.Clear();


            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();


            Console.WriteLine("This is a health app this will. This calculate your steps to km and how much calaries to burn.");
            
            Console.WriteLine("walking               Code:Walking ");
            Console.WriteLine("Cycling               Code: Cycling");
             Console.WriteLine("Cycling               Code: Cycling");
            

        
             string Userinput = Console.ReadLine();
           
             var Miles = "Miles";
             var Km = "km";
             var Kg = "Kg";
             var Pound = "Pound";
           

              string value = "turnip";
             switch (value)
             {
             case "Walking": 
              Console.WriteLine("Please enter is you want to measure in KM or Miles");
             if (Userinput == Km)
             {
                
               
              
               
                 Console.WriteLine("Please enter steps.");
                    Double walk = Double.Parse(Console.ReadLine());
                    Double ConvertedNumber = Math.Round(walk / 1585.549132947977, 2);
                    Double ConvertedNumber1 = Math.Round(walk / 0.5308641973087, 2);

                    Console.WriteLine($"You have traveled {ConvertedNumber} Km and lost {ConvertedNumber1} Calaries");
                

            }

            else if (Userinput == Miles)
            {
                 Console.WriteLine("Please enter steps.");
                    Double walk = Double.Parse(Console.ReadLine());
                    Double ConvertedNumber = Math.Round(walk /2150, 2);
                    Double ConvertedNumber1 = Math.Round(walk / 0.5308641973087, 2);

                    Console.WriteLine($"You have traveled {ConvertedNumber} Miles and lost {ConvertedNumber1} Calaries");
            }
            break;

            case "Cycling":

             if (Userinput == Km)
            {
                Console.WriteLine("Please enter is you want to measure in KM or Miles");
               
              
               
                 Console.WriteLine("Please enter steps.");
                    Double walk = Double.Parse(Console.ReadLine());
                    Double ConvertedNumber = Math.Round(walk / 1585.549132947977, 2);
                    Double ConvertedNumber1 = Math.Round(walk / 0.5308641973087, 2);

                    Console.WriteLine($"You have traveled {ConvertedNumber} Km and lost {ConvertedNumber1} Calaries");
                

            }

            else if (Userinput == Miles)
            {
                 Console.WriteLine("Please enter steps.");
                    Double walk = Double.Parse(Console.ReadLine());
                    Double ConvertedNumber = Math.Round(walk /2150, 2);
                    Double ConvertedNumber1 = Math.Round(walk / 0.5308641973087, 2);

                    Console.WriteLine($"You have traveled {ConvertedNumber} Miles and lost {ConvertedNumber1} Calaries");
            }

            break;
            case "Swimming":
                   if (Userinput == Km)
            {
                Console.WriteLine("Please enter is you want to measure in KM or Miles");
               
              
               
                 Console.WriteLine("Please enter steps.");
                    Double walk = Double.Parse(Console.ReadLine());
                    Double ConvertedNumber = Math.Round(walk / 1585.549132947977, 2);
                    Double ConvertedNumber1 = Math.Round(walk / 0.5308641973087, 2);

                    Console.WriteLine($"You have traveledgr454566 {ConvertedNumber} Km and lost {ConvertedNumber1} Calaries");
                

            }

            else if (Userinput == Miles)
            {
                 Console.WriteLine("Please enter steps.");
                    Double walk = Double.Parse(Console.ReadLine());
                    Double ConvertedNumber = Math.Round(walk /2150, 2);
                    Double ConvertedNumber1 = Math.Round(walk / 0.5308641973087, 2);

                    Console.WriteLine($"You have traveled {ConvertedNumber} Miles and lost {ConvertedNumber1} Calaries");
            }
            break;
          
            default:
            Console.WriteLine(value: "Please enter the code");
            break;

         

         }
         Console.ReadLine();

        }

       
    }
    
}