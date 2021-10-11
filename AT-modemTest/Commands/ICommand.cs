namespace AT_modemTest
{
    public interface ICommand
    {
        IAtCommands Form { get; }
        void Execute();
    }
}
