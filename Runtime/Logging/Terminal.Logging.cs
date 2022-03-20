using System.Runtime.CompilerServices;

using UnityEngine;

using JetBrains.Annotations;

namespace CGTK.Utils.Terminal
{
    using static PackageConstants;
    
    [PublicAPI]
    public static partial class Terminal
    {
        [MethodImpl(methodImplOptions: INLINE)]
        public static void Log(this object message)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.Log(
                message: message);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void Log(this object message, in Object context)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.Log(
                message: message, 
                context: context);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogFormat(this string format, params object[] args)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogFormat(
                format: format, 
                args: args);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogFormat(this string format, in Object context, params object[] args)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogFormat(
                context: context, 
                format: format, 
                args: args);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogAssertion(this Object message)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogAssertion(
                message: message);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogAssertion(this Object message, in Object context)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogAssertion(
                message: message, 
                context: context);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogAssertionFormat(this string format, params object[] args)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogAssertionFormat(
                format: format, 
                args: args);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogAssertionFormat(this string format, in Object context, params object[] args)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogAssertionFormat(
                context: context, 
                format: format, 
                args: args);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogError(this object message)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogError(
                message: message);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogError(this object message, in Object context)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogError(
                message: message, 
                context: context);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogErrorFormat(this string format, params object[] args)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogErrorFormat(
                format: format, 
                args: args);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogErrorFormat(this string format, in Object context, params object[] args)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogErrorFormat(
                context: context, 
                format: format, 
                args: args);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogWarning(this object message)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogWarning(
                message: message);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogWarning(this object message, in Object context)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogWarning(
                message: message, 
                context: context);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogWarningFormat(this string format, params object[] args)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogWarningFormat(
                format: format, 
                args: args);
            #endif
        }
    
        [MethodImpl(methodImplOptions: INLINE)]
        public static void LogWarningFormat(this string format, in Object context, params object[] args)
        {
            #if UNITY_EDITOR || USE_TERMINAL
            Debug.LogWarningFormat(
                context: context, 
                format: format, 
                args: args);
            #endif
        }
    }
}
