namespace DSerfozo.CefGlue.Contract.Common
{
    public interface ICefDictionaryValue : ICefBase
    {
        void SetValue(string key, ICefValue value);

        void SetBinary(string key, ICefBinaryValue value);

        ICefValue GetValue(string key);

        ICefDictionaryValue GetDictionary(string key);

        string GetString(string key);

        string[] GetKeys();

        bool HasKey(string key);
        void SetString(string key, string value);
        void SetDictionary(string key, ICefDictionaryValue value);
    }
}
