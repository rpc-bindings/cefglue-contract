using DSerfozo.CefGlue.Contract.Common;

namespace DSerfozo.CefGlue.Contract.Renderer
{
    public interface ICefV8Exception : ICefBase
    {
        string Message { get; }
    }
}
