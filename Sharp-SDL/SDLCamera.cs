using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Camera
    {
    }

    public partial struct SDL_CameraSpec
    {
        public SDL_PixelFormat format;

        public SDL_Colorspace colorspace;

        public int width;

        public int height;

        public int framerate_numerator;

        public int framerate_denominator;
    }

    public enum SDL_CameraPosition
    {
        SDL_CAMERA_POSITION_UNKNOWN,
        SDL_CAMERA_POSITION_FRONT_FACING,
        SDL_CAMERA_POSITION_BACK_FACING,
    }

    public enum SDL_CameraPermissionState
    {
        SDL_CAMERA_PERMISSION_STATE_DENIED = -1,
        SDL_CAMERA_PERMISSION_STATE_PENDING,
        SDL_CAMERA_PERMISSION_STATE_APPROVED,
    }

    public static unsafe partial class SDLCamera
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumCameraDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetCameraDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetCurrentCameraDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_CameraID *")]
        public static extern uint* SDL_GetCameras(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_CameraSpec** SDL_GetCameraSupportedFormats([NativeTypeName("SDL_CameraID")] uint instance_id, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetCameraName([NativeTypeName("SDL_CameraID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_CameraPosition SDL_GetCameraPosition([NativeTypeName("SDL_CameraID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Camera* SDL_OpenCamera([NativeTypeName("SDL_CameraID")] uint instance_id, [NativeTypeName("const SDL_CameraSpec *")] SDL_CameraSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_CameraPermissionState SDL_GetCameraPermissionState(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_CameraID")]
        public static extern uint SDL_GetCameraID(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetCameraProperties(SDL_Camera* camera);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetCameraFormat(SDL_Camera* camera, SDL_CameraSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_AcquireCameraFrame(SDL_Camera* camera, [NativeTypeName("Uint64 *")] ulong* timestampNS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseCameraFrame(SDL_Camera* camera, SDL_Surface* frame);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseCamera(SDL_Camera* camera);
    }
}
