namespace Assets.GurkansSandBox.StatePattern.ATMMachine
{
    class ATMMachine
    {
        private IATMState _hasCard;
        private IATMState _noCard;
        private IATMState _hasCorrectPin;
        private IATMState _atmOutOfMoney;

        private IATMState _atmState;

        private int _cashInMachine = 2000;
        private bool _correctPinEntered = false;

        public ATMMachine()
        {
            _hasCard = new HasCard(this);
            _noCard = new NoCard(this);
            _hasCorrectPin = new HasPin(this);
            _atmOutOfMoney = new NoCash(this);

            _atmState = _noCard;

            if(_cashInMachine < 0)
            {
                _atmState = _atmOutOfMoney;
            }
        }

        public void SetATMState(IATMState newState)
        {
            _atmState = newState;
        }

        public void SetCashInMachine(int newCashInMachine)
        {
            _cashInMachine = newCashInMachine;
        }

        public void PinState(bool correctPinEntered)
        {
            _correctPinEntered = correctPinEntered;
        }

        public void InsertCard()
        {
            _atmState.InsertCard();
        }

        public void EjectCard()
        {
            _atmState.EjectCard();
        }

        public void RequestCash(int cashToWithdraw)
        {
            _atmState.RequestCash(cashToWithdraw);
        }

        public void InsertPin(int pinEntered)
        {
            _atmState.InsertPin(pinEntered);
        }

        public IATMState GetYesCardState() { return _hasCard; }
        public IATMState GetNoCardState() { return _noCard; }
        public IATMState GetHasPin() { return _hasCorrectPin; }
        public IATMState GetNoCashState() { return _atmOutOfMoney; }

    }
}
