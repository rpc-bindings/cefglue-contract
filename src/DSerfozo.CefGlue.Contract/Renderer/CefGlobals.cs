using System;
using System.Runtime.CompilerServices;

namespace DSerfozo.CefGlue.Contract.Renderer
{
    public static class CefGlobals
    {
        public static Action<string, string, ICefV8Handler> RuntimeRegisterExtension;

        public static class CefRuntime
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void RegisterExtension(string extensionname, string script, ICefV8Handler handler)
            {
                RuntimeRegisterExtension(extensionname, script, handler);
            }
        }
    }
}
