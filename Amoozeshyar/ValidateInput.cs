using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amoozeshyar
{
    public class ValidateInput
    {
        public bool ValidateSelectedOption(string? str, out int validateInput, int minRange, int maxRange)
        {
            bool validatedResult = int.TryParse(str, out validateInput);

            if (!validatedResult)
            {
                return false;
            }

            if (validateInput >=  minRange && validateInput <= maxRange)
            {
                return true;
            }
            else 
            return false;
        }

        public bool ValidateNationalCode(string nationalCode)
        {
            bool isOnlyNumbers = long.TryParse(nationalCode, out long validatedNationalCode);

            if (nationalCode.Length == 10 && isOnlyNumbers)
            {
                return true;
            }

            return false;
        }
        
        public bool ValidateAge(int age)
        {
            if (age >= 18 && age <= 120 )
            {
                return true;
            }

            return false;
        }

        public void ValidateOperation(Result result ,string successfulMessage , string errorMessage)
        {
            if (result.IsSuccess)
            {
                Console.WriteLine($"\n{successfulMessage}");
            }
            else
            {
                Console.WriteLine("Error " + result.Exeption.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessage);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
