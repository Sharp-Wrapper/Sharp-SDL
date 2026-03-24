using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public enum SDL_LogCategory
    {
        SDL_LOG_CATEGORY_APPLICATION,
        SDL_LOG_CATEGORY_ERROR,
        SDL_LOG_CATEGORY_ASSERT,
        SDL_LOG_CATEGORY_SYSTEM,
        SDL_LOG_CATEGORY_AUDIO,
        SDL_LOG_CATEGORY_VIDEO,
        SDL_LOG_CATEGORY_RENDER,
        SDL_LOG_CATEGORY_INPUT,
        SDL_LOG_CATEGORY_TEST,
        SDL_LOG_CATEGORY_GPU,
        SDL_LOG_CATEGORY_RESERVED2,
        SDL_LOG_CATEGORY_RESERVED3,
        SDL_LOG_CATEGORY_RESERVED4,
        SDL_LOG_CATEGORY_RESERVED5,
        SDL_LOG_CATEGORY_RESERVED6,
        SDL_LOG_CATEGORY_RESERVED7,
        SDL_LOG_CATEGORY_RESERVED8,
        SDL_LOG_CATEGORY_RESERVED9,
        SDL_LOG_CATEGORY_RESERVED10,
        SDL_LOG_CATEGORY_CUSTOM,
    }

    public enum SDL_LogPriority
    {
        SDL_LOG_PRIORITY_INVALID,
        SDL_LOG_PRIORITY_TRACE,
        SDL_LOG_PRIORITY_VERBOSE,
        SDL_LOG_PRIORITY_DEBUG,
        SDL_LOG_PRIORITY_INFO,
        SDL_LOG_PRIORITY_WARN,
        SDL_LOG_PRIORITY_ERROR,
        SDL_LOG_PRIORITY_CRITICAL,
        SDL_LOG_PRIORITY_COUNT,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_LogOutputFunction(void* userdata, int category, SDL_LogPriority priority, [NativeTypeName("const char *")] sbyte* message);

    public static unsafe partial class SDLLog
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetLogPriorities(SDL_LogPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetLogPriority(int category, SDL_LogPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_LogPriority SDL_GetLogPriority(int category);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ResetLogPriorities();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetLogPriorityPrefix(SDL_LogPriority priority, [NativeTypeName("const char *")] sbyte* prefix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_Log([NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogTrace(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogVerbose(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogDebug(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogInfo(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogWarn(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogError(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogCritical(int category, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogMessage(int category, SDL_LogPriority priority, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_LogOutputFunction")]
        public static extern IntPtr SDL_GetDefaultLogOutputFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetLogOutputFunction([NativeTypeName("SDL_LogOutputFunction *")] IntPtr* callback, void** userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetLogOutputFunction([NativeTypeName("SDL_LogOutputFunction")] IntPtr callback, void* userdata);
    }
}
