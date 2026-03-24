using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_StorageInterface
    {
        [NativeTypeName("Uint32")]
        public uint version;

        [NativeTypeName("bool (*)(void *) __attribute__((cdecl))")]
        public IntPtr close;

        [NativeTypeName("bool (*)(void *) __attribute__((cdecl))")]
        public IntPtr ready;

        [NativeTypeName("bool (*)(void *, const char *, SDL_EnumerateDirectoryCallback, void *) __attribute__((cdecl))")]
        public IntPtr enumerate;

        [NativeTypeName("bool (*)(void *, const char *, SDL_PathInfo *) __attribute__((cdecl))")]
        public IntPtr info;

        [NativeTypeName("bool (*)(void *, const char *, void *, Uint64) __attribute__((cdecl))")]
        public IntPtr read_file;

        [NativeTypeName("bool (*)(void *, const char *, const void *, Uint64) __attribute__((cdecl))")]
        public IntPtr write_file;

        [NativeTypeName("bool (*)(void *, const char *) __attribute__((cdecl))")]
        public IntPtr mkdir;

        [NativeTypeName("bool (*)(void *, const char *) __attribute__((cdecl))")]
        public IntPtr remove;

        [NativeTypeName("bool (*)(void *, const char *, const char *) __attribute__((cdecl))")]
        public IntPtr rename;

        [NativeTypeName("bool (*)(void *, const char *, const char *) __attribute__((cdecl))")]
        public IntPtr copy;

        [NativeTypeName("Uint64 (*)(void *) __attribute__((cdecl))")]
        public IntPtr space_remaining;
    }

    public partial struct SDL_Storage
    {
    }

    public static unsafe partial class SDLStorage
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenTitleStorage([NativeTypeName("const char *")] sbyte* @override, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenUserStorage([NativeTypeName("const char *")] sbyte* org, [NativeTypeName("const char *")] sbyte* app, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenFileStorage([NativeTypeName("const char *")] sbyte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Storage* SDL_OpenStorage([NativeTypeName("const SDL_StorageInterface *")] SDL_StorageInterface* iface, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CloseStorage(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_StorageReady(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetStorageFileSize(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("Uint64 *")] ulong* length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ReadStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* path, void* destination, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WriteStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const void *")] void* source, [NativeTypeName("Uint64")] ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CreateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_EnumerateStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("SDL_EnumerateDirectoryCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RemoveStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenameStoragePath(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* oldpath, [NativeTypeName("const char *")] sbyte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CopyStorageFile(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* oldpath, [NativeTypeName("const char *")] sbyte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetStoragePathInfo(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetStorageSpaceRemaining(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** SDL_GlobStorageDirectory(SDL_Storage* storage, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("const char *")] sbyte* pattern, [NativeTypeName("SDL_GlobFlags")] uint flags, int* count);
    }
}
