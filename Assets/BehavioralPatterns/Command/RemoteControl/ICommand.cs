namespace Assets.GurkansSandBox.CommandPattern.RemoteControl
{
    public interface ICommand
    {
        public void Execute();

        public void Undo();
    }
}
