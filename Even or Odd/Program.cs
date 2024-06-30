using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        string? input = Console.ReadLine();      // I asked for the user input first   
         
        if (!string.IsNullOrEmpty(input) && input.All(char.IsDigit))
        {
            int userInput = Convert.ToInt32(input); 

            // Making sure userInput isn't negative
            if (userInput < 0) 
            {
                Console.WriteLine("Please enter a number greater than 0");
                return;
            }

            // Checking even or even and prime
            else if (userInput % 2 == 0)
            {
                if (userInput == 2)
                {
                    Console.WriteLine("Your number must be an even and a prime number as well!");
                    return;
                }else
                {
                    Console.WriteLine("Your number must be an even number.");
                    return;
                }
            }
            // Checking odd and prime
            else
            {
                    if(userInput % userInput == 0 && userInput % 1 == 0)
                    {
                    Console.WriteLine("Your number must be an odd number and a prime number as well.");
                    }else
                {
                    Console.WriteLine("Your number must be an odd number");
                }
                
            }
        }
        else
        {
            Console.WriteLine("Enter a valid number.");
        }

    }
}

// First of all , i asked for the user input , as we all know the user input could be null or empty as well as string , 
// i checked the condition here first , if the user input is empty or is a string , we will log "Enter a valid number",
// Else , we will continue to check 3 more conditions : 
// If the user input is negative int => log "greater than 0" 
// If - the user input is divisible by 2 => log 'even number"
// If - the user input is not divisible by 2 => log 'odd number"


//What is prime number ? => A prime number is a number which is divisible only by itself and one : 
//                       => Odd numbers are prime number , except the even number , 2

// So ,According to definition : I added another if statement below "even number" , the condition if userInput == 2 , if so it is even and prime number
// Lastly , I check the prime and odd 
