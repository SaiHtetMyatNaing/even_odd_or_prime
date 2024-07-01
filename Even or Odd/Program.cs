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
                // Initializing the empty array to check the factor of a number
                int[] nums = new int[userInput + 1];     // If i don't add 1 , the items count in the array would be less than userInput , as the array start from 0
                int count = 0;             // To check the numbers of "0"

                for(int i = 0; i <= userInput; i++)   // Checking whether the remainder is 0 or not
                {
                    int answer = userInput % (i + 1);  // I added "1" because I don't want the division starts from "0"
                    nums[i] = answer;           // Added to an array

                    if (answer == 0) { count++; }                    
                }
                // As there are only 2 factors in prime number , i condition the situation in this way
                if (count >= 3)
                {
                    Console.WriteLine("Your number is and odd number.");
                }else
                {
                    Console.WriteLine("Your number is both an odd and prime number.");
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
