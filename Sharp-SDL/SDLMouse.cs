using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Cursor
    {
    }

    public enum SDL_SystemCursor
    {
        SDL_SYSTEM_CURSOR_DEFAULT,
        SDL_SYSTEM_CURSOR_TEXT,
        SDL_SYSTEM_CURSOR_WAIT,
        SDL_SYSTEM_CURSOR_CROSSHAIR,
        SDL_SYSTEM_CURSOR_PROGRESS,
        SDL_SYSTEM_CURSOR_NWSE_RESIZE,
        SDL_SYSTEM_CURSOR_NESW_RESIZE,
        SDL_SYSTEM_CURSOR_EW_RESIZE,
        SDL_SYSTEM_CURSOR_NS_RESIZE,
        SDL_SYSTEM_CURSOR_MOVE,
        SDL_SYSTEM_CURSOR_NOT_ALLOWED,
        SDL_SYSTEM_CURSOR_POINTER,
        SDL_SYSTEM_CURSOR_NW_RESIZE,
        SDL_SYSTEM_CURSOR_N_RESIZE,
        SDL_SYSTEM_CURSOR_NE_RESIZE,
        SDL_SYSTEM_CURSOR_E_RESIZE,
        SDL_SYSTEM_CURSOR_SE_RESIZE,
        SDL_SYSTEM_CURSOR_S_RESIZE,
        SDL_SYSTEM_CURSOR_SW_RESIZE,
        SDL_SYSTEM_CURSOR_W_RESIZE,
        SDL_SYSTEM_CURSOR_COUNT,
    }

    public enum SDL_MouseWheelDirection
    {
        SDL_MOUSEWHEEL_NORMAL,
        SDL_MOUSEWHEEL_FLIPPED,
    }

    public unsafe partial struct SDL_CursorFrameInfo
    {
        public SDL_Surface* surface;

        [NativeTypeName("Uint32")]
        public uint duration;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_MouseMotionTransformCallback(void* userdata, [NativeTypeName("Uint64")] ulong timestamp, SDL_Window* window, [NativeTypeName("SDL_MouseID")] uint mouseID, float* x, float* y);

    public static unsafe partial class SDLMouse
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasMouse();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_MouseID *")]
        public static extern uint* SDL_GetMice(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetMouseNameForID([NativeTypeName("SDL_MouseID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetMouseFocus();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_MouseButtonFlags")]
        public static extern uint SDL_GetMouseState(float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_MouseButtonFlags")]
        public static extern uint SDL_GetGlobalMouseState(float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_MouseButtonFlags")]
        public static extern uint SDL_GetRelativeMouseState(float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_WarpMouseInWindow(SDL_Window* window, float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WarpMouseGlobal(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRelativeMouseTransform([NativeTypeName("SDL_MouseMotionTransformCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowRelativeMouseMode(SDL_Window* window, [NativeTypeName("bool")] byte enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowRelativeMouseMode(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CaptureMouse([NativeTypeName("bool")] byte enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_CreateCursor([NativeTypeName("const Uint8 *")] byte* data, [NativeTypeName("const Uint8 *")] byte* mask, int w, int h, int hot_x, int hot_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_CreateAnimatedCursor(SDL_CursorFrameInfo* frames, int frame_count, int hot_x, int hot_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_CreateSystemCursor(SDL_SystemCursor id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetCursor(SDL_Cursor* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_GetCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_GetDefaultCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyCursor(SDL_Cursor* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ShowCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HideCursor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CursorVisible();

        [NativeTypeName("#define SDL_BUTTON_LEFT 1")]
        public const int SDL_BUTTON_LEFT = 1;

        [NativeTypeName("#define SDL_BUTTON_MIDDLE 2")]
        public const int SDL_BUTTON_MIDDLE = 2;

        [NativeTypeName("#define SDL_BUTTON_RIGHT 3")]
        public const int SDL_BUTTON_RIGHT = 3;

        [NativeTypeName("#define SDL_BUTTON_X1 4")]
        public const int SDL_BUTTON_X1 = 4;

        [NativeTypeName("#define SDL_BUTTON_X2 5")]
        public const int SDL_BUTTON_X2 = 5;

        [NativeTypeName("#define SDL_BUTTON_LMASK SDL_BUTTON_MASK(SDL_BUTTON_LEFT)")]
        public const uint SDL_BUTTON_LMASK = (1U << ((1) - 1));

        [NativeTypeName("#define SDL_BUTTON_MMASK SDL_BUTTON_MASK(SDL_BUTTON_MIDDLE)")]
        public const uint SDL_BUTTON_MMASK = (1U << ((2) - 1));

        [NativeTypeName("#define SDL_BUTTON_RMASK SDL_BUTTON_MASK(SDL_BUTTON_RIGHT)")]
        public const uint SDL_BUTTON_RMASK = (1U << ((3) - 1));

        [NativeTypeName("#define SDL_BUTTON_X1MASK SDL_BUTTON_MASK(SDL_BUTTON_X1)")]
        public const uint SDL_BUTTON_X1MASK = (1U << ((4) - 1));

        [NativeTypeName("#define SDL_BUTTON_X2MASK SDL_BUTTON_MASK(SDL_BUTTON_X2)")]
        public const uint SDL_BUTTON_X2MASK = (1U << ((5) - 1));
    }
}
