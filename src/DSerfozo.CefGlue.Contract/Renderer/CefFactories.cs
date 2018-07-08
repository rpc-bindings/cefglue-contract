using System;
using System.Runtime.CompilerServices;

namespace DSerfozo.CefGlue.Contract.Renderer
{
    public static class CefFactories
    {
        public static Func<ICefV8Context> CurrentContext { get; set; }

        public static Func<ICefV8Value> CreateNullValue { get; set; }
        public static Func<ICefV8Value> CreateObjectValue{ get; set; }
        public static Func<string, ICefV8Handler, ICefV8Value> CreateFunctionValue { get; set; }
        public static Func<string, ICefV8Value> CreateStringValue { get; set; }
        public static Func<int, ICefV8Value> CreateIntValue { get; set; }
        public static Func<double, ICefV8Value> CreateDoubleValue { get; set; }
        public static Func<DateTime, ICefV8Value> CreateDateValue { get; set; }
        public static Func<bool, ICefV8Value> CreateBoolValue { get; set; }
        public static Func<int, ICefV8Value> CreateArrayValue { get; set; }

        public static class CefV8Context
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Context GetCurrentContext()
            {
                return CurrentContext();
            }
        }

        public static class CefV8Value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Value CreateString(string value)
            {
                return CreateStringValue(value);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Value CreateNull()
            {
                return CreateNullValue();
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Value CreateObject()
            {
                return CreateObjectValue();
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Value CreateFunction(string name, ICefV8Handler handler)
            {
                return CreateFunctionValue(name, handler);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Value CreateInt(int value)
            {
                return CreateIntValue(value);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Value CreateDouble(double value)
            {
                return CreateDoubleValue(value);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Value CreateDate(DateTime value)
            {
                return CreateDateValue(value);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Value CreateBool(bool value)
            {
                return CreateBoolValue(value);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ICefV8Value CreateArray(int size)
            {
                return CreateArrayValue(size);
            }
        }
    }
}
