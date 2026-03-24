using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public unsafe partial struct SDL_DialogFileFilter
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* pattern;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_DialogFileCallback(void* userdata, [NativeTypeName("const char *const *")] sbyte** filelist, int filter);

    public enum SDL_FileDialogType
    {
        SDL_FILEDIALOG_OPENFILE,
        SDL_FILEDIALOG_SAVEFILE,
        SDL_FILEDIALOG_OPENFOLDER,
    }

    public static unsafe partial class SDLDialog
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ShowOpenFileDialog([NativeTypeName("SDL_DialogFileCallback")] IntPtr callback, void* userdata, SDL_Window* window, [NativeTypeName("const SDL_DialogFileFilter *")] SDL_DialogFileFilter* filters, int nfilters, [NativeTypeName("const char *")] sbyte* default_location, [NativeTypeName("bool")] byte allow_many);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ShowSaveFileDialog([NativeTypeName("SDL_DialogFileCallback")] IntPtr callback, void* userdata, SDL_Window* window, [NativeTypeName("const SDL_DialogFileFilter *")] SDL_DialogFileFilter* filters, int nfilters, [NativeTypeName("const char *")] sbyte* default_location);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ShowOpenFolderDialog([NativeTypeName("SDL_DialogFileCallback")] IntPtr callback, void* userdata, SDL_Window* window, [NativeTypeName("const char *")] sbyte* default_location, [NativeTypeName("bool")] byte allow_many);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ShowFileDialogWithProperties(SDL_FileDialogType type, [NativeTypeName("SDL_DialogFileCallback")] IntPtr callback, void* userdata, [NativeTypeName("SDL_PropertiesID")] uint props);

        [NativeTypeName("#define SDL_PROP_FILE_DIALOG_FILTERS_POINTER \"SDL.filedialog.filters\"")]
        public static ReadOnlySpan<byte> SDL_PROP_FILE_DIALOG_FILTERS_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x66, 0x69, 0x6C, 0x65, 0x64, 0x69, 0x61, 0x6C, 0x6F, 0x67, 0x2E, 0x66, 0x69, 0x6C, 0x74, 0x65, 0x72, 0x73, 0x00 };

        [NativeTypeName("#define SDL_PROP_FILE_DIALOG_NFILTERS_NUMBER \"SDL.filedialog.nfilters\"")]
        public static ReadOnlySpan<byte> SDL_PROP_FILE_DIALOG_NFILTERS_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x66, 0x69, 0x6C, 0x65, 0x64, 0x69, 0x61, 0x6C, 0x6F, 0x67, 0x2E, 0x6E, 0x66, 0x69, 0x6C, 0x74, 0x65, 0x72, 0x73, 0x00 };

        [NativeTypeName("#define SDL_PROP_FILE_DIALOG_WINDOW_POINTER \"SDL.filedialog.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_FILE_DIALOG_WINDOW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x66, 0x69, 0x6C, 0x65, 0x64, 0x69, 0x61, 0x6C, 0x6F, 0x67, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_FILE_DIALOG_LOCATION_STRING \"SDL.filedialog.location\"")]
        public static ReadOnlySpan<byte> SDL_PROP_FILE_DIALOG_LOCATION_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x66, 0x69, 0x6C, 0x65, 0x64, 0x69, 0x61, 0x6C, 0x6F, 0x67, 0x2E, 0x6C, 0x6F, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_FILE_DIALOG_MANY_BOOLEAN \"SDL.filedialog.many\"")]
        public static ReadOnlySpan<byte> SDL_PROP_FILE_DIALOG_MANY_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x66, 0x69, 0x6C, 0x65, 0x64, 0x69, 0x61, 0x6C, 0x6F, 0x67, 0x2E, 0x6D, 0x61, 0x6E, 0x79, 0x00 };

        [NativeTypeName("#define SDL_PROP_FILE_DIALOG_TITLE_STRING \"SDL.filedialog.title\"")]
        public static ReadOnlySpan<byte> SDL_PROP_FILE_DIALOG_TITLE_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x66, 0x69, 0x6C, 0x65, 0x64, 0x69, 0x61, 0x6C, 0x6F, 0x67, 0x2E, 0x74, 0x69, 0x74, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_FILE_DIALOG_ACCEPT_STRING \"SDL.filedialog.accept\"")]
        public static ReadOnlySpan<byte> SDL_PROP_FILE_DIALOG_ACCEPT_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x66, 0x69, 0x6C, 0x65, 0x64, 0x69, 0x61, 0x6C, 0x6F, 0x67, 0x2E, 0x61, 0x63, 0x63, 0x65, 0x70, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_FILE_DIALOG_CANCEL_STRING \"SDL.filedialog.cancel\"")]
        public static ReadOnlySpan<byte> SDL_PROP_FILE_DIALOG_CANCEL_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x66, 0x69, 0x6C, 0x65, 0x64, 0x69, 0x61, 0x6C, 0x6F, 0x67, 0x2E, 0x63, 0x61, 0x6E, 0x63, 0x65, 0x6C, 0x00 };
    }
}
