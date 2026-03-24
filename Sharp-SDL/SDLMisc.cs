using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public static unsafe partial class SDLMisc
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_OpenURL([NativeTypeName("const char *")] sbyte* url);
    }
}
