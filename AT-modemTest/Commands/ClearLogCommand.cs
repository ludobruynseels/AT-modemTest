using System;

namespace AT_modemTest.Commands
{
    class ClearLogCommand : ICommand
    {
        private IAtCommands _form;

        public ClearLogCommand(IAtCommands form)
        {
            _form = form;
        }

        public void Execute()
        {
            _form.ClearLog();
        }
    }
}
