using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public enum SDL_SystemTheme
    {
        SDL_SYSTEM_THEME_UNKNOWN,
        SDL_SYSTEM_THEME_LIGHT,
        SDL_SYSTEM_THEME_DARK,
    }

    public partial struct SDL_DisplayModeData
    {
    }

    public unsafe partial struct SDL_DisplayMode
    {
        [NativeTypeName("SDL_DisplayID")]
        public uint displayID;

        public SDL_PixelFormat format;

        public int w;

        public int h;

        public float pixel_density;

        public float refresh_rate;

        public int refresh_rate_numerator;

        public int refresh_rate_denominator;

        public SDL_DisplayModeData* @internal;
    }

    public enum SDL_DisplayOrientation
    {
        SDL_ORIENTATION_UNKNOWN,
        SDL_ORIENTATION_LANDSCAPE,
        SDL_ORIENTATION_LANDSCAPE_FLIPPED,
        SDL_ORIENTATION_PORTRAIT,
        SDL_ORIENTATION_PORTRAIT_FLIPPED,
    }

    public partial struct SDL_Window
    {
    }

    public enum SDL_FlashOperation
    {
        SDL_FLASH_CANCEL,
        SDL_FLASH_BRIEFLY,
        SDL_FLASH_UNTIL_FOCUSED,
    }

    public enum SDL_ProgressState
    {
        SDL_PROGRESS_STATE_INVALID = -1,
        SDL_PROGRESS_STATE_NONE,
        SDL_PROGRESS_STATE_INDETERMINATE,
        SDL_PROGRESS_STATE_NORMAL,
        SDL_PROGRESS_STATE_PAUSED,
        SDL_PROGRESS_STATE_ERROR,
    }

    public partial struct SDL_GLContextState
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("SDL_EGLAttrib *")]
    public unsafe delegate IntPtr* SDL_EGLAttribArrayCallback(void* userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("SDL_EGLint *")]
    public unsafe delegate int* SDL_EGLIntArrayCallback(void* userdata, [NativeTypeName("SDL_EGLDisplay")] void* display, [NativeTypeName("SDL_EGLConfig")] void* config);

    public enum SDL_GLAttr
    {
        SDL_GL_RED_SIZE,
        SDL_GL_GREEN_SIZE,
        SDL_GL_BLUE_SIZE,
        SDL_GL_ALPHA_SIZE,
        SDL_GL_BUFFER_SIZE,
        SDL_GL_DOUBLEBUFFER,
        SDL_GL_DEPTH_SIZE,
        SDL_GL_STENCIL_SIZE,
        SDL_GL_ACCUM_RED_SIZE,
        SDL_GL_ACCUM_GREEN_SIZE,
        SDL_GL_ACCUM_BLUE_SIZE,
        SDL_GL_ACCUM_ALPHA_SIZE,
        SDL_GL_STEREO,
        SDL_GL_MULTISAMPLEBUFFERS,
        SDL_GL_MULTISAMPLESAMPLES,
        SDL_GL_ACCELERATED_VISUAL,
        SDL_GL_RETAINED_BACKING,
        SDL_GL_CONTEXT_MAJOR_VERSION,
        SDL_GL_CONTEXT_MINOR_VERSION,
        SDL_GL_CONTEXT_FLAGS,
        SDL_GL_CONTEXT_PROFILE_MASK,
        SDL_GL_SHARE_WITH_CURRENT_CONTEXT,
        SDL_GL_FRAMEBUFFER_SRGB_CAPABLE,
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR,
        SDL_GL_CONTEXT_RESET_NOTIFICATION,
        SDL_GL_CONTEXT_NO_ERROR,
        SDL_GL_FLOATBUFFERS,
        SDL_GL_EGL_PLATFORM,
    }

    public enum SDL_HitTestResult
    {
        SDL_HITTEST_NORMAL,
        SDL_HITTEST_DRAGGABLE,
        SDL_HITTEST_RESIZE_TOPLEFT,
        SDL_HITTEST_RESIZE_TOP,
        SDL_HITTEST_RESIZE_TOPRIGHT,
        SDL_HITTEST_RESIZE_RIGHT,
        SDL_HITTEST_RESIZE_BOTTOMRIGHT,
        SDL_HITTEST_RESIZE_BOTTOM,
        SDL_HITTEST_RESIZE_BOTTOMLEFT,
        SDL_HITTEST_RESIZE_LEFT,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate SDL_HitTestResult SDL_HitTest(SDL_Window* win, [NativeTypeName("const SDL_Point *")] SDL_Point* area, void* data);

    public static unsafe partial class SDLVideo
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumVideoDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetVideoDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetCurrentVideoDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_SystemTheme SDL_GetSystemTheme();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID *")]
        public static extern uint* SDL_GetDisplays(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID")]
        public static extern uint SDL_GetPrimaryDisplay();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetDisplayProperties([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetDisplayName([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetDisplayBounds([NativeTypeName("SDL_DisplayID")] uint displayID, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetDisplayUsableBounds([NativeTypeName("SDL_DisplayID")] uint displayID, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_DisplayOrientation SDL_GetNaturalDisplayOrientation([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_DisplayOrientation SDL_GetCurrentDisplayOrientation([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetDisplayContentScale([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_DisplayMode** SDL_GetFullscreenDisplayModes([NativeTypeName("SDL_DisplayID")] uint displayID, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetClosestFullscreenDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID, int w, int h, float refresh_rate, [NativeTypeName("bool")] byte include_high_density_modes, SDL_DisplayMode* closest);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const SDL_DisplayMode *")]
        public static extern SDL_DisplayMode* SDL_GetDesktopDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const SDL_DisplayMode *")]
        public static extern SDL_DisplayMode* SDL_GetCurrentDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID")]
        public static extern uint SDL_GetDisplayForPoint([NativeTypeName("const SDL_Point *")] SDL_Point* point);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID")]
        public static extern uint SDL_GetDisplayForRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_DisplayID")]
        public static extern uint SDL_GetDisplayForWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetWindowPixelDensity(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetWindowDisplayScale(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowFullscreenMode(SDL_Window* window, [NativeTypeName("const SDL_DisplayMode *")] SDL_DisplayMode* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const SDL_DisplayMode *")]
        public static extern SDL_DisplayMode* SDL_GetWindowFullscreenMode(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetWindowICCProfile(SDL_Window* window, [NativeTypeName("size_t *")] UIntPtr* size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PixelFormat SDL_GetWindowPixelFormat(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window** SDL_GetWindows(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_CreateWindow([NativeTypeName("const char *")] sbyte* title, int w, int h, [NativeTypeName("SDL_WindowFlags")] ulong flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_CreatePopupWindow(SDL_Window* parent, int offset_x, int offset_y, int w, int h, [NativeTypeName("SDL_WindowFlags")] ulong flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_CreateWindowWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_WindowID")]
        public static extern uint SDL_GetWindowID(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetWindowFromID([NativeTypeName("SDL_WindowID")] uint id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetWindowParent(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetWindowProperties(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_WindowFlags")]
        public static extern ulong SDL_GetWindowFlags(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowTitle(SDL_Window* window, [NativeTypeName("const char *")] sbyte* title);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetWindowTitle(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowIcon(SDL_Window* window, SDL_Surface* icon);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowPosition(SDL_Window* window, int x, int y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowPosition(SDL_Window* window, int* x, int* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowSize(SDL_Window* window, int w, int h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowSafeArea(SDL_Window* window, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowAspectRatio(SDL_Window* window, float min_aspect, float max_aspect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowAspectRatio(SDL_Window* window, float* min_aspect, float* max_aspect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowBordersSize(SDL_Window* window, int* top, int* left, int* bottom, int* right);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowSizeInPixels(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowMinimumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowMaximumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowBordered(SDL_Window* window, [NativeTypeName("bool")] byte bordered);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowResizable(SDL_Window* window, [NativeTypeName("bool")] byte resizable);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowAlwaysOnTop(SDL_Window* window, [NativeTypeName("bool")] byte on_top);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowFillDocument(SDL_Window* window, [NativeTypeName("bool")] byte fill);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ShowWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HideWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RaiseWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_MaximizeWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_MinimizeWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RestoreWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowFullscreen(SDL_Window* window, [NativeTypeName("bool")] byte fullscreen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SyncWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WindowHasSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_GetWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowSurfaceVSync(SDL_Window* window, int vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowSurfaceVSync(SDL_Window* window, int* vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_UpdateWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_UpdateWindowSurfaceRects(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int numrects);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_DestroyWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowKeyboardGrab(SDL_Window* window, [NativeTypeName("bool")] byte grabbed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowMouseGrab(SDL_Window* window, [NativeTypeName("bool")] byte grabbed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowKeyboardGrab(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetWindowMouseGrab(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetGrabbedWindow();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowMouseRect(SDL_Window* window, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const SDL_Rect *")]
        public static extern SDL_Rect* SDL_GetWindowMouseRect(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowOpacity(SDL_Window* window, float opacity);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetWindowOpacity(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowParent(SDL_Window* window, SDL_Window* parent);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowModal(SDL_Window* window, [NativeTypeName("bool")] byte modal);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowFocusable(SDL_Window* window, [NativeTypeName("bool")] byte focusable);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ShowWindowSystemMenu(SDL_Window* window, int x, int y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowHitTest(SDL_Window* window, [NativeTypeName("SDL_HitTest")] IntPtr callback, void* callback_data);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowShape(SDL_Window* window, SDL_Surface* shape);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_FlashWindow(SDL_Window* window, SDL_FlashOperation operation);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowProgressState(SDL_Window* window, SDL_ProgressState state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_ProgressState SDL_GetWindowProgressState(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetWindowProgressValue(SDL_Window* window, float value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetWindowProgressValue(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ScreenSaverEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_EnableScreenSaver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_DisableScreenSaver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GL_LoadLibrary([NativeTypeName("const char *")] sbyte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_FunctionPointer")]
        public static extern IntPtr SDL_GL_GetProcAddress([NativeTypeName("const char *")] sbyte* proc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_FunctionPointer")]
        public static extern IntPtr SDL_EGL_GetProcAddress([NativeTypeName("const char *")] sbyte* proc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GL_UnloadLibrary();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GL_ExtensionSupported([NativeTypeName("const char *")] sbyte* extension);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GL_ResetAttributes();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GL_SetAttribute(SDL_GLAttr attr, int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GL_GetAttribute(SDL_GLAttr attr, int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_GLContext")]
        public static extern SDL_GLContextState* SDL_GL_CreateContext(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GL_MakeCurrent(SDL_Window* window, [NativeTypeName("SDL_GLContext")] SDL_GLContextState* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GL_GetCurrentWindow();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_GLContext")]
        public static extern SDL_GLContextState* SDL_GL_GetCurrentContext();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_EGLDisplay")]
        public static extern void* SDL_EGL_GetCurrentDisplay();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_EGLConfig")]
        public static extern void* SDL_EGL_GetCurrentConfig();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_EGLSurface")]
        public static extern void* SDL_EGL_GetWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_EGL_SetAttributeCallbacks([NativeTypeName("SDL_EGLAttribArrayCallback")] IntPtr platformAttribCallback, [NativeTypeName("SDL_EGLIntArrayCallback")] IntPtr surfaceAttribCallback, [NativeTypeName("SDL_EGLIntArrayCallback")] IntPtr contextAttribCallback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GL_SetSwapInterval(int interval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GL_GetSwapInterval(int* interval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GL_SwapWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GL_DestroyContext([NativeTypeName("SDL_GLContext")] SDL_GLContextState* context);

        [NativeTypeName("#define SDL_PROP_GLOBAL_VIDEO_WAYLAND_WL_DISPLAY_POINTER \"SDL.video.wayland.wl_display\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GLOBAL_VIDEO_WAYLAND_WL_DISPLAY_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x76, 0x69, 0x64, 0x65, 0x6F, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x77, 0x6C, 0x5F, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x00 };

        [NativeTypeName("#define SDL_WINDOW_FULLSCREEN SDL_UINT64_C(0x0000000000000001)")]
        public const ulong SDL_WINDOW_FULLSCREEN = (0x0000000000000001UL);

        [NativeTypeName("#define SDL_WINDOW_OPENGL SDL_UINT64_C(0x0000000000000002)")]
        public const ulong SDL_WINDOW_OPENGL = (0x0000000000000002UL);

        [NativeTypeName("#define SDL_WINDOW_OCCLUDED SDL_UINT64_C(0x0000000000000004)")]
        public const ulong SDL_WINDOW_OCCLUDED = (0x0000000000000004UL);

        [NativeTypeName("#define SDL_WINDOW_HIDDEN SDL_UINT64_C(0x0000000000000008)")]
        public const ulong SDL_WINDOW_HIDDEN = (0x0000000000000008UL);

        [NativeTypeName("#define SDL_WINDOW_BORDERLESS SDL_UINT64_C(0x0000000000000010)")]
        public const ulong SDL_WINDOW_BORDERLESS = (0x0000000000000010UL);

        [NativeTypeName("#define SDL_WINDOW_RESIZABLE SDL_UINT64_C(0x0000000000000020)")]
        public const ulong SDL_WINDOW_RESIZABLE = (0x0000000000000020UL);

        [NativeTypeName("#define SDL_WINDOW_MINIMIZED SDL_UINT64_C(0x0000000000000040)")]
        public const ulong SDL_WINDOW_MINIMIZED = (0x0000000000000040UL);

        [NativeTypeName("#define SDL_WINDOW_MAXIMIZED SDL_UINT64_C(0x0000000000000080)")]
        public const ulong SDL_WINDOW_MAXIMIZED = (0x0000000000000080UL);

        [NativeTypeName("#define SDL_WINDOW_MOUSE_GRABBED SDL_UINT64_C(0x0000000000000100)")]
        public const ulong SDL_WINDOW_MOUSE_GRABBED = (0x0000000000000100UL);

        [NativeTypeName("#define SDL_WINDOW_INPUT_FOCUS SDL_UINT64_C(0x0000000000000200)")]
        public const ulong SDL_WINDOW_INPUT_FOCUS = (0x0000000000000200UL);

        [NativeTypeName("#define SDL_WINDOW_MOUSE_FOCUS SDL_UINT64_C(0x0000000000000400)")]
        public const ulong SDL_WINDOW_MOUSE_FOCUS = (0x0000000000000400UL);

        [NativeTypeName("#define SDL_WINDOW_EXTERNAL SDL_UINT64_C(0x0000000000000800)")]
        public const ulong SDL_WINDOW_EXTERNAL = (0x0000000000000800UL);

        [NativeTypeName("#define SDL_WINDOW_MODAL SDL_UINT64_C(0x0000000000001000)")]
        public const ulong SDL_WINDOW_MODAL = (0x0000000000001000UL);

        [NativeTypeName("#define SDL_WINDOW_HIGH_PIXEL_DENSITY SDL_UINT64_C(0x0000000000002000)")]
        public const ulong SDL_WINDOW_HIGH_PIXEL_DENSITY = (0x0000000000002000UL);

        [NativeTypeName("#define SDL_WINDOW_MOUSE_CAPTURE SDL_UINT64_C(0x0000000000004000)")]
        public const ulong SDL_WINDOW_MOUSE_CAPTURE = (0x0000000000004000UL);

        [NativeTypeName("#define SDL_WINDOW_MOUSE_RELATIVE_MODE SDL_UINT64_C(0x0000000000008000)")]
        public const ulong SDL_WINDOW_MOUSE_RELATIVE_MODE = (0x0000000000008000UL);

        [NativeTypeName("#define SDL_WINDOW_ALWAYS_ON_TOP SDL_UINT64_C(0x0000000000010000)")]
        public const ulong SDL_WINDOW_ALWAYS_ON_TOP = (0x0000000000010000UL);

        [NativeTypeName("#define SDL_WINDOW_UTILITY SDL_UINT64_C(0x0000000000020000)")]
        public const ulong SDL_WINDOW_UTILITY = (0x0000000000020000UL);

        [NativeTypeName("#define SDL_WINDOW_TOOLTIP SDL_UINT64_C(0x0000000000040000)")]
        public const ulong SDL_WINDOW_TOOLTIP = (0x0000000000040000UL);

        [NativeTypeName("#define SDL_WINDOW_POPUP_MENU SDL_UINT64_C(0x0000000000080000)")]
        public const ulong SDL_WINDOW_POPUP_MENU = (0x0000000000080000UL);

        [NativeTypeName("#define SDL_WINDOW_KEYBOARD_GRABBED SDL_UINT64_C(0x0000000000100000)")]
        public const ulong SDL_WINDOW_KEYBOARD_GRABBED = (0x0000000000100000UL);

        [NativeTypeName("#define SDL_WINDOW_FILL_DOCUMENT SDL_UINT64_C(0x0000000000200000)")]
        public const ulong SDL_WINDOW_FILL_DOCUMENT = (0x0000000000200000UL);

        [NativeTypeName("#define SDL_WINDOW_VULKAN SDL_UINT64_C(0x0000000010000000)")]
        public const ulong SDL_WINDOW_VULKAN = (0x0000000010000000UL);

        [NativeTypeName("#define SDL_WINDOW_METAL SDL_UINT64_C(0x0000000020000000)")]
        public const ulong SDL_WINDOW_METAL = (0x0000000020000000UL);

        [NativeTypeName("#define SDL_WINDOW_TRANSPARENT SDL_UINT64_C(0x0000000040000000)")]
        public const ulong SDL_WINDOW_TRANSPARENT = (0x0000000040000000UL);

        [NativeTypeName("#define SDL_WINDOW_NOT_FOCUSABLE SDL_UINT64_C(0x0000000080000000)")]
        public const ulong SDL_WINDOW_NOT_FOCUSABLE = (0x0000000080000000UL);

        [NativeTypeName("#define SDL_WINDOWPOS_UNDEFINED_MASK 0x1FFF0000u")]
        public const uint SDL_WINDOWPOS_UNDEFINED_MASK = 0x1FFF0000U;

        [NativeTypeName("#define SDL_WINDOWPOS_UNDEFINED SDL_WINDOWPOS_UNDEFINED_DISPLAY(0)")]
        public const uint SDL_WINDOWPOS_UNDEFINED = (0x1FFF0000U | (0));

        [NativeTypeName("#define SDL_WINDOWPOS_CENTERED_MASK 0x2FFF0000u")]
        public const uint SDL_WINDOWPOS_CENTERED_MASK = 0x2FFF0000U;

        [NativeTypeName("#define SDL_WINDOWPOS_CENTERED SDL_WINDOWPOS_CENTERED_DISPLAY(0)")]
        public const uint SDL_WINDOWPOS_CENTERED = (0x2FFF0000U | (0));

        [NativeTypeName("#define SDL_GL_CONTEXT_PROFILE_CORE 0x0001")]
        public const int SDL_GL_CONTEXT_PROFILE_CORE = 0x0001;

        [NativeTypeName("#define SDL_GL_CONTEXT_PROFILE_COMPATIBILITY 0x0002")]
        public const int SDL_GL_CONTEXT_PROFILE_COMPATIBILITY = 0x0002;

        [NativeTypeName("#define SDL_GL_CONTEXT_PROFILE_ES 0x0004")]
        public const int SDL_GL_CONTEXT_PROFILE_ES = 0x0004;

        [NativeTypeName("#define SDL_GL_CONTEXT_DEBUG_FLAG 0x0001")]
        public const int SDL_GL_CONTEXT_DEBUG_FLAG = 0x0001;

        [NativeTypeName("#define SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG 0x0002")]
        public const int SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG = 0x0002;

        [NativeTypeName("#define SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG 0x0004")]
        public const int SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG = 0x0004;

        [NativeTypeName("#define SDL_GL_CONTEXT_RESET_ISOLATION_FLAG 0x0008")]
        public const int SDL_GL_CONTEXT_RESET_ISOLATION_FLAG = 0x0008;

        [NativeTypeName("#define SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE 0x0000")]
        public const int SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE = 0x0000;

        [NativeTypeName("#define SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH 0x0001")]
        public const int SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x0001;

        [NativeTypeName("#define SDL_GL_CONTEXT_RESET_NO_NOTIFICATION 0x0000")]
        public const int SDL_GL_CONTEXT_RESET_NO_NOTIFICATION = 0x0000;

        [NativeTypeName("#define SDL_GL_CONTEXT_RESET_LOSE_CONTEXT 0x0001")]
        public const int SDL_GL_CONTEXT_RESET_LOSE_CONTEXT = 0x0001;

        [NativeTypeName("#define SDL_PROP_DISPLAY_HDR_ENABLED_BOOLEAN \"SDL.display.HDR_enabled\"")]
        public static ReadOnlySpan<byte> SDL_PROP_DISPLAY_HDR_ENABLED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x2E, 0x48, 0x44, 0x52, 0x5F, 0x65, 0x6E, 0x61, 0x62, 0x6C, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_DISPLAY_KMSDRM_PANEL_ORIENTATION_NUMBER \"SDL.display.KMSDRM.panel_orientation\"")]
        public static ReadOnlySpan<byte> SDL_PROP_DISPLAY_KMSDRM_PANEL_ORIENTATION_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x2E, 0x4B, 0x4D, 0x53, 0x44, 0x52, 0x4D, 0x2E, 0x70, 0x61, 0x6E, 0x65, 0x6C, 0x5F, 0x6F, 0x72, 0x69, 0x65, 0x6E, 0x74, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_DISPLAY_WAYLAND_WL_OUTPUT_POINTER \"SDL.display.wayland.wl_output\"")]
        public static ReadOnlySpan<byte> SDL_PROP_DISPLAY_WAYLAND_WL_OUTPUT_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x77, 0x6C, 0x5F, 0x6F, 0x75, 0x74, 0x70, 0x75, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_DISPLAY_WINDOWS_HMONITOR_POINTER \"SDL.display.windows.hmonitor\"")]
        public static ReadOnlySpan<byte> SDL_PROP_DISPLAY_WINDOWS_HMONITOR_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x73, 0x2E, 0x68, 0x6D, 0x6F, 0x6E, 0x69, 0x74, 0x6F, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_ALWAYS_ON_TOP_BOOLEAN \"SDL.window.create.always_on_top\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_ALWAYS_ON_TOP_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x61, 0x6C, 0x77, 0x61, 0x79, 0x73, 0x5F, 0x6F, 0x6E, 0x5F, 0x74, 0x6F, 0x70, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_BORDERLESS_BOOLEAN \"SDL.window.create.borderless\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_BORDERLESS_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x62, 0x6F, 0x72, 0x64, 0x65, 0x72, 0x6C, 0x65, 0x73, 0x73, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_CONSTRAIN_POPUP_BOOLEAN \"SDL.window.create.constrain_popup\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_CONSTRAIN_POPUP_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x63, 0x6F, 0x6E, 0x73, 0x74, 0x72, 0x61, 0x69, 0x6E, 0x5F, 0x70, 0x6F, 0x70, 0x75, 0x70, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_FOCUSABLE_BOOLEAN \"SDL.window.create.focusable\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_FOCUSABLE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x66, 0x6F, 0x63, 0x75, 0x73, 0x61, 0x62, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_EXTERNAL_GRAPHICS_CONTEXT_BOOLEAN \"SDL.window.create.external_graphics_context\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_EXTERNAL_GRAPHICS_CONTEXT_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x73, 0x5F, 0x63, 0x6F, 0x6E, 0x74, 0x65, 0x78, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_FLAGS_NUMBER \"SDL.window.create.flags\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_FLAGS_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x66, 0x6C, 0x61, 0x67, 0x73, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_FULLSCREEN_BOOLEAN \"SDL.window.create.fullscreen\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_FULLSCREEN_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x66, 0x75, 0x6C, 0x6C, 0x73, 0x63, 0x72, 0x65, 0x65, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_HEIGHT_NUMBER \"SDL.window.create.height\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_HEIGHT_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_HIDDEN_BOOLEAN \"SDL.window.create.hidden\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_HIDDEN_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x68, 0x69, 0x64, 0x64, 0x65, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_HIGH_PIXEL_DENSITY_BOOLEAN \"SDL.window.create.high_pixel_density\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_HIGH_PIXEL_DENSITY_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x68, 0x69, 0x67, 0x68, 0x5F, 0x70, 0x69, 0x78, 0x65, 0x6C, 0x5F, 0x64, 0x65, 0x6E, 0x73, 0x69, 0x74, 0x79, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MAXIMIZED_BOOLEAN \"SDL.window.create.maximized\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_MAXIMIZED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6D, 0x61, 0x78, 0x69, 0x6D, 0x69, 0x7A, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MENU_BOOLEAN \"SDL.window.create.menu\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_MENU_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6D, 0x65, 0x6E, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_METAL_BOOLEAN \"SDL.window.create.metal\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_METAL_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MINIMIZED_BOOLEAN \"SDL.window.create.minimized\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_MINIMIZED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6D, 0x69, 0x6E, 0x69, 0x6D, 0x69, 0x7A, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MODAL_BOOLEAN \"SDL.window.create.modal\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_MODAL_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6D, 0x6F, 0x64, 0x61, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MOUSE_GRABBED_BOOLEAN \"SDL.window.create.mouse_grabbed\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_MOUSE_GRABBED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6D, 0x6F, 0x75, 0x73, 0x65, 0x5F, 0x67, 0x72, 0x61, 0x62, 0x62, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_OPENGL_BOOLEAN \"SDL.window.create.opengl\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_OPENGL_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_PARENT_POINTER \"SDL.window.create.parent\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_PARENT_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x70, 0x61, 0x72, 0x65, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_RESIZABLE_BOOLEAN \"SDL.window.create.resizable\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_RESIZABLE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x72, 0x65, 0x73, 0x69, 0x7A, 0x61, 0x62, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_TITLE_STRING \"SDL.window.create.title\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_TITLE_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x74, 0x69, 0x74, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_TRANSPARENT_BOOLEAN \"SDL.window.create.transparent\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_TRANSPARENT_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x74, 0x72, 0x61, 0x6E, 0x73, 0x70, 0x61, 0x72, 0x65, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_TOOLTIP_BOOLEAN \"SDL.window.create.tooltip\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_TOOLTIP_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x74, 0x6F, 0x6F, 0x6C, 0x74, 0x69, 0x70, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_UTILITY_BOOLEAN \"SDL.window.create.utility\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_UTILITY_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x75, 0x74, 0x69, 0x6C, 0x69, 0x74, 0x79, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_VULKAN_BOOLEAN \"SDL.window.create.vulkan\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_VULKAN_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WIDTH_NUMBER \"SDL.window.create.width\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WIDTH_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x77, 0x69, 0x64, 0x74, 0x68, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_X_NUMBER \"SDL.window.create.x\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_X_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_Y_NUMBER \"SDL.window.create.y\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_Y_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x79, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_COCOA_WINDOW_POINTER \"SDL.window.create.cocoa.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_COCOA_WINDOW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x63, 0x6F, 0x63, 0x6F, 0x61, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_COCOA_VIEW_POINTER \"SDL.window.create.cocoa.view\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_COCOA_VIEW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x63, 0x6F, 0x63, 0x6F, 0x61, 0x2E, 0x76, 0x69, 0x65, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WINDOWSCENE_POINTER \"SDL.window.create.uikit.windowscene\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WINDOWSCENE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x75, 0x69, 0x6B, 0x69, 0x74, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x73, 0x63, 0x65, 0x6E, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN \"SDL.window.create.wayland.surface_role_custom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x5F, 0x72, 0x6F, 0x6C, 0x65, 0x5F, 0x63, 0x75, 0x73, 0x74, 0x6F, 0x6D, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WAYLAND_CREATE_EGL_WINDOW_BOOLEAN \"SDL.window.create.wayland.create_egl_window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WAYLAND_CREATE_EGL_WINDOW_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x5F, 0x65, 0x67, 0x6C, 0x5F, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER \"SDL.window.create.wayland.wl_surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x77, 0x6C, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WIN32_HWND_POINTER \"SDL.window.create.win32.hwnd\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WIN32_HWND_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x2E, 0x68, 0x77, 0x6E, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER \"SDL.window.create.win32.pixel_format_hwnd\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x2E, 0x70, 0x69, 0x78, 0x65, 0x6C, 0x5F, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x5F, 0x68, 0x77, 0x6E, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_X11_WINDOW_NUMBER \"SDL.window.create.x11.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_X11_WINDOW_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x78, 0x31, 0x31, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_CANVAS_ID_STRING \"SDL.window.create.emscripten.canvas_id\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_CANVAS_ID_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x65, 0x6D, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x65, 0x6E, 0x2E, 0x63, 0x61, 0x6E, 0x76, 0x61, 0x73, 0x5F, 0x69, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING \"SDL.window.create.emscripten.keyboard_element\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x65, 0x6D, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x65, 0x6E, 0x2E, 0x6B, 0x65, 0x79, 0x62, 0x6F, 0x61, 0x72, 0x64, 0x5F, 0x65, 0x6C, 0x65, 0x6D, 0x65, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_SHAPE_POINTER \"SDL.window.shape\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_SHAPE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x73, 0x68, 0x61, 0x70, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_HDR_ENABLED_BOOLEAN \"SDL.window.HDR_enabled\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_HDR_ENABLED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x48, 0x44, 0x52, 0x5F, 0x65, 0x6E, 0x61, 0x62, 0x6C, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_SDR_WHITE_LEVEL_FLOAT \"SDL.window.SDR_white_level\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_SDR_WHITE_LEVEL_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x53, 0x44, 0x52, 0x5F, 0x77, 0x68, 0x69, 0x74, 0x65, 0x5F, 0x6C, 0x65, 0x76, 0x65, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_HDR_HEADROOM_FLOAT \"SDL.window.HDR_headroom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_HDR_HEADROOM_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x48, 0x44, 0x52, 0x5F, 0x68, 0x65, 0x61, 0x64, 0x72, 0x6F, 0x6F, 0x6D, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_ANDROID_WINDOW_POINTER \"SDL.window.android.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_ANDROID_WINDOW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x61, 0x6E, 0x64, 0x72, 0x6F, 0x69, 0x64, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_ANDROID_SURFACE_POINTER \"SDL.window.android.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_ANDROID_SURFACE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x61, 0x6E, 0x64, 0x72, 0x6F, 0x69, 0x64, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_WINDOW_POINTER \"SDL.window.uikit.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_UIKIT_WINDOW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x75, 0x69, 0x6B, 0x69, 0x74, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_METAL_VIEW_TAG_NUMBER \"SDL.window.uikit.metal_view_tag\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_UIKIT_METAL_VIEW_TAG_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x75, 0x69, 0x6B, 0x69, 0x74, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x6C, 0x5F, 0x76, 0x69, 0x65, 0x77, 0x5F, 0x74, 0x61, 0x67, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_OPENGL_FRAMEBUFFER_NUMBER \"SDL.window.uikit.opengl.framebuffer\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_UIKIT_OPENGL_FRAMEBUFFER_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x75, 0x69, 0x6B, 0x69, 0x74, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x66, 0x72, 0x61, 0x6D, 0x65, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_OPENGL_RENDERBUFFER_NUMBER \"SDL.window.uikit.opengl.renderbuffer\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_UIKIT_OPENGL_RENDERBUFFER_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x75, 0x69, 0x6B, 0x69, 0x74, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_OPENGL_RESOLVE_FRAMEBUFFER_NUMBER \"SDL.window.uikit.opengl.resolve_framebuffer\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_UIKIT_OPENGL_RESOLVE_FRAMEBUFFER_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x75, 0x69, 0x6B, 0x69, 0x74, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x72, 0x65, 0x73, 0x6F, 0x6C, 0x76, 0x65, 0x5F, 0x66, 0x72, 0x61, 0x6D, 0x65, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_KMSDRM_DEVICE_INDEX_NUMBER \"SDL.window.kmsdrm.dev_index\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_KMSDRM_DEVICE_INDEX_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x6B, 0x6D, 0x73, 0x64, 0x72, 0x6D, 0x2E, 0x64, 0x65, 0x76, 0x5F, 0x69, 0x6E, 0x64, 0x65, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_KMSDRM_DRM_FD_NUMBER \"SDL.window.kmsdrm.drm_fd\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_KMSDRM_DRM_FD_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x6B, 0x6D, 0x73, 0x64, 0x72, 0x6D, 0x2E, 0x64, 0x72, 0x6D, 0x5F, 0x66, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_KMSDRM_GBM_DEVICE_POINTER \"SDL.window.kmsdrm.gbm_dev\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_KMSDRM_GBM_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x6B, 0x6D, 0x73, 0x64, 0x72, 0x6D, 0x2E, 0x67, 0x62, 0x6D, 0x5F, 0x64, 0x65, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_COCOA_WINDOW_POINTER \"SDL.window.cocoa.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_COCOA_WINDOW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x6F, 0x63, 0x6F, 0x61, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_COCOA_METAL_VIEW_TAG_NUMBER \"SDL.window.cocoa.metal_view_tag\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_COCOA_METAL_VIEW_TAG_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x63, 0x6F, 0x63, 0x6F, 0x61, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x6C, 0x5F, 0x76, 0x69, 0x65, 0x77, 0x5F, 0x74, 0x61, 0x67, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_OPENVR_OVERLAY_ID_NUMBER \"SDL.window.openvr.overlay_id\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_OPENVR_OVERLAY_ID_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x76, 0x72, 0x2E, 0x6F, 0x76, 0x65, 0x72, 0x6C, 0x61, 0x79, 0x5F, 0x69, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_VIVANTE_DISPLAY_POINTER \"SDL.window.vivante.display\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_VIVANTE_DISPLAY_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x76, 0x69, 0x76, 0x61, 0x6E, 0x74, 0x65, 0x2E, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_VIVANTE_WINDOW_POINTER \"SDL.window.vivante.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_VIVANTE_WINDOW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x76, 0x69, 0x76, 0x61, 0x6E, 0x74, 0x65, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_VIVANTE_SURFACE_POINTER \"SDL.window.vivante.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_VIVANTE_SURFACE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x76, 0x69, 0x76, 0x61, 0x6E, 0x74, 0x65, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WIN32_HWND_POINTER \"SDL.window.win32.hwnd\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WIN32_HWND_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x2E, 0x68, 0x77, 0x6E, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WIN32_HDC_POINTER \"SDL.window.win32.hdc\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WIN32_HDC_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x2E, 0x68, 0x64, 0x63, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WIN32_INSTANCE_POINTER \"SDL.window.win32.instance\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WIN32_INSTANCE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x2E, 0x69, 0x6E, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_DISPLAY_POINTER \"SDL.window.wayland.display\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_DISPLAY_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_SURFACE_POINTER \"SDL.window.wayland.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_SURFACE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_VIEWPORT_POINTER \"SDL.window.wayland.viewport\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_VIEWPORT_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x76, 0x69, 0x65, 0x77, 0x70, 0x6F, 0x72, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_EGL_WINDOW_POINTER \"SDL.window.wayland.egl_window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_EGL_WINDOW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x65, 0x67, 0x6C, 0x5F, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_SURFACE_POINTER \"SDL.window.wayland.xdg_surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_SURFACE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x78, 0x64, 0x67, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_POINTER \"SDL.window.wayland.xdg_toplevel\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x78, 0x64, 0x67, 0x5F, 0x74, 0x6F, 0x70, 0x6C, 0x65, 0x76, 0x65, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_EXPORT_HANDLE_STRING \"SDL.window.wayland.xdg_toplevel_export_handle\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_EXPORT_HANDLE_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x78, 0x64, 0x67, 0x5F, 0x74, 0x6F, 0x70, 0x6C, 0x65, 0x76, 0x65, 0x6C, 0x5F, 0x65, 0x78, 0x70, 0x6F, 0x72, 0x74, 0x5F, 0x68, 0x61, 0x6E, 0x64, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_POPUP_POINTER \"SDL.window.wayland.xdg_popup\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_POPUP_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x78, 0x64, 0x67, 0x5F, 0x70, 0x6F, 0x70, 0x75, 0x70, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_WAYLAND_XDG_POSITIONER_POINTER \"SDL.window.wayland.xdg_positioner\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_WAYLAND_XDG_POSITIONER_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x77, 0x61, 0x79, 0x6C, 0x61, 0x6E, 0x64, 0x2E, 0x78, 0x64, 0x67, 0x5F, 0x70, 0x6F, 0x73, 0x69, 0x74, 0x69, 0x6F, 0x6E, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_X11_DISPLAY_POINTER \"SDL.window.x11.display\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_X11_DISPLAY_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x78, 0x31, 0x31, 0x2E, 0x64, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_X11_SCREEN_NUMBER \"SDL.window.x11.screen\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_X11_SCREEN_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x78, 0x31, 0x31, 0x2E, 0x73, 0x63, 0x72, 0x65, 0x65, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_X11_WINDOW_NUMBER \"SDL.window.x11.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_X11_WINDOW_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x78, 0x31, 0x31, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_EMSCRIPTEN_CANVAS_ID_STRING \"SDL.window.emscripten.canvas_id\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_EMSCRIPTEN_CANVAS_ID_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x65, 0x6D, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x65, 0x6E, 0x2E, 0x63, 0x61, 0x6E, 0x76, 0x61, 0x73, 0x5F, 0x69, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_WINDOW_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING \"SDL.window.emscripten.keyboard_element\"")]
        public static ReadOnlySpan<byte> SDL_PROP_WINDOW_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x2E, 0x65, 0x6D, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x65, 0x6E, 0x2E, 0x6B, 0x65, 0x79, 0x62, 0x6F, 0x61, 0x72, 0x64, 0x5F, 0x65, 0x6C, 0x65, 0x6D, 0x65, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define SDL_WINDOW_SURFACE_VSYNC_DISABLED 0")]
        public const int SDL_WINDOW_SURFACE_VSYNC_DISABLED = 0;

        [NativeTypeName("#define SDL_WINDOW_SURFACE_VSYNC_ADAPTIVE (-1)")]
        public const int SDL_WINDOW_SURFACE_VSYNC_ADAPTIVE = (-1);
    }
}
