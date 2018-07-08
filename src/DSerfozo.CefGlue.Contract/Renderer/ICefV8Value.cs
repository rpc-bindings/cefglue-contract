using System;
using DSerfozo.CefGlue.Contract.Common;

namespace DSerfozo.CefGlue.Contract.Renderer
{
    public interface ICefV8Value : ICefBase
    {
        string GetStringValue();
        bool GetBoolValue();
        bool IsString { get; }
        bool HasException { get; }
        bool IsBool { get; }
        bool IsDouble { get; }
        bool IsInt { get; }
        bool IsUInt { get; }
        bool IsDate { get; }
        bool IsArray { get; }
        bool IsFunction { get; }
        bool IsObject { get; }
        ICefV8Value ExecuteFunction(ICefV8Value obj, ICefV8Value[] arguments);
        ICefV8Exception GetException();
        void ClearException();
        ICefV8Value GetValue(string key);
        ICefUserData GetUserData();
        ICefV8Value ExecuteFunctionWithContext(ICefV8Context context, ICefV8Value obj, ICefV8Value[] arguments);
        void SetUserData(ICefUserData promiseUserData);
        double GetDoubleValue();
        int GetIntValue();
        uint GetUIntValue();
        DateTime GetDateValue();
        int GetArrayLength();
        bool TryGetKeys(out string[] keys);
        ICefV8Value GetValue(int index);
        void SetValue(string key, ICefV8Value value);
        void SetValue(int index, ICefV8Value value);
        void SetValue(string key, ICefV8Value value, CefV8PropertyAttribute attributes);
        bool IsSame(ICefV8Value cefV8Value);
    }
}
