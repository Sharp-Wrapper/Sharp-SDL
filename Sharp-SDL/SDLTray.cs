using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Tray
    {
    }

    public partial struct SDL_TrayMenu
    {
    }

    public partial struct SDL_TrayEntry
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_TrayCallback(void* userdata, SDL_TrayEntry* entry);

    public static unsafe partial class SDLTray
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Tray* SDL_CreateTray(SDL_Surface* icon, [NativeTypeName("const char *")] sbyte* tooltip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetTrayIcon(SDL_Tray* tray, SDL_Surface* icon);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetTrayTooltip(SDL_Tray* tray, [NativeTypeName("const char *")] sbyte* tooltip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_TrayMenu* SDL_CreateTrayMenu(SDL_Tray* tray);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_TrayMenu* SDL_CreateTraySubmenu(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_TrayMenu* SDL_GetTrayMenu(SDL_Tray* tray);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_TrayMenu* SDL_GetTraySubmenu(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const SDL_TrayEntry **")]
        public static extern SDL_TrayEntry** SDL_GetTrayEntries(SDL_TrayMenu* menu, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RemoveTrayEntry(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_TrayEntry* SDL_InsertTrayEntryAt(SDL_TrayMenu* menu, int pos, [NativeTypeName("const char *")] sbyte* label, [NativeTypeName("SDL_TrayEntryFlags")] uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetTrayEntryLabel(SDL_TrayEntry* entry, [NativeTypeName("const char *")] sbyte* label);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetTrayEntryLabel(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetTrayEntryChecked(SDL_TrayEntry* entry, [NativeTypeName("bool")] byte @checked);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTrayEntryChecked(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetTrayEntryEnabled(SDL_TrayEntry* entry, [NativeTypeName("bool")] byte enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTrayEntryEnabled(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetTrayEntryCallback(SDL_TrayEntry* entry, [NativeTypeName("SDL_TrayCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ClickTrayEntry(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyTray(SDL_Tray* tray);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_TrayMenu* SDL_GetTrayEntryParent(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_TrayEntry* SDL_GetTrayMenuParentEntry(SDL_TrayMenu* menu);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Tray* SDL_GetTrayMenuParentTray(SDL_TrayMenu* menu);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UpdateTrays();

        [NativeTypeName("#define SDL_TRAYENTRY_BUTTON 0x00000001u")]
        public const uint SDL_TRAYENTRY_BUTTON = 0x00000001U;

        [NativeTypeName("#define SDL_TRAYENTRY_CHECKBOX 0x00000002u")]
        public const uint SDL_TRAYENTRY_CHECKBOX = 0x00000002U;

        [NativeTypeName("#define SDL_TRAYENTRY_SUBMENU 0x00000004u")]
        public const uint SDL_TRAYENTRY_SUBMENU = 0x00000004U;

        [NativeTypeName("#define SDL_TRAYENTRY_DISABLED 0x80000000u")]
        public const uint SDL_TRAYENTRY_DISABLED = 0x80000000U;

        [NativeTypeName("#define SDL_TRAYENTRY_CHECKED 0x40000000u")]
        public const uint SDL_TRAYENTRY_CHECKED = 0x40000000U;
    }
}
