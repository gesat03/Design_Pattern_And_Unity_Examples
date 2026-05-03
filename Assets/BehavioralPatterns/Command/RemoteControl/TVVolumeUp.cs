namespace Assets.GurkansSandBox.CommandPattern.RemoteControl
{
    public class TVVolumeUp : ICommand
    {
        private IElectronicDevice _theDevice;

        public TVVolumeUp(IElectronicDevice theDevice)
        {
            _theDevice = theDevice;
        }

        public void Execute()
        {
            _theDevice.VolumeUp();
        }

        public void Undo()
        {
            _theDevice.VolumeDown();
        }
    }
}
