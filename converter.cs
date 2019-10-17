using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hi! What is the unit of temperature to be converted? If Celsius to Fahrenheit then type a, if fahrenheit to Celsius, then type b");
    string userChoice = Console.ReadLine();
    Console.WriteLine("Type the number to be converted");
    double userInput = double.Parse(Console.ReadLine());
    double result;
    if (userChoice == "a") {
         result = userInput*9/5+32;
         Console.WriteLine ($"The temperature in Fahrenheit is  {result}." );
    }
    else if (userChoice =="b")
     {
      result = (userInput-32)/5*9;
      Console.WriteLine ($"The temperature in Fahrenheit is {result}." );
    }
    else {
           Console.WriteLine();
    }
    Console.ReadLine(); 
  }
}
