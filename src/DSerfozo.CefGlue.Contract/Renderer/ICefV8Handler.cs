namespace DSerfozo.CefGlue.Contract.Renderer
{
    public interface ICefV8Handler
    {
        bool Execute(string name, ICefV8Value obj, ICefV8Value[] arguments, out ICefV8Value returnValue, out string exception);
    }
}
