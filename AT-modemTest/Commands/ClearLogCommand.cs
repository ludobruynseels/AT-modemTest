namespace AT_modemTest.Commands
{
   public class ClearLogCommand : ICommand
    {
        public ClearLogCommand(IAtCommands atCommands)
        {
            Form = atCommands;
        }

        public IAtCommands Form { get; }

        public void Execute()
        {
            Form.ClearLog();
        }
    }
}
