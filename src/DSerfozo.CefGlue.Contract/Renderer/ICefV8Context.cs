using System;
using DSerfozo.CefGlue.Contract.Common;

namespace DSerfozo.CefGlue.Contract.Renderer
{
    public interface ICefV8Context : ICefBase
    {
        bool IsSame(ICefV8Context context);
        bool Enter();
        void Exit();
        ICefBrowser GetBrowser();
        ICefV8Value GetGlobal();
        ICefFrame GetFrame();
    }
}
