using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Haptic
    {
    }

    public unsafe partial struct SDL_HapticDirection
    {
        [NativeTypeName("SDL_HapticDirectionType")]
        public byte type;

        [NativeTypeName("Sint32[3]")]
        public fixed int dir[3];
    }

    public partial struct SDL_HapticConstant
    {
        [NativeTypeName("SDL_HapticEffectType")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Sint16")]
        public short level;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    public partial struct SDL_HapticPeriodic
    {
        [NativeTypeName("SDL_HapticEffectType")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Uint16")]
        public ushort period;

        [NativeTypeName("Sint16")]
        public short magnitude;

        [NativeTypeName("Sint16")]
        public short offset;

        [NativeTypeName("Uint16")]
        public ushort phase;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    public unsafe partial struct SDL_HapticCondition
    {
        [NativeTypeName("SDL_HapticEffectType")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Uint16[3]")]
        public fixed ushort right_sat[3];

        [NativeTypeName("Uint16[3]")]
        public fixed ushort left_sat[3];

        [NativeTypeName("Sint16[3]")]
        public fixed short right_coeff[3];

        [NativeTypeName("Sint16[3]")]
        public fixed short left_coeff[3];

        [NativeTypeName("Uint16[3]")]
        public fixed ushort deadband[3];

        [NativeTypeName("Sint16[3]")]
        public fixed short center[3];
    }

    public partial struct SDL_HapticRamp
    {
        [NativeTypeName("SDL_HapticEffectType")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Sint16")]
        public short start;

        [NativeTypeName("Sint16")]
        public short end;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    public partial struct SDL_HapticLeftRight
    {
        [NativeTypeName("SDL_HapticEffectType")]
        public ushort type;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort large_magnitude;

        [NativeTypeName("Uint16")]
        public ushort small_magnitude;
    }

    public unsafe partial struct SDL_HapticCustom
    {
        [NativeTypeName("SDL_HapticEffectType")]
        public ushort type;

        public SDL_HapticDirection direction;

        [NativeTypeName("Uint32")]
        public uint length;

        [NativeTypeName("Uint16")]
        public ushort delay;

        [NativeTypeName("Uint16")]
        public ushort button;

        [NativeTypeName("Uint16")]
        public ushort interval;

        [NativeTypeName("Uint8")]
        public byte channels;

        [NativeTypeName("Uint16")]
        public ushort period;

        [NativeTypeName("Uint16")]
        public ushort samples;

        [NativeTypeName("Uint16 *")]
        public ushort* data;

        [NativeTypeName("Uint16")]
        public ushort attack_length;

        [NativeTypeName("Uint16")]
        public ushort attack_level;

        [NativeTypeName("Uint16")]
        public ushort fade_length;

        [NativeTypeName("Uint16")]
        public ushort fade_level;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_HapticEffect
    {
        [FieldOffset(0)]
        [NativeTypeName("SDL_HapticEffectType")]
        public ushort type;

        [FieldOffset(0)]
        public SDL_HapticConstant constant;

        [FieldOffset(0)]
        public SDL_HapticPeriodic periodic;

        [FieldOffset(0)]
        public SDL_HapticCondition condition;

        [FieldOffset(0)]
        public SDL_HapticRamp ramp;

        [FieldOffset(0)]
        public SDL_HapticLeftRight leftright;

        [FieldOffset(0)]
        public SDL_HapticCustom custom;
    }

    public static unsafe partial class SDLHaptic
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_HapticID *")]
        public static extern uint* SDL_GetHaptics(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetHapticNameForID([NativeTypeName("SDL_HapticID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Haptic* SDL_OpenHaptic([NativeTypeName("SDL_HapticID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Haptic* SDL_GetHapticFromID([NativeTypeName("SDL_HapticID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_HapticID")]
        public static extern uint SDL_GetHapticID(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetHapticName(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_IsMouseHaptic();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Haptic* SDL_OpenHapticFromMouse();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_IsJoystickHaptic(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Haptic* SDL_OpenHapticFromJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetMaxHapticEffects(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetMaxHapticEffectsPlaying(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_GetHapticFeatures(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumHapticAxes(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HapticEffectSupported(SDL_Haptic* haptic, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_HapticEffectID")]
        public static extern int SDL_CreateHapticEffect(SDL_Haptic* haptic, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_UpdateHapticEffect(SDL_Haptic* haptic, [NativeTypeName("SDL_HapticEffectID")] int effect, [NativeTypeName("const SDL_HapticEffect *")] SDL_HapticEffect* data);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RunHapticEffect(SDL_Haptic* haptic, [NativeTypeName("SDL_HapticEffectID")] int effect, [NativeTypeName("Uint32")] uint iterations);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_StopHapticEffect(SDL_Haptic* haptic, [NativeTypeName("SDL_HapticEffectID")] int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyHapticEffect(SDL_Haptic* haptic, [NativeTypeName("SDL_HapticEffectID")] int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetHapticEffectStatus(SDL_Haptic* haptic, [NativeTypeName("SDL_HapticEffectID")] int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetHapticGain(SDL_Haptic* haptic, int gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetHapticAutocenter(SDL_Haptic* haptic, int autocenter);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_PauseHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ResumeHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_StopHapticEffects(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HapticRumbleSupported(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_InitHapticRumble(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_PlayHapticRumble(SDL_Haptic* haptic, float strength, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_StopHapticRumble(SDL_Haptic* haptic);

        [NativeTypeName("#define SDL_HAPTIC_INFINITY 4294967295U")]
        public const uint SDL_HAPTIC_INFINITY = 4294967295U;

        [NativeTypeName("#define SDL_HAPTIC_CONSTANT (1u<<0)")]
        public const uint SDL_HAPTIC_CONSTANT = (1U << 0);

        [NativeTypeName("#define SDL_HAPTIC_SINE (1u<<1)")]
        public const uint SDL_HAPTIC_SINE = (1U << 1);

        [NativeTypeName("#define SDL_HAPTIC_SQUARE (1u<<2)")]
        public const uint SDL_HAPTIC_SQUARE = (1U << 2);

        [NativeTypeName("#define SDL_HAPTIC_TRIANGLE (1u<<3)")]
        public const uint SDL_HAPTIC_TRIANGLE = (1U << 3);

        [NativeTypeName("#define SDL_HAPTIC_SAWTOOTHUP (1u<<4)")]
        public const uint SDL_HAPTIC_SAWTOOTHUP = (1U << 4);

        [NativeTypeName("#define SDL_HAPTIC_SAWTOOTHDOWN (1u<<5)")]
        public const uint SDL_HAPTIC_SAWTOOTHDOWN = (1U << 5);

        [NativeTypeName("#define SDL_HAPTIC_RAMP (1u<<6)")]
        public const uint SDL_HAPTIC_RAMP = (1U << 6);

        [NativeTypeName("#define SDL_HAPTIC_SPRING (1u<<7)")]
        public const uint SDL_HAPTIC_SPRING = (1U << 7);

        [NativeTypeName("#define SDL_HAPTIC_DAMPER (1u<<8)")]
        public const uint SDL_HAPTIC_DAMPER = (1U << 8);

        [NativeTypeName("#define SDL_HAPTIC_INERTIA (1u<<9)")]
        public const uint SDL_HAPTIC_INERTIA = (1U << 9);

        [NativeTypeName("#define SDL_HAPTIC_FRICTION (1u<<10)")]
        public const uint SDL_HAPTIC_FRICTION = (1U << 10);

        [NativeTypeName("#define SDL_HAPTIC_LEFTRIGHT (1u<<11)")]
        public const uint SDL_HAPTIC_LEFTRIGHT = (1U << 11);

        [NativeTypeName("#define SDL_HAPTIC_RESERVED1 (1u<<12)")]
        public const uint SDL_HAPTIC_RESERVED1 = (1U << 12);

        [NativeTypeName("#define SDL_HAPTIC_RESERVED2 (1u<<13)")]
        public const uint SDL_HAPTIC_RESERVED2 = (1U << 13);

        [NativeTypeName("#define SDL_HAPTIC_RESERVED3 (1u<<14)")]
        public const uint SDL_HAPTIC_RESERVED3 = (1U << 14);

        [NativeTypeName("#define SDL_HAPTIC_CUSTOM (1u<<15)")]
        public const uint SDL_HAPTIC_CUSTOM = (1U << 15);

        [NativeTypeName("#define SDL_HAPTIC_GAIN (1u<<16)")]
        public const uint SDL_HAPTIC_GAIN = (1U << 16);

        [NativeTypeName("#define SDL_HAPTIC_AUTOCENTER (1u<<17)")]
        public const uint SDL_HAPTIC_AUTOCENTER = (1U << 17);

        [NativeTypeName("#define SDL_HAPTIC_STATUS (1u<<18)")]
        public const uint SDL_HAPTIC_STATUS = (1U << 18);

        [NativeTypeName("#define SDL_HAPTIC_PAUSE (1u<<19)")]
        public const uint SDL_HAPTIC_PAUSE = (1U << 19);

        [NativeTypeName("#define SDL_HAPTIC_POLAR 0")]
        public const int SDL_HAPTIC_POLAR = 0;

        [NativeTypeName("#define SDL_HAPTIC_CARTESIAN 1")]
        public const int SDL_HAPTIC_CARTESIAN = 1;

        [NativeTypeName("#define SDL_HAPTIC_SPHERICAL 2")]
        public const int SDL_HAPTIC_SPHERICAL = 2;

        [NativeTypeName("#define SDL_HAPTIC_STEERING_AXIS 3")]
        public const int SDL_HAPTIC_STEERING_AXIS = 3;
    }
}
