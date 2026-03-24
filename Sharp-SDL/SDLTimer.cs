using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("Uint32")]
    public unsafe delegate uint SDL_TimerCallback(void* userdata, [NativeTypeName("SDL_TimerID")] uint timerID, [NativeTypeName("Uint32")] uint interval);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("Uint64")]
    public unsafe delegate ulong SDL_NSTimerCallback(void* userdata, [NativeTypeName("SDL_TimerID")] uint timerID, [NativeTypeName("Uint64")] ulong interval);

    public static unsafe partial class SDLTimer
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetTicks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetTicksNS();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetPerformanceCounter();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetPerformanceFrequency();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_Delay([NativeTypeName("Uint32")] uint ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DelayNS([NativeTypeName("Uint64")] ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DelayPrecise([NativeTypeName("Uint64")] ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_TimerID")]
        public static extern uint SDL_AddTimer([NativeTypeName("Uint32")] uint interval, [NativeTypeName("SDL_TimerCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_TimerID")]
        public static extern uint SDL_AddTimerNS([NativeTypeName("Uint64")] ulong interval, [NativeTypeName("SDL_NSTimerCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RemoveTimer([NativeTypeName("SDL_TimerID")] uint id);

        [NativeTypeName("#define SDL_MS_PER_SECOND 1000")]
        public const int SDL_MS_PER_SECOND = 1000;

        [NativeTypeName("#define SDL_US_PER_SECOND 1000000")]
        public const int SDL_US_PER_SECOND = 1000000;

        [NativeTypeName("#define SDL_NS_PER_SECOND 1000000000LL")]
        public const long SDL_NS_PER_SECOND = 1000000000L;

        [NativeTypeName("#define SDL_NS_PER_MS 1000000")]
        public const int SDL_NS_PER_MS = 1000000;

        [NativeTypeName("#define SDL_NS_PER_US 1000")]
        public const int SDL_NS_PER_US = 1000;
    }
}
