using DSerfozo.CefGlue.Contract.Common;

namespace DSerfozo.CefGlue.Contract.Browser
{
    public interface ICefClient
    {
        bool OnProcessMessageReceived(ICefBrowser browser, CefProcessId sourceProcess, ICefProcessMessage message);
    }
}
