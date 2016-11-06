
namespace _21stOctober2016
{
    public class CountThousandNotes: IDispenser
    {
        private IDispenser _dispenser;

        public void SetNextDispenser(IDispenser dispenser)
        {
            _dispenser = dispenser;
        }
        public void Dispense(Dispense dispense)
        {
            var displayDenimonations = new DisplayDenominations();

            CurrencyTypes currencyType = new CurrencyTypes();
            var denomination = currencyType.Thousands;

            if (dispense.Amount >= denomination)
            {
                var count = dispense.Amount / denomination;
                var remainder = dispense.Amount % denomination;
                if (count != 0)
                {
                    displayDenimonations.Display(denomination, count);
                }
                if (remainder > 0)
                {
                    _dispenser.Dispense(new Dispense{Amount = remainder});
                }
            }
            else if (_dispenser != null)
            {
                _dispenser.Dispense(dispense);
            }
        }
    }
}
