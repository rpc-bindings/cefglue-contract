using System;
using System.Runtime.CompilerServices;

namespace DSerfozo.CefGlue.Contract.Common
{
    public static class CefFactories
    {
        public static Func<string, ICefProcessMessage> CreateProcessMessage { get; set; }
        public static Func<ICefValue> CreateValue { get; set; }
        public static Func<ICefListValue> CreateList { get; set; }
        public static Func<ICefDictionaryValue> CreateDictionary { get; set; }
        public static Func<byte[], ICefBinaryValue> CreateBinary { get; set; }

        public static class CefProcessMessage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefProcessMessage Create(string name)
            {
                return CreateProcessMessage(name);
            }
        }

        public static class CefListValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefListValue Create()
            {
                return CreateList();
            }
        }

        public static class CefDictionaryValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefDictionaryValue Create()
            {
                return CreateDictionary();
            }
        }

        public static class CefBinaryValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefBinaryValue Create(byte[] buffer)
            {
                return CreateBinary(buffer);
            }
        }

        public static class CefValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefValue Create()
            {
                return CreateValue();
            }
        }
    }
}
