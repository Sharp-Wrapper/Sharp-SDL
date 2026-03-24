using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Thread
    {
    }

    public enum SDL_ThreadPriority
    {
        SDL_THREAD_PRIORITY_LOW,
        SDL_THREAD_PRIORITY_NORMAL,
        SDL_THREAD_PRIORITY_HIGH,
        SDL_THREAD_PRIORITY_TIME_CRITICAL,
    }

    public enum SDL_ThreadState
    {
        SDL_THREAD_UNKNOWN,
        SDL_THREAD_ALIVE,
        SDL_THREAD_DETACHED,
        SDL_THREAD_COMPLETE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SDL_ThreadFunction(void* data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_TLSDestructorCallback(void* value);

    public static unsafe partial class SDLThread
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Thread* SDL_CreateThreadRuntime([NativeTypeName("SDL_ThreadFunction")] IntPtr fn, [NativeTypeName("const char *")] sbyte* name, void* data, [NativeTypeName("SDL_FunctionPointer")] IntPtr pfnBeginThread, [NativeTypeName("SDL_FunctionPointer")] IntPtr pfnEndThread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Thread* SDL_CreateThreadWithPropertiesRuntime([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("SDL_FunctionPointer")] IntPtr pfnBeginThread, [NativeTypeName("SDL_FunctionPointer")] IntPtr pfnEndThread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetThreadName(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_ThreadID")]
        public static extern ulong SDL_GetCurrentThreadID();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_ThreadID")]
        public static extern ulong SDL_GetThreadID(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetCurrentThreadPriority(SDL_ThreadPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_WaitThread(SDL_Thread* thread, int* status);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_ThreadState SDL_GetThreadState(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DetachThread(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetTLS([NativeTypeName("SDL_TLSID *")] SDL_AtomicInt* id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetTLS([NativeTypeName("SDL_TLSID *")] SDL_AtomicInt* id, [NativeTypeName("const void *")] void* value, [NativeTypeName("SDL_TLSDestructorCallback")] IntPtr destructor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CleanupTLS();

        [NativeTypeName("#define SDL_PROP_THREAD_CREATE_ENTRY_FUNCTION_POINTER \"SDL.thread.create.entry_function\"")]
        public static ReadOnlySpan<byte> SDL_PROP_THREAD_CREATE_ENTRY_FUNCTION_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x68, 0x72, 0x65, 0x61, 0x64, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x65, 0x6E, 0x74, 0x72, 0x79, 0x5F, 0x66, 0x75, 0x6E, 0x63, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_THREAD_CREATE_NAME_STRING \"SDL.thread.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_THREAD_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x68, 0x72, 0x65, 0x61, 0x64, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_THREAD_CREATE_USERDATA_POINTER \"SDL.thread.create.userdata\"")]
        public static ReadOnlySpan<byte> SDL_PROP_THREAD_CREATE_USERDATA_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x68, 0x72, 0x65, 0x61, 0x64, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x75, 0x73, 0x65, 0x72, 0x64, 0x61, 0x74, 0x61, 0x00 };

        [NativeTypeName("#define SDL_PROP_THREAD_CREATE_STACKSIZE_NUMBER \"SDL.thread.create.stacksize\"")]
        public static ReadOnlySpan<byte> SDL_PROP_THREAD_CREATE_STACKSIZE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x68, 0x72, 0x65, 0x61, 0x64, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x73, 0x74, 0x61, 0x63, 0x6B, 0x73, 0x69, 0x7A, 0x65, 0x00 };
    }
}
