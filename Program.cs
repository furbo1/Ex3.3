using System;
using System.Collections.Generic;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> userErrors= new List<UserError>();

            NumericInputError numErr = new NumericInputError();
            TextInputError txtErr = new TextInputError();
          
            userErrors.Add(numErr);
            userErrors.Add(txtErr);

            foreach (var userErr in userErrors)
            {
                Console.WriteLine(userErr.UEMessage(""));
            }
           
        }
    }
}
