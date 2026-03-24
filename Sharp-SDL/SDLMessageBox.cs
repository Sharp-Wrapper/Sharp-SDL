using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public unsafe partial struct SDL_MessageBoxButtonData
    {
        [NativeTypeName("SDL_MessageBoxButtonFlags")]
        public uint flags;

        public int buttonID;

        [NativeTypeName("const char *")]
        public sbyte* text;
    }

    public partial struct SDL_MessageBoxColor
    {
        [NativeTypeName("Uint8")]
        public byte r;

        [NativeTypeName("Uint8")]
        public byte g;

        [NativeTypeName("Uint8")]
        public byte b;
    }

    public enum SDL_MessageBoxColorType
    {
        SDL_MESSAGEBOX_COLOR_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_TEXT,
        SDL_MESSAGEBOX_COLOR_BUTTON_BORDER,
        SDL_MESSAGEBOX_COLOR_BUTTON_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_BUTTON_SELECTED,
        SDL_MESSAGEBOX_COLOR_COUNT,
    }

    public partial struct SDL_MessageBoxColorScheme
    {
        [NativeTypeName("SDL_MessageBoxColor[5]")]
        public _colors_e__FixedBuffer colors;

        public partial struct _colors_e__FixedBuffer
        {
            public SDL_MessageBoxColor e0;
            public SDL_MessageBoxColor e1;
            public SDL_MessageBoxColor e2;
            public SDL_MessageBoxColor e3;
            public SDL_MessageBoxColor e4;

            public unsafe ref SDL_MessageBoxColor this[int index]
            {
                get
                {
                    fixed (SDL_MessageBoxColor* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public unsafe partial struct SDL_MessageBoxData
    {
        [NativeTypeName("SDL_MessageBoxFlags")]
        public uint flags;

        public SDL_Window* window;

        [NativeTypeName("const char *")]
        public sbyte* title;

        [NativeTypeName("const char *")]
        public sbyte* message;

        public int numbuttons;

        [NativeTypeName("const SDL_MessageBoxButtonData *")]
        public SDL_MessageBoxButtonData* buttons;

        [NativeTypeName("const SDL_MessageBoxColorScheme *")]
        public SDL_MessageBoxColorScheme* colorScheme;
    }

    public static unsafe partial class SDLMessageBox
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ShowMessageBox([NativeTypeName("const SDL_MessageBoxData *")] SDL_MessageBoxData* messageboxdata, int* buttonid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ShowSimpleMessageBox([NativeTypeName("SDL_MessageBoxFlags")] uint flags, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("const char *")] sbyte* message, SDL_Window* window);

        [NativeTypeName("#define SDL_MESSAGEBOX_ERROR 0x00000010u")]
        public const uint SDL_MESSAGEBOX_ERROR = 0x00000010U;

        [NativeTypeName("#define SDL_MESSAGEBOX_WARNING 0x00000020u")]
        public const uint SDL_MESSAGEBOX_WARNING = 0x00000020U;

        [NativeTypeName("#define SDL_MESSAGEBOX_INFORMATION 0x00000040u")]
        public const uint SDL_MESSAGEBOX_INFORMATION = 0x00000040U;

        [NativeTypeName("#define SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT 0x00000080u")]
        public const uint SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT = 0x00000080U;

        [NativeTypeName("#define SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT 0x00000100u")]
        public const uint SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT = 0x00000100U;

        [NativeTypeName("#define SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT 0x00000001u")]
        public const uint SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT = 0x00000001U;

        [NativeTypeName("#define SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT 0x00000002u")]
        public const uint SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT = 0x00000002U;
    }
}
