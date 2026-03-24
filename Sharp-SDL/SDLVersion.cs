using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public static unsafe partial class SDLVersion
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetVersion();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetRevision();

        [NativeTypeName("#define SDL_MAJOR_VERSION 3")]
        public const int SDL_MAJOR_VERSION = 3;

        [NativeTypeName("#define SDL_MINOR_VERSION 4")]
        public const int SDL_MINOR_VERSION = 4;

        [NativeTypeName("#define SDL_MICRO_VERSION 2")]
        public const int SDL_MICRO_VERSION = 2;

        [NativeTypeName("#define SDL_VERSION SDL_VERSIONNUM(SDL_MAJOR_VERSION, SDL_MINOR_VERSION, SDL_MICRO_VERSION)")]
        public const int SDL_VERSION = ((3) * 1000000 + (4) * 1000 + (2));
    }
}
