using UnityEngine;

namespace Assets.GurkansSandBox.StatePattern.ATMMachine
{
    class HasCard : IATMState
    {
        ATMMachine _atmMachine;

        public HasCard(ATMMachine atmMachine)
        {
            _atmMachine = atmMachine;
        }

        public void EjectCard()
        {
            Debug.Log("Your card is ejected");
            _atmMachine.SetATMState(_atmMachine.GetNoCardState());
        }

        public void InsertCard()
        {
            Debug.Log("You can only insert on card at a time");
        }

        public void InsertPin(int pinEntered)
        {
            if(pinEntered == 1234)
            {
                Debug.Log("You entered the correct PIN");
                _atmMachine.PinState(true);
                _atmMachine.SetATMState(_atmMachine.GetHasPin());
            }
            else
            {
                Debug.Log("You entered the wrong PIN");
                _atmMachine.PinState(false);
                Debug.Log("Your card is ejected");
                _atmMachine.SetATMState(_atmMachine.GetNoCardState());
            }
        }

        public void RequestCash(int cashToWithdraw)
        {
            Debug.Log("You have not entered your PIN");
        }
    }
}
