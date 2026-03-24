using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public enum SDL_AppResult
    {
        SDL_APP_CONTINUE,
        SDL_APP_SUCCESS,
        SDL_APP_FAILURE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate SDL_AppResult SDL_AppInit_func(void** appstate, int argc, [NativeTypeName("char *[]")] sbyte** argv);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate SDL_AppResult SDL_AppIterate_func(void* appstate);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate SDL_AppResult SDL_AppEvent_func(void* appstate, SDL_Event* @event);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_AppQuit_func(void* appstate, SDL_AppResult result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_MainThreadCallback(void* userdata);

    public static unsafe partial class SDLInit
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_Init([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_InitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_QuitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_InitFlags")]
        public static extern uint SDL_WasInit([NativeTypeName("SDL_InitFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_Quit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_IsMainThread();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RunOnMainThread([NativeTypeName("SDL_MainThreadCallback")] IntPtr callback, void* userdata, [NativeTypeName("bool")] byte wait_complete);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAppMetadata([NativeTypeName("const char *")] sbyte* appname, [NativeTypeName("const char *")] sbyte* appversion, [NativeTypeName("const char *")] sbyte* appidentifier);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAppMetadataProperty([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetAppMetadataProperty([NativeTypeName("const char *")] sbyte* name);

        [NativeTypeName("#define SDL_INIT_AUDIO 0x00000010u")]
        public const uint SDL_INIT_AUDIO = 0x00000010U;

        [NativeTypeName("#define SDL_INIT_VIDEO 0x00000020u")]
        public const uint SDL_INIT_VIDEO = 0x00000020U;

        [NativeTypeName("#define SDL_INIT_JOYSTICK 0x00000200u")]
        public const uint SDL_INIT_JOYSTICK = 0x00000200U;

        [NativeTypeName("#define SDL_INIT_HAPTIC 0x00001000u")]
        public const uint SDL_INIT_HAPTIC = 0x00001000U;

        [NativeTypeName("#define SDL_INIT_GAMEPAD 0x00002000u")]
        public const uint SDL_INIT_GAMEPAD = 0x00002000U;

        [NativeTypeName("#define SDL_INIT_EVENTS 0x00004000u")]
        public const uint SDL_INIT_EVENTS = 0x00004000U;

        [NativeTypeName("#define SDL_INIT_SENSOR 0x00008000u")]
        public const uint SDL_INIT_SENSOR = 0x00008000U;

        [NativeTypeName("#define SDL_INIT_CAMERA 0x00010000u")]
        public const uint SDL_INIT_CAMERA = 0x00010000U;

        [NativeTypeName("#define SDL_PROP_APP_METADATA_NAME_STRING \"SDL.app.metadata.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x61, 0x70, 0x70, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x64, 0x61, 0x74, 0x61, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_APP_METADATA_VERSION_STRING \"SDL.app.metadata.version\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_VERSION_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x61, 0x70, 0x70, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x64, 0x61, 0x74, 0x61, 0x2E, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_APP_METADATA_IDENTIFIER_STRING \"SDL.app.metadata.identifier\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_IDENTIFIER_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x61, 0x70, 0x70, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x64, 0x61, 0x74, 0x61, 0x2E, 0x69, 0x64, 0x65, 0x6E, 0x74, 0x69, 0x66, 0x69, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_APP_METADATA_CREATOR_STRING \"SDL.app.metadata.creator\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_CREATOR_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x61, 0x70, 0x70, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x64, 0x61, 0x74, 0x61, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x6F, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_APP_METADATA_COPYRIGHT_STRING \"SDL.app.metadata.copyright\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_COPYRIGHT_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x61, 0x70, 0x70, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x64, 0x61, 0x74, 0x61, 0x2E, 0x63, 0x6F, 0x70, 0x79, 0x72, 0x69, 0x67, 0x68, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_APP_METADATA_URL_STRING \"SDL.app.metadata.url\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_URL_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x61, 0x70, 0x70, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x64, 0x61, 0x74, 0x61, 0x2E, 0x75, 0x72, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_APP_METADATA_TYPE_STRING \"SDL.app.metadata.type\"")]
        public static ReadOnlySpan<byte> SDL_PROP_APP_METADATA_TYPE_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x61, 0x70, 0x70, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x64, 0x61, 0x74, 0x61, 0x2E, 0x74, 0x79, 0x70, 0x65, 0x00 };
    }
}
