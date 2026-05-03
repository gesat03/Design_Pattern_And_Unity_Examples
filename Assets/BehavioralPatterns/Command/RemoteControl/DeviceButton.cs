namespace Assets.GurkansSandBox.CommandPattern.RemoteControl
{
    public class DeviceButton
    {
        ICommand _command;

        public DeviceButton(ICommand command)
        {
            _command = command;
        }

        public void Press()
        {
            _command.Execute();
        }

        public void PressUndo()
        {
            _command.Undo();
        }
    }
}
