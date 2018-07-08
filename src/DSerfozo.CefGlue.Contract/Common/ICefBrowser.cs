namespace DSerfozo.CefGlue.Contract.Common
{
    public interface ICefBrowser : ICefBase
    {
        void SendProcessMessage(CefProcessId renderer, ICefProcessMessage message);
        int Identifier { get; }
    }
}
