using ScintillaNET;

namespace AT_modemTest
{
    public interface IAtCommands
    {
        public Scintilla ScControl { get;  }
        void ClearLog();
    }
}