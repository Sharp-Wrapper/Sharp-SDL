using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public enum SDL_AssertState
    {
        SDL_ASSERTION_RETRY,
        SDL_ASSERTION_BREAK,
        SDL_ASSERTION_ABORT,
        SDL_ASSERTION_IGNORE,
        SDL_ASSERTION_ALWAYS_IGNORE,
    }

    public unsafe partial struct SDL_AssertData
    {
        [NativeTypeName("bool")]
        public byte always_ignore;

        [NativeTypeName("unsigned int")]
        public uint trigger_count;

        [NativeTypeName("const char *")]
        public sbyte* condition;

        [NativeTypeName("const char *")]
        public sbyte* filename;

        public int linenum;

        [NativeTypeName("const char *")]
        public sbyte* function;

        [NativeTypeName("const struct SDL_AssertData *")]
        public SDL_AssertData* next;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate SDL_AssertState SDL_AssertionHandler([NativeTypeName("const SDL_AssertData *")] SDL_AssertData* data, void* userdata);

    public static unsafe partial class SDLAssert
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetAssertionHandler([NativeTypeName("SDL_AssertionHandler")] IntPtr handler, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_AssertionHandler")]
        public static extern IntPtr SDL_GetDefaultAssertionHandler();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_AssertionHandler")]
        public static extern IntPtr SDL_GetAssertionHandler(void** puserdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const SDL_AssertData *")]
        public static extern SDL_AssertData* SDL_GetAssertionReport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ResetAssertionReport();

        [NativeTypeName("#define SDL_ASSERT_LEVEL 1")]
        public const int SDL_ASSERT_LEVEL = 1;

        [NativeTypeName("#define SDL_LINE __LINE__")]
        public const int SDL_LINE = 701;
    }
}
