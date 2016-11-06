using System;

namespace _21stOctober2016
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ENTER THE AMOUNT TO WITHDRAW: ");
            var amount = Convert.ToInt32(Console.ReadLine());

            ValidateAmount validateAmt = new ValidateAmount();
            if (validateAmt.ValidateAmt(amount))
            {
                CountThousandNotes countThousandNotes = new CountThousandNotes();
                CountFiveHundredNotes countFiveHundredNotes = new CountFiveHundredNotes();
                CountHundredNotes countHundredNotes = new CountHundredNotes();

                countThousandNotes.SetNextDispenser(countFiveHundredNotes);
                countFiveHundredNotes.SetNextDispenser(countHundredNotes);

                Dispense dispenseReq = new Dispense { Amount = amount };
                countThousandNotes.Dispense(dispenseReq);
            }
            Console.ReadLine();
        }
    }
}
