using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public enum SDL_TextInputType
    {
        SDL_TEXTINPUT_TYPE_TEXT,
        SDL_TEXTINPUT_TYPE_TEXT_NAME,
        SDL_TEXTINPUT_TYPE_TEXT_EMAIL,
        SDL_TEXTINPUT_TYPE_TEXT_USERNAME,
        SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_HIDDEN,
        SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_VISIBLE,
        SDL_TEXTINPUT_TYPE_NUMBER,
        SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_HIDDEN,
        SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_VISIBLE,
    }

    public enum SDL_Capitalization
    {
        SDL_CAPITALIZE_NONE,
        SDL_CAPITALIZE_SENTENCES,
        SDL_CAPITALIZE_WORDS,
        SDL_CAPITALIZE_LETTERS,
    }

    public static unsafe partial class SDLKeyboard
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_KeyboardID *")]
        public static extern uint* SDL_GetKeyboards(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetKeyboardNameForID([NativeTypeName("SDL_KeyboardID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetKeyboardFocus();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const bool *")]
        public static extern byte* SDL_GetKeyboardState(int* numkeys);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ResetKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_Keymod")]
        public static extern ushort SDL_GetModState();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetModState([NativeTypeName("SDL_Keymod")] ushort modstate);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_Keycode")]
        public static extern uint SDL_GetKeyFromScancode(SDL_Scancode scancode, [NativeTypeName("SDL_Keymod")] ushort modstate, [NativeTypeName("bool")] byte key_event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Scancode SDL_GetScancodeFromKey([NativeTypeName("SDL_Keycode")] uint key, [NativeTypeName("SDL_Keymod *")] ushort* modstate);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetScancodeName(SDL_Scancode scancode, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetScancodeName(SDL_Scancode scancode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Scancode SDL_GetScancodeFromName([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetKeyName([NativeTypeName("SDL_Keycode")] uint key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_Keycode")]
        public static extern uint SDL_GetKeyFromName([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_StartTextInput(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_StartTextInputWithProperties(SDL_Window* window, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_TextInputActive(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_StopTextInput(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ClearComposition(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetTextInputArea(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, int cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTextInputArea(SDL_Window* window, SDL_Rect* rect, int* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasScreenKeyboardSupport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ScreenKeyboardShown(SDL_Window* window);

        [NativeTypeName("#define SDL_PROP_TEXTINPUT_TYPE_NUMBER \"SDL.textinput.type\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTINPUT_TYPE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x69, 0x6E, 0x70, 0x75, 0x74, 0x2E, 0x74, 0x79, 0x70, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTINPUT_CAPITALIZATION_NUMBER \"SDL.textinput.capitalization\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTINPUT_CAPITALIZATION_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x69, 0x6E, 0x70, 0x75, 0x74, 0x2E, 0x63, 0x61, 0x70, 0x69, 0x74, 0x61, 0x6C, 0x69, 0x7A, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTINPUT_AUTOCORRECT_BOOLEAN \"SDL.textinput.autocorrect\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTINPUT_AUTOCORRECT_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x69, 0x6E, 0x70, 0x75, 0x74, 0x2E, 0x61, 0x75, 0x74, 0x6F, 0x63, 0x6F, 0x72, 0x72, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTINPUT_MULTILINE_BOOLEAN \"SDL.textinput.multiline\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTINPUT_MULTILINE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x69, 0x6E, 0x70, 0x75, 0x74, 0x2E, 0x6D, 0x75, 0x6C, 0x74, 0x69, 0x6C, 0x69, 0x6E, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTINPUT_ANDROID_INPUTTYPE_NUMBER \"SDL.textinput.android.inputtype\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTINPUT_ANDROID_INPUTTYPE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x69, 0x6E, 0x70, 0x75, 0x74, 0x2E, 0x61, 0x6E, 0x64, 0x72, 0x6F, 0x69, 0x64, 0x2E, 0x69, 0x6E, 0x70, 0x75, 0x74, 0x74, 0x79, 0x70, 0x65, 0x00 };
    }
}
