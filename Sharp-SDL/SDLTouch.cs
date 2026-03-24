using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public enum SDL_TouchDeviceType
    {
        SDL_TOUCH_DEVICE_INVALID = -1,
        SDL_TOUCH_DEVICE_DIRECT,
        SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE,
        SDL_TOUCH_DEVICE_INDIRECT_RELATIVE,
    }

    public partial struct SDL_Finger
    {
        [NativeTypeName("SDL_FingerID")]
        public ulong id;

        public float x;

        public float y;

        public float pressure;
    }

    public static unsafe partial class SDLTouch
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_TouchID *")]
        public static extern ulong* SDL_GetTouchDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetTouchDeviceName([NativeTypeName("SDL_TouchID")] ulong touchID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_TouchDeviceType SDL_GetTouchDeviceType([NativeTypeName("SDL_TouchID")] ulong touchID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Finger** SDL_GetTouchFingers([NativeTypeName("SDL_TouchID")] ulong touchID, int* count);

        [NativeTypeName("#define SDL_TOUCH_MOUSEID ((SDL_MouseID)-1)")]
        public const uint SDL_TOUCH_MOUSEID = unchecked((uint)(-1));

        [NativeTypeName("#define SDL_MOUSE_TOUCHID ((SDL_TouchID)-1)")]
        public const ulong SDL_MOUSE_TOUCHID = unchecked((ulong)(-1));
    }
}
