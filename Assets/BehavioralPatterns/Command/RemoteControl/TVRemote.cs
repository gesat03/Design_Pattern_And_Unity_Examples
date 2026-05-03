namespace Assets.GurkansSandBox.CommandPattern.RemoteControl
{
    public class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
