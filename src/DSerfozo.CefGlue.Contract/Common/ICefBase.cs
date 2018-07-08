using System;

namespace DSerfozo.CefGlue.Contract.Common
{
    public interface ICefBase : IDisposable
    {
        T Unwrap<T>() where T : class, IDisposable;

        void Dispose(bool disposing);
    }
}
