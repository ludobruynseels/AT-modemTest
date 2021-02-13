using ScintillaNET;

namespace AT_modemTest
{
    public interface IAtCommands
    {
        public Scintilla ScLogControl { get;  }
        public Scintilla ScScriptControl { get; }
        void ClearLog();
    }
}