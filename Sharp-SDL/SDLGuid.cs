using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public unsafe partial struct SDL_GUID
    {
        [NativeTypeName("Uint8[16]")]
        public fixed byte data[16];
    }

    public static unsafe partial class SDLGuid
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GUIDToString(SDL_GUID guid, [NativeTypeName("char *")] sbyte* pszGUID, int cbGUID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GUID SDL_StringToGUID([NativeTypeName("const char *")] sbyte* pchGUID);
    }
}
