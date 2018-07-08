namespace DSerfozo.CefGlue.Contract.Common
{
    public interface ICefValue : ICefBase
    {
        ICefListValue GetList();

        ICefDictionaryValue GetDictionary();

        ICefBinaryValue GetBinary();

        string GetString();

        int GetInt();

        double GetDouble();

        void SetBinary(ICefBinaryValue value);

        CefValueType GetValueType();

        ICefValue Copy();
        void SetNull();
        void SetList(ICefListValue value);
        bool GetBool();
        void SetString(string value);
        void SetInt(int value);
        void SetDouble(double value);
        void SetBool(bool value);
        void SetDictionary(ICefDictionaryValue value);
    }
}
