using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("const void *")]
    public unsafe delegate void* SDL_ClipboardDataCallback(void* userdata, [NativeTypeName("const char *")] sbyte* mime_type, [NativeTypeName("size_t *")] UIntPtr* size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_ClipboardCleanupCallback(void* userdata);

    public static unsafe partial class SDLClipboard
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetClipboardText([NativeTypeName("const char *")] sbyte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetPrimarySelectionText([NativeTypeName("const char *")] sbyte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetClipboardData([NativeTypeName("SDL_ClipboardDataCallback")] IntPtr callback, [NativeTypeName("SDL_ClipboardCleanupCallback")] IntPtr cleanup, void* userdata, [NativeTypeName("const char **")] sbyte** mime_types, [NativeTypeName("size_t")] UIntPtr num_mime_types);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ClearClipboardData();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetClipboardData([NativeTypeName("const char *")] sbyte* mime_type, [NativeTypeName("size_t *")] UIntPtr* size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasClipboardData([NativeTypeName("const char *")] sbyte* mime_type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** SDL_GetClipboardMimeTypes([NativeTypeName("size_t *")] UIntPtr* num_mime_types);
    }
}
