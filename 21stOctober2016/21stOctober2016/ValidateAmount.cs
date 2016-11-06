using System;

namespace _21stOctober2016
{
    class ValidateAmount
    {
        public bool ValidateAmt(int withdraw)
        {
            if (withdraw % 100 != 0)
            {
                Console.WriteLine("\n Amount Cannot be dispensed");
                return false;
            }
            else
                return true;
        }
    }
}
