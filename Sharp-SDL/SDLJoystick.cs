using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Joystick
    {
    }

    public enum SDL_JoystickType
    {
        SDL_JOYSTICK_TYPE_UNKNOWN,
        SDL_JOYSTICK_TYPE_GAMEPAD,
        SDL_JOYSTICK_TYPE_WHEEL,
        SDL_JOYSTICK_TYPE_ARCADE_STICK,
        SDL_JOYSTICK_TYPE_FLIGHT_STICK,
        SDL_JOYSTICK_TYPE_DANCE_PAD,
        SDL_JOYSTICK_TYPE_GUITAR,
        SDL_JOYSTICK_TYPE_DRUM_KIT,
        SDL_JOYSTICK_TYPE_ARCADE_PAD,
        SDL_JOYSTICK_TYPE_THROTTLE,
        SDL_JOYSTICK_TYPE_COUNT,
    }

    public enum SDL_JoystickConnectionState
    {
        SDL_JOYSTICK_CONNECTION_INVALID = -1,
        SDL_JOYSTICK_CONNECTION_UNKNOWN,
        SDL_JOYSTICK_CONNECTION_WIRED,
        SDL_JOYSTICK_CONNECTION_WIRELESS,
    }

    public unsafe partial struct SDL_VirtualJoystickTouchpadDesc
    {
        [NativeTypeName("Uint16")]
        public ushort nfingers;

        [NativeTypeName("Uint16[3]")]
        public fixed ushort padding[3];
    }

    public partial struct SDL_VirtualJoystickSensorDesc
    {
        public SDL_SensorType type;

        public float rate;
    }

    public unsafe partial struct SDL_VirtualJoystickDesc
    {
        [NativeTypeName("Uint32")]
        public uint version;

        [NativeTypeName("Uint16")]
        public ushort type;

        [NativeTypeName("Uint16")]
        public ushort padding;

        [NativeTypeName("Uint16")]
        public ushort vendor_id;

        [NativeTypeName("Uint16")]
        public ushort product_id;

        [NativeTypeName("Uint16")]
        public ushort naxes;

        [NativeTypeName("Uint16")]
        public ushort nbuttons;

        [NativeTypeName("Uint16")]
        public ushort nballs;

        [NativeTypeName("Uint16")]
        public ushort nhats;

        [NativeTypeName("Uint16")]
        public ushort ntouchpads;

        [NativeTypeName("Uint16")]
        public ushort nsensors;

        [NativeTypeName("Uint16[2]")]
        public fixed ushort padding2[2];

        [NativeTypeName("Uint32")]
        public uint button_mask;

        [NativeTypeName("Uint32")]
        public uint axis_mask;

        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const SDL_VirtualJoystickTouchpadDesc *")]
        public SDL_VirtualJoystickTouchpadDesc* touchpads;

        [NativeTypeName("const SDL_VirtualJoystickSensorDesc *")]
        public SDL_VirtualJoystickSensorDesc* sensors;

        public void* userdata;

        [NativeTypeName("void (*)(void *) __attribute__((cdecl))")]
        public IntPtr Update;

        [NativeTypeName("void (*)(void *, int) __attribute__((cdecl))")]
        public IntPtr SetPlayerIndex;

        [NativeTypeName("bool (*)(void *, Uint16, Uint16) __attribute__((cdecl))")]
        public IntPtr Rumble;

        [NativeTypeName("bool (*)(void *, Uint16, Uint16) __attribute__((cdecl))")]
        public IntPtr RumbleTriggers;

        [NativeTypeName("bool (*)(void *, Uint8, Uint8, Uint8) __attribute__((cdecl))")]
        public IntPtr SetLED;

        [NativeTypeName("bool (*)(void *, const void *, int) __attribute__((cdecl))")]
        public IntPtr SendEffect;

        [NativeTypeName("bool (*)(void *, bool) __attribute__((cdecl))")]
        public IntPtr SetSensorsEnabled;

        [NativeTypeName("void (*)(void *) __attribute__((cdecl))")]
        public IntPtr Cleanup;
    }

    public static unsafe partial class SDLJoystick
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasJoystick();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID *")]
        public static extern uint* SDL_GetJoysticks(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetJoystickNameForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetJoystickPathForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetJoystickPlayerIndexForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GUID SDL_GetJoystickGUIDForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickVendorForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickProductForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickProductVersionForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickType SDL_GetJoystickTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Joystick* SDL_OpenJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Joystick* SDL_GetJoystickFromID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Joystick* SDL_GetJoystickFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        public static extern uint SDL_AttachVirtualJoystick([NativeTypeName("const SDL_VirtualJoystickDesc *")] SDL_VirtualJoystickDesc* desc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_DetachVirtualJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_IsJoystickVirtual([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16")] short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetJoystickVirtualBall(SDL_Joystick* joystick, int ball, [NativeTypeName("Sint16")] short xrel, [NativeTypeName("Sint16")] short yrel);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetJoystickVirtualButton(SDL_Joystick* joystick, int button, [NativeTypeName("bool")] byte down);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, [NativeTypeName("Uint8")] byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger, [NativeTypeName("bool")] byte down, float x, float y, float pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type, [NativeTypeName("Uint64")] ulong sensor_timestamp, [NativeTypeName("const float *")] float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetJoystickProperties(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetJoystickName(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetJoystickPath(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetJoystickPlayerIndex(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GUID SDL_GetJoystickGUID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickVendor(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickProduct(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickProductVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetJoystickFirmwareVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetJoystickSerial(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickType SDL_GetJoystickType(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetJoystickGUIDInfo(SDL_GUID guid, [NativeTypeName("Uint16 *")] ushort* vendor, [NativeTypeName("Uint16 *")] ushort* product, [NativeTypeName("Uint16 *")] ushort* version, [NativeTypeName("Uint16 *")] ushort* crc16);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_JoystickConnected(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        public static extern uint SDL_GetJoystickID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumJoystickAxes(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumJoystickBalls(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumJoystickHats(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumJoystickButtons(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetJoystickEventsEnabled([NativeTypeName("bool")] byte enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_JoystickEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UpdateJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint16")]
        public static extern short SDL_GetJoystickAxis(SDL_Joystick* joystick, int axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, [NativeTypeName("Sint16 *")] short* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetJoystickBall(SDL_Joystick* joystick, int ball, int* dx, int* dy);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint8")]
        public static extern byte SDL_GetJoystickHat(SDL_Joystick* joystick, int hat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetJoystickButton(SDL_Joystick* joystick, int button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RumbleJoystick(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RumbleJoystickTriggers(SDL_Joystick* joystick, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetJoystickLED(SDL_Joystick* joystick, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SendJoystickEffect(SDL_Joystick* joystick, [NativeTypeName("const void *")] void* data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickConnectionState SDL_GetJoystickConnectionState(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PowerState SDL_GetJoystickPowerInfo(SDL_Joystick* joystick, int* percent);

        [NativeTypeName("#define SDL_JOYSTICK_AXIS_MAX 32767")]
        public const int SDL_JOYSTICK_AXIS_MAX = 32767;

        [NativeTypeName("#define SDL_JOYSTICK_AXIS_MIN -32768")]
        public const int SDL_JOYSTICK_AXIS_MIN = -32768;

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN \"SDL.joystick.cap.mono_led\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x6D, 0x6F, 0x6E, 0x6F, 0x5F, 0x6C, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN \"SDL.joystick.cap.rgb_led\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x72, 0x67, 0x62, 0x5F, 0x6C, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN \"SDL.joystick.cap.player_led\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x70, 0x6C, 0x61, 0x79, 0x65, 0x72, 0x5F, 0x6C, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN \"SDL.joystick.cap.rumble\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x72, 0x75, 0x6D, 0x62, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN \"SDL.joystick.cap.trigger_rumble\"")]
        public static ReadOnlySpan<byte> SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x74, 0x72, 0x69, 0x67, 0x67, 0x65, 0x72, 0x5F, 0x72, 0x75, 0x6D, 0x62, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define SDL_HAT_CENTERED 0x00u")]
        public const uint SDL_HAT_CENTERED = 0x00U;

        [NativeTypeName("#define SDL_HAT_UP 0x01u")]
        public const uint SDL_HAT_UP = 0x01U;

        [NativeTypeName("#define SDL_HAT_RIGHT 0x02u")]
        public const uint SDL_HAT_RIGHT = 0x02U;

        [NativeTypeName("#define SDL_HAT_DOWN 0x04u")]
        public const uint SDL_HAT_DOWN = 0x04U;

        [NativeTypeName("#define SDL_HAT_LEFT 0x08u")]
        public const uint SDL_HAT_LEFT = 0x08U;

        [NativeTypeName("#define SDL_HAT_RIGHTUP (SDL_HAT_RIGHT|SDL_HAT_UP)")]
        public const uint SDL_HAT_RIGHTUP = (0x02U | 0x01U);

        [NativeTypeName("#define SDL_HAT_RIGHTDOWN (SDL_HAT_RIGHT|SDL_HAT_DOWN)")]
        public const uint SDL_HAT_RIGHTDOWN = (0x02U | 0x04U);

        [NativeTypeName("#define SDL_HAT_LEFTUP (SDL_HAT_LEFT|SDL_HAT_UP)")]
        public const uint SDL_HAT_LEFTUP = (0x08U | 0x01U);

        [NativeTypeName("#define SDL_HAT_LEFTDOWN (SDL_HAT_LEFT|SDL_HAT_DOWN)")]
        public const uint SDL_HAT_LEFTDOWN = (0x08U | 0x04U);
    }
}
