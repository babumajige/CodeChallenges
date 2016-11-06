namespace _21stOctober2016
{
    public interface IDispenser
    {
        void SetNextDispenser(IDispenser dispenser);
        void Dispense(Dispense dispense);
    }
}
