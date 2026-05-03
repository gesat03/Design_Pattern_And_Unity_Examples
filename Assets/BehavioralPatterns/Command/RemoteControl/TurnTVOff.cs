namespace Assets.GurkansSandBox.CommandPattern.RemoteControl
{
    public class TurnTVOff : ICommand
    {
        private IElectronicDevice _theDevice;

        public TurnTVOff(IElectronicDevice theDevice)
        {
            _theDevice = theDevice;
        }

        public void Execute()
        {
            _theDevice.Off();
        }

        public void Undo()
        {
            _theDevice.On();
        }
    }
}
