using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public unsafe partial struct SDL_Locale
    {
        [NativeTypeName("const char *")]
        public sbyte* language;

        [NativeTypeName("const char *")]
        public sbyte* country;
    }

    public static unsafe partial class SDLLocale
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Locale** SDL_GetPreferredLocales(int* count);
    }
}
