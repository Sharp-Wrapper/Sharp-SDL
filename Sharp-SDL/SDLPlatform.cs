using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public static unsafe partial class SDLPlatform
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetPlatform();
    }
}
