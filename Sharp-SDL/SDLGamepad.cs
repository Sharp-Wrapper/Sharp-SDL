using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Gamepad
    {
    }

    public enum SDL_GamepadType
    {
        SDL_GAMEPAD_TYPE_UNKNOWN = 0,
        SDL_GAMEPAD_TYPE_STANDARD,
        SDL_GAMEPAD_TYPE_XBOX360,
        SDL_GAMEPAD_TYPE_XBOXONE,
        SDL_GAMEPAD_TYPE_PS3,
        SDL_GAMEPAD_TYPE_PS4,
        SDL_GAMEPAD_TYPE_PS5,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_PRO,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_LEFT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_PAIR,
        SDL_GAMEPAD_TYPE_GAMECUBE,
        SDL_GAMEPAD_TYPE_COUNT,
    }

    public enum SDL_GamepadButton
    {
        SDL_GAMEPAD_BUTTON_INVALID = -1,
        SDL_GAMEPAD_BUTTON_SOUTH,
        SDL_GAMEPAD_BUTTON_EAST,
        SDL_GAMEPAD_BUTTON_WEST,
        SDL_GAMEPAD_BUTTON_NORTH,
        SDL_GAMEPAD_BUTTON_BACK,
        SDL_GAMEPAD_BUTTON_GUIDE,
        SDL_GAMEPAD_BUTTON_START,
        SDL_GAMEPAD_BUTTON_LEFT_STICK,
        SDL_GAMEPAD_BUTTON_RIGHT_STICK,
        SDL_GAMEPAD_BUTTON_LEFT_SHOULDER,
        SDL_GAMEPAD_BUTTON_RIGHT_SHOULDER,
        SDL_GAMEPAD_BUTTON_DPAD_UP,
        SDL_GAMEPAD_BUTTON_DPAD_DOWN,
        SDL_GAMEPAD_BUTTON_DPAD_LEFT,
        SDL_GAMEPAD_BUTTON_DPAD_RIGHT,
        SDL_GAMEPAD_BUTTON_MISC1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE1,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE2,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE2,
        SDL_GAMEPAD_BUTTON_TOUCHPAD,
        SDL_GAMEPAD_BUTTON_MISC2,
        SDL_GAMEPAD_BUTTON_MISC3,
        SDL_GAMEPAD_BUTTON_MISC4,
        SDL_GAMEPAD_BUTTON_MISC5,
        SDL_GAMEPAD_BUTTON_MISC6,
        SDL_GAMEPAD_BUTTON_COUNT,
    }

    public enum SDL_GamepadButtonLabel
    {
        SDL_GAMEPAD_BUTTON_LABEL_UNKNOWN,
        SDL_GAMEPAD_BUTTON_LABEL_A,
        SDL_GAMEPAD_BUTTON_LABEL_B,
        SDL_GAMEPAD_BUTTON_LABEL_X,
        SDL_GAMEPAD_BUTTON_LABEL_Y,
        SDL_GAMEPAD_BUTTON_LABEL_CROSS,
        SDL_GAMEPAD_BUTTON_LABEL_CIRCLE,
        SDL_GAMEPAD_BUTTON_LABEL_SQUARE,
        SDL_GAMEPAD_BUTTON_LABEL_TRIANGLE,
    }

    public enum SDL_GamepadAxis
    {
        SDL_GAMEPAD_AXIS_INVALID = -1,
        SDL_GAMEPAD_AXIS_LEFTX,
        SDL_GAMEPAD_AXIS_LEFTY,
        SDL_GAMEPAD_AXIS_RIGHTX,
        SDL_GAMEPAD_AXIS_RIGHTY,
        SDL_GAMEPAD_AXIS_LEFT_TRIGGER,
        SDL_GAMEPAD_AXIS_RIGHT_TRIGGER,
        SDL_GAMEPAD_AXIS_COUNT,
    }

    public enum SDL_GamepadBindingType
    {
        SDL_GAMEPAD_BINDTYPE_NONE = 0,
        SDL_GAMEPAD_BINDTYPE_BUTTON,
        SDL_GAMEPAD_BINDTYPE_AXIS,
        SDL_GAMEPAD_BINDTYPE_HAT,
    }

    public partial struct SDL_GamepadBinding
    {
        public SDL_GamepadBindingType input_type;

        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L270_C5")]
        public _input_e__Union input;

        public SDL_GamepadBindingType output_type;

        [NativeTypeName("__AnonymousRecord_SDL_gamepad_L290_C5")]
        public _output_e__Union output;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _input_e__Union
        {
            [FieldOffset(0)]
            public int button;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_gamepad_L274_C9")]
            public _axis_e__Struct axis;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_gamepad_L281_C9")]
            public _hat_e__Struct hat;

            public partial struct _axis_e__Struct
            {
                public int axis;

                public int axis_min;

                public int axis_max;
            }

            public partial struct _hat_e__Struct
            {
                public int hat;

                public int hat_mask;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _output_e__Union
        {
            [FieldOffset(0)]
            public SDL_GamepadButton button;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_SDL_gamepad_L294_C9")]
            public _axis_e__Struct axis;

            public partial struct _axis_e__Struct
            {
                public SDL_GamepadAxis axis;

                public int axis_min;

                public int axis_max;
            }
        }
    }

    public static unsafe partial class SDLGamepad
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddGamepadMapping([NativeTypeName("const char *")] sbyte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddGamepadMappingsFromIO(SDL_IOStream* src, [NativeTypeName("bool")] byte closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddGamepadMappingsFromFile([NativeTypeName("const char *")] sbyte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ReloadGamepadMappings();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** SDL_GetGamepadMappings(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetGamepadMappingForGUID(SDL_GUID guid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetGamepadMapping(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetGamepadMapping([NativeTypeName("SDL_JoystickID")] uint instance_id, [NativeTypeName("const char *")] sbyte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasGamepad();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID *")]
        public static extern uint* SDL_GetGamepads(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_IsGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadNameForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadPathForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadPlayerIndexForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GUID SDL_GetGamepadGUIDForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadVendorForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProductForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProductVersionForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetGamepadTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetRealGamepadTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_GetGamepadMappingForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Gamepad* SDL_OpenGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Gamepad* SDL_GetGamepadFromID([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Gamepad* SDL_GetGamepadFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetGamepadProperties(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_JoystickID")]
        public static extern uint SDL_GetGamepadID(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadName(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadPath(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetRealGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetGamepadPlayerIndex(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadVendor(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProduct(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadProductVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_GetGamepadFirmwareVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadSerial(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint64")]
        public static extern ulong SDL_GetGamepadSteamHandle(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickConnectionState SDL_GetGamepadConnectionState(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PowerState SDL_GetGamepadPowerInfo(SDL_Gamepad* gamepad, int* percent);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GamepadConnected(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Joystick* SDL_GetGamepadJoystick(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetGamepadEventsEnabled([NativeTypeName("bool")] byte enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GamepadEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadBinding** SDL_GetGamepadBindings(SDL_Gamepad* gamepad, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UpdateGamepads();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadType SDL_GetGamepadTypeFromString([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadStringForType(SDL_GamepadType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadAxis SDL_GetGamepadAxisFromString([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadStringForAxis(SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint16")]
        public static extern short SDL_GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadButton SDL_GetGamepadButtonFromString([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadStringForButton(SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadButtonLabel SDL_GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GamepadButtonLabel SDL_GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumGamepadTouchpads(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger, bool* down, float* x, float* y, float* pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, [NativeTypeName("bool")] byte enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RumbleGamepad(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort low_frequency_rumble, [NativeTypeName("Uint16")] ushort high_frequency_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RumbleGamepadTriggers(SDL_Gamepad* gamepad, [NativeTypeName("Uint16")] ushort left_rumble, [NativeTypeName("Uint16")] ushort right_rumble, [NativeTypeName("Uint32")] uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetGamepadLED(SDL_Gamepad* gamepad, [NativeTypeName("Uint8")] byte red, [NativeTypeName("Uint8")] byte green, [NativeTypeName("Uint8")] byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SendGamepadEffect(SDL_Gamepad* gamepad, [NativeTypeName("const void *")] void* data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseGamepad(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_MONO_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_MONO_LED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x6D, 0x6F, 0x6E, 0x6F, 0x5F, 0x6C, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_RGB_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_RGB_LED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x72, 0x67, 0x62, 0x5F, 0x6C, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_PLAYER_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_PLAYER_LED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x70, 0x6C, 0x61, 0x79, 0x65, 0x72, 0x5F, 0x6C, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_RUMBLE_BOOLEAN SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_RUMBLE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x72, 0x75, 0x6D, 0x62, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GAMEPAD_CAP_TRIGGER_RUMBLE_BOOLEAN SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN")]
        public static ReadOnlySpan<byte> SDL_PROP_GAMEPAD_CAP_TRIGGER_RUMBLE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x6A, 0x6F, 0x79, 0x73, 0x74, 0x69, 0x63, 0x6B, 0x2E, 0x63, 0x61, 0x70, 0x2E, 0x74, 0x72, 0x69, 0x67, 0x67, 0x65, 0x72, 0x5F, 0x72, 0x75, 0x6D, 0x62, 0x6C, 0x65, 0x00 };
    }
}
