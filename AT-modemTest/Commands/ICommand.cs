namespace AT_modemTest.Commands
{
    public interface ICommand
    {
        IAtCommands Form { get; }
        void Execute();
    }
}
