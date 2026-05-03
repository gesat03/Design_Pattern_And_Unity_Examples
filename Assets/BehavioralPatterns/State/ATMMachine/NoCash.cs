namespace Assets.GurkansSandBox.StatePattern.ATMMachine
{
    class NoCash : IATMState
    {

        ATMMachine _atmMachine;

        public NoCash(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void EjectCard()
        {
            throw new System.NotImplementedException();
        }

        public void InsertCard()
        {
            throw new System.NotImplementedException();
        }

        public void InsertPin(int pinEntered)
        {
            throw new System.NotImplementedException();
        }

        public void RequestCash(int cashToWithdraw)
        {
            throw new System.NotImplementedException();
        }
    }
}
