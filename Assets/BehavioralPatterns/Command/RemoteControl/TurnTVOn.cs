namespace Assets.GurkansSandBox.CommandPattern.RemoteControl
{
    public class TurnTVOn : ICommand
    {
        private IElectronicDevice _theDevice;

        public TurnTVOn(IElectronicDevice theDevice)
        {
            _theDevice = theDevice;
        }

        public void Execute()
        {
            _theDevice.On();
        }

        public void Undo()
        {
            _theDevice.Off();
        }
    }
}
