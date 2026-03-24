using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public enum SDL_PropertyType
    {
        SDL_PROPERTY_TYPE_INVALID,
        SDL_PROPERTY_TYPE_POINTER,
        SDL_PROPERTY_TYPE_STRING,
        SDL_PROPERTY_TYPE_NUMBER,
        SDL_PROPERTY_TYPE_FLOAT,
        SDL_PROPERTY_TYPE_BOOLEAN,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_CleanupPropertyCallback(void* userdata, void* value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_EnumeratePropertiesCallback(void* userdata, [NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name);

    public static unsafe partial class SDLProperties
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetGlobalProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_CreateProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CopyProperties([NativeTypeName("SDL_PropertiesID")] uint src, [NativeTypeName("SDL_PropertiesID")] uint dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_LockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetPointerPropertyWithCleanup([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, void* value, [NativeTypeName("SDL_CleanupPropertyCallback")] IntPtr cleanup, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetPointerProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, void* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetStringProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetNumberProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("Sint64")] long value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetFloatProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, float value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetBooleanProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("bool")] byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PropertyType SDL_GetPropertyType([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetPointerProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, void* default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetStringProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern long SDL_GetNumberProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("Sint64")] long default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetFloatProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, float default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetBooleanProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("bool")] byte default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ClearProperty([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_EnumerateProperties([NativeTypeName("SDL_PropertiesID")] uint props, [NativeTypeName("SDL_EnumeratePropertiesCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [NativeTypeName("#define SDL_PROP_NAME_STRING \"SDL.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };
    }
}
