namespace DSerfozo.CefGlue.Contract.Common
{
    public interface ICefListValue : ICefBase
    {
        int Count { get; }

        void SetValue(int index, ICefValue value);

        void SetBinary(int index, ICefBinaryValue value);

        ICefValue GetValue(int index);
        void SetSize(int size);
        bool GetBool(int index);
        string GetString(int index);
    }
}
