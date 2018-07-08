namespace DSerfozo.CefGlue.Contract.Common
{
    public interface ICefProcessMessage : ICefBase
    {
        ICefListValue Arguments { get; }
        string Name { get; }
    }
}
