using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_SharedObject
    {
    }

    public static unsafe partial class SDLLoadSo
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_SharedObject* SDL_LoadObject([NativeTypeName("const char *")] sbyte* sofile);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_FunctionPointer")]
        public static extern IntPtr SDL_LoadFunction(SDL_SharedObject* handle, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnloadObject(SDL_SharedObject* handle);
    }
}
