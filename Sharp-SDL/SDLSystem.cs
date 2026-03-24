using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct tagMSG
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool SDL_WindowsMessageHook(void* userdata, [NativeTypeName("MSG *")] tagMSG* msg);

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _XEvent
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate bool SDL_X11EventHook(void* userdata, [NativeTypeName("XEvent *")] _XEvent* xevent);

    public enum SDL_Sandbox
    {
        SDL_SANDBOX_NONE = 0,
        SDL_SANDBOX_UNKNOWN_CONTAINER,
        SDL_SANDBOX_FLATPAK,
        SDL_SANDBOX_SNAP,
        SDL_SANDBOX_MACOS,
    }

    public static unsafe partial class SDLSystem
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowsMessageHook([NativeTypeName("SDL_WindowsMessageHook")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDirect3D9AdapterIndex([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetDXGIOutputInfo([NativeTypeName("SDL_DisplayID")] uint displayID, int* adapterIndex, int* outputIndex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetX11EventHook([NativeTypeName("SDL_X11EventHook")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_IsTablet();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_IsTV();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Sandbox SDL_GetSandbox();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationWillTerminate();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationDidReceiveMemoryWarning();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationWillEnterBackground();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationDidEnterBackground();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationWillEnterForeground();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationDidEnterForeground();
    }
}
