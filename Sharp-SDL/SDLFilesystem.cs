using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public enum SDL_Folder
    {
        SDL_FOLDER_HOME,
        SDL_FOLDER_DESKTOP,
        SDL_FOLDER_DOCUMENTS,
        SDL_FOLDER_DOWNLOADS,
        SDL_FOLDER_MUSIC,
        SDL_FOLDER_PICTURES,
        SDL_FOLDER_PUBLICSHARE,
        SDL_FOLDER_SAVEDGAMES,
        SDL_FOLDER_SCREENSHOTS,
        SDL_FOLDER_TEMPLATES,
        SDL_FOLDER_VIDEOS,
        SDL_FOLDER_COUNT,
    }

    public enum SDL_PathType
    {
        SDL_PATHTYPE_NONE,
        SDL_PATHTYPE_FILE,
        SDL_PATHTYPE_DIRECTORY,
        SDL_PATHTYPE_OTHER,
    }

    public partial struct SDL_PathInfo
    {
        public SDL_PathType type;

        [NativeTypeName("Uint64")]
        public ulong size;

        [NativeTypeName("SDL_Time")]
        public long create_time;

        [NativeTypeName("SDL_Time")]
        public long modify_time;

        [NativeTypeName("SDL_Time")]
        public long access_time;
    }

    public enum SDL_EnumerationResult
    {
        SDL_ENUM_CONTINUE,
        SDL_ENUM_SUCCESS,
        SDL_ENUM_FAILURE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate SDL_EnumerationResult SDL_EnumerateDirectoryCallback(void* userdata, [NativeTypeName("const char *")] sbyte* dirname, [NativeTypeName("const char *")] sbyte* fname);

    public static unsafe partial class SDLFilesystem
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetBasePath();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetPrefPath([NativeTypeName("const char *")] sbyte* org, [NativeTypeName("const char *")] sbyte* app);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetUserFolder(SDL_Folder folder);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CreateDirectory([NativeTypeName("const char *")] sbyte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_EnumerateDirectory([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("SDL_EnumerateDirectoryCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RemovePath([NativeTypeName("const char *")] sbyte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenamePath([NativeTypeName("const char *")] sbyte* oldpath, [NativeTypeName("const char *")] sbyte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CopyFile([NativeTypeName("const char *")] sbyte* oldpath, [NativeTypeName("const char *")] sbyte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetPathInfo([NativeTypeName("const char *")] sbyte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** SDL_GlobDirectory([NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* pattern, [NativeTypeName("SDL_GlobFlags")] uint flags, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetCurrentDirectory();

        [NativeTypeName("#define SDL_GLOB_CASEINSENSITIVE (1u << 0)")]
        public const uint SDL_GLOB_CASEINSENSITIVE = (1U << 0);
    }
}
