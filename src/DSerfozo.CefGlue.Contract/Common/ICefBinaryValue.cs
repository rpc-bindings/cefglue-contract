namespace DSerfozo.CefGlue.Contract.Common
{
    public interface ICefBinaryValue : ICefBase
    {
        long Size { get; }

        long GetData(byte[] buffer, long bufferSize, int offset);
    }
}
