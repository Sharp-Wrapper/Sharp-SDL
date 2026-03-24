using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_DateTime
    {
        public int year;

        public int month;

        public int day;

        public int hour;

        public int minute;

        public int second;

        public int nanosecond;

        public int day_of_week;

        public int utc_offset;
    }

    public enum SDL_DateFormat
    {
        SDL_DATE_FORMAT_YYYYMMDD = 0,
        SDL_DATE_FORMAT_DDMMYYYY = 1,
        SDL_DATE_FORMAT_MMDDYYYY = 2,
    }

    public enum SDL_TimeFormat
    {
        SDL_TIME_FORMAT_24HR = 0,
        SDL_TIME_FORMAT_12HR = 1,
    }

    public static unsafe partial class SDLTime
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetDateTimeLocalePreferences(SDL_DateFormat* dateFormat, SDL_TimeFormat* timeFormat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetCurrentTime([NativeTypeName("SDL_Time *")] long* ticks);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_TimeToDateTime([NativeTypeName("SDL_Time")] long ticks, SDL_DateTime* dt, [NativeTypeName("bool")] byte localTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_DateTimeToTime([NativeTypeName("const SDL_DateTime *")] SDL_DateTime* dt, [NativeTypeName("SDL_Time *")] long* ticks);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_TimeToWindows([NativeTypeName("SDL_Time")] long ticks, [NativeTypeName("Uint32 *")] uint* dwLowDateTime, [NativeTypeName("Uint32 *")] uint* dwHighDateTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_Time")]
        public static extern long SDL_TimeFromWindows([NativeTypeName("Uint32")] uint dwLowDateTime, [NativeTypeName("Uint32")] uint dwHighDateTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDaysInMonth(int year, int month);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDayOfYear(int year, int month, int day);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDayOfWeek(int year, int month, int day);
    }
}
