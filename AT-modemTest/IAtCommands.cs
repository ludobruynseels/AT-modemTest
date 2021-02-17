using ScintillaNET;

namespace AT_modemTest
{
    public interface IAtCommands
    {
        public Scintilla ScLogControl { get;  }
        public Scintilla ScScriptControl { get; }
        Status ModemStatus { get; set; }
        void ClearLog();
        void SendlineToModem(string s);
    }
}