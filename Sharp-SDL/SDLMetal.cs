using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public static unsafe partial class SDLMetal
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_MetalView")]
        public static extern void* SDL_Metal_CreateView(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_Metal_DestroyView([NativeTypeName("SDL_MetalView")] void* view);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_Metal_GetLayer([NativeTypeName("SDL_MetalView")] void* view);
    }
}
