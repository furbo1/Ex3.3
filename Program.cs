using System;
using System.Collections.Generic;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {


            List<UserError> userErrors = new List<UserError>();
               
                userErrors.Add(new NumericInputError());
                userErrors.Add(new TextInputError());
           


            foreach (var userErr in userErrors)
            {
                Console.WriteLine(userErr.UEMessage());
            }

            //11.F - Varför är polymorfism viktigt att behärska?

            //Polymorphism is considered one of the important features of Object-Oriented Programming.
            //Polymorphism allows us to perform a single action in different ways. 
            //In other words, polymorphism allows you to define one interface and have multiple implementations.

            //12.F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?

            //It helps the programmer to reuse the codes, i.e., classes once written, tested and implemented can be reused as required. Saves a lot of time.
            //Single variable can be used to store multiple data types.
            //Easy to debug the codes.

            // 13.F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
            //The key technical differences between an abstract class and an interface are : 
            //Abstract classes can have constants, members, method stubs (methods without a body) and defined methods, 
            //whereas interfaces can only have constants and methods stubs.

        }
    }
}
