using DSerfozo.CefGlue.Contract.Common;

namespace DSerfozo.CefGlue.Contract.Renderer
{
    public interface ICefRenderProcessHandler
    {
        bool OnBeforeNavigation(ICefBrowser browser, ICefFrame frame, ICefRequest request, CefNavigationType navigation_type,
            bool isRedirect);

        void OnContextReleased(ICefBrowser browser, ICefFrame frame, ICefV8Context context);
        void OnBrowserCreated(ICefBrowser browser);
        void OnBrowserDestroyed(ICefBrowser browser);
        void OnContextCreated(ICefBrowser browser, ICefFrame frame, ICefV8Context context);
        void OnWebKitInitialized();

        bool OnProcessMessageReceived(ICefBrowser browser, CefProcessId sourceProcess,
            ICefProcessMessage message);
    }
}
