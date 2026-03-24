using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public unsafe partial struct SDL_alignment_test
    {
        [NativeTypeName("Uint8")]
        public byte a;

        public void* b;
    }

    public enum SDL_DUMMY_ENUM
    {
        DUMMY_ENUM_VALUE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* SDL_malloc_func([NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* SDL_calloc_func([NativeTypeName("size_t")] UIntPtr nmemb, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* SDL_realloc_func(void* mem, [NativeTypeName("size_t")] UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_free_func(void* mem);

    public partial struct SDL_Environment
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SDL_CompareCallback([NativeTypeName("const void *")] void* a, [NativeTypeName("const void *")] void* b);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SDL_CompareCallback_r(void* userdata, [NativeTypeName("const void *")] void* a, [NativeTypeName("const void *")] void* b);

    public partial struct SDL_iconv_data_t
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void SDL_FunctionPointer();

    public static unsafe partial class SDLStdInc
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_malloc([NativeTypeName("size_t")] UIntPtr size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetOriginalMemoryFunctions([NativeTypeName("SDL_malloc_func *")] IntPtr* malloc_func, [NativeTypeName("SDL_calloc_func *")] IntPtr* calloc_func, [NativeTypeName("SDL_realloc_func *")] IntPtr* realloc_func, [NativeTypeName("SDL_free_func *")] IntPtr* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetMemoryFunctions([NativeTypeName("SDL_malloc_func *")] IntPtr* malloc_func, [NativeTypeName("SDL_calloc_func *")] IntPtr* calloc_func, [NativeTypeName("SDL_realloc_func *")] IntPtr* realloc_func, [NativeTypeName("SDL_free_func *")] IntPtr* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetMemoryFunctions([NativeTypeName("SDL_malloc_func")] IntPtr malloc_func, [NativeTypeName("SDL_calloc_func")] IntPtr calloc_func, [NativeTypeName("SDL_realloc_func")] IntPtr realloc_func, [NativeTypeName("SDL_free_func")] IntPtr free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_aligned_alloc([NativeTypeName("size_t")] UIntPtr alignment, [NativeTypeName("size_t")] UIntPtr size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_aligned_free(void* mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumAllocations();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Environment* SDL_GetEnvironment();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Environment* SDL_CreateEnvironment([NativeTypeName("bool")] byte populated);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** SDL_GetEnvironmentVariables(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value, [NativeTypeName("bool")] byte overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_UnsetEnvironmentVariable(SDL_Environment* env, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyEnvironment(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_getenv([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_getenv_unsafe([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_setenv_unsafe([NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* value, int overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_unsetenv_unsafe([NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_qsort(void* @base, [NativeTypeName("size_t")] UIntPtr nmemb, [NativeTypeName("size_t")] UIntPtr size, [NativeTypeName("SDL_CompareCallback")] IntPtr compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_bsearch([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] UIntPtr nmemb, [NativeTypeName("size_t")] UIntPtr size, [NativeTypeName("SDL_CompareCallback")] IntPtr compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_qsort_r(void* @base, [NativeTypeName("size_t")] UIntPtr nmemb, [NativeTypeName("size_t")] UIntPtr size, [NativeTypeName("SDL_CompareCallback_r")] IntPtr compare, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_bsearch_r([NativeTypeName("const void *")] void* key, [NativeTypeName("const void *")] void* @base, [NativeTypeName("size_t")] UIntPtr nmemb, [NativeTypeName("size_t")] UIntPtr size, [NativeTypeName("SDL_CompareCallback_r")] IntPtr compare, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_abs(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isalpha(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isalnum(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isblank(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_iscntrl(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isxdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ispunct(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isspace(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_islower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isprint(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isgraph(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_toupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_tolower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint16")]
        public static extern ushort SDL_crc16([NativeTypeName("Uint16")] ushort crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_crc32([NativeTypeName("Uint32")] uint crc, [NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_murmur3_32([NativeTypeName("const void *")] void* data, [NativeTypeName("size_t")] UIntPtr len, [NativeTypeName("Uint32")] uint seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_memset4(void* dst, [NativeTypeName("Uint32")] uint val, [NativeTypeName("size_t")] UIntPtr dwords);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_memcmp([NativeTypeName("const void *")] void* s1, [NativeTypeName("const void *")] void* s2, [NativeTypeName("size_t")] UIntPtr len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_wcslen([NativeTypeName("const wchar_t *")] ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_wcsnlen([NativeTypeName("const wchar_t *")] ushort* wstr, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_wcslcpy([NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("const wchar_t *")] ushort* src, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_wcslcat([NativeTypeName("wchar_t *")] ushort* dst, [NativeTypeName("const wchar_t *")] ushort* src, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern ushort* SDL_wcsdup([NativeTypeName("const wchar_t *")] ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern ushort* SDL_wcsstr([NativeTypeName("const wchar_t *")] ushort* haystack, [NativeTypeName("const wchar_t *")] ushort* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern ushort* SDL_wcsnstr([NativeTypeName("const wchar_t *")] ushort* haystack, [NativeTypeName("const wchar_t *")] ushort* needle, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcscmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcsncmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcscasecmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcsncasecmp([NativeTypeName("const wchar_t *")] ushort* str1, [NativeTypeName("const wchar_t *")] ushort* str2, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SDL_wcstol([NativeTypeName("const wchar_t *")] ushort* str, [NativeTypeName("wchar_t **")] ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_strlen([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_strnlen([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_strlcpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_utf8strlcpy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] UIntPtr dst_bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_strlcat([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strdup([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strndup([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strrev([NativeTypeName("char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strupr([NativeTypeName("char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strlwr([NativeTypeName("char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strchr([NativeTypeName("const char *")] sbyte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strrchr([NativeTypeName("const char *")] sbyte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strstr([NativeTypeName("const char *")] sbyte* haystack, [NativeTypeName("const char *")] sbyte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strnstr([NativeTypeName("const char *")] sbyte* haystack, [NativeTypeName("const char *")] sbyte* needle, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strcasestr([NativeTypeName("const char *")] sbyte* haystack, [NativeTypeName("const char *")] sbyte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strtok_r([NativeTypeName("char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* delim, [NativeTypeName("char **")] sbyte** saveptr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_utf8strlen([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_utf8strnlen([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] UIntPtr bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_itoa(int value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_uitoa([NativeTypeName("unsigned int")] uint value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_ltoa([NativeTypeName("long")] int value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_ultoa([NativeTypeName("unsigned long")] uint value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_lltoa([NativeTypeName("long long")] long value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_ulltoa([NativeTypeName("unsigned long long")] ulong value, [NativeTypeName("char *")] sbyte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_atoi([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_atof([NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SDL_strtol([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern uint SDL_strtoul([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long long")]
        public static extern long SDL_strtoll([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long long")]
        public static extern ulong SDL_strtoull([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_strtod([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("char **")] sbyte** endp);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strcmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strncmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strcasecmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strncasecmp([NativeTypeName("const char *")] sbyte* str1, [NativeTypeName("const char *")] sbyte* str2, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_strpbrk([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* breakset);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_StepUTF8([NativeTypeName("const char **")] sbyte** pstr, [NativeTypeName("size_t *")] UIntPtr* pslen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_StepBackUTF8([NativeTypeName("const char *")] sbyte* start, [NativeTypeName("const char **")] sbyte** pstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_UCS4ToUTF8([NativeTypeName("Uint32")] uint codepoint, [NativeTypeName("char *")] sbyte* dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_sscanf([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_snprintf([NativeTypeName("char *")] sbyte* text, [NativeTypeName("size_t")] UIntPtr maxlen, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_swprintf([NativeTypeName("wchar_t *")] ushort* text, [NativeTypeName("size_t")] UIntPtr maxlen, [NativeTypeName("const wchar_t *")] ushort* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_vswprintf([NativeTypeName("wchar_t *")] ushort* text, [NativeTypeName("size_t")] UIntPtr maxlen, [NativeTypeName("const wchar_t *")] ushort* fmt, [NativeTypeName("va_list")] sbyte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_asprintf([NativeTypeName("char **")] sbyte** strp, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_srand([NativeTypeName("Uint64")] ulong seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint32")]
        public static extern int SDL_rand([NativeTypeName("Sint32")] int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_randf();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_rand_bits();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint32")]
        public static extern int SDL_rand_r([NativeTypeName("Uint64 *")] ulong* state, [NativeTypeName("Sint32")] int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_randf_r([NativeTypeName("Uint64 *")] ulong* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_rand_bits_r([NativeTypeName("Uint64 *")] ulong* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_acos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_acosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_asin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_asinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_atan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_atanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_atan2(double y, double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_atan2f(float y, float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_ceil(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_ceilf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_copysign(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_copysignf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_cos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_cosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_exp(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_expf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_fabs(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_fabsf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_floor(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_floorf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_trunc(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_truncf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_fmod(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_fmodf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isinf(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isinff(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isnan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isnanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_log(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_logf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_log10(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_log10f(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_modf(double x, double* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_modff(float x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_pow(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_powf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_round(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_roundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SDL_lround(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int SDL_lroundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_scalbn(double x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_scalbnf(float x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_sin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_sinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_sqrt(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_sqrtf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_tan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_tanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_iconv_t")]
        public static extern SDL_iconv_data_t* SDL_iconv_open([NativeTypeName("const char *")] sbyte* tocode, [NativeTypeName("const char *")] sbyte* fromcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_iconv_close([NativeTypeName("SDL_iconv_t")] SDL_iconv_data_t* cd);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern UIntPtr SDL_iconv([NativeTypeName("SDL_iconv_t")] SDL_iconv_data_t* cd, [NativeTypeName("const char **")] sbyte** inbuf, [NativeTypeName("size_t *")] UIntPtr* inbytesleft, [NativeTypeName("char **")] sbyte** outbuf, [NativeTypeName("size_t *")] UIntPtr* outbytesleft);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* SDL_iconv_string([NativeTypeName("const char *")] sbyte* tocode, [NativeTypeName("const char *")] sbyte* fromcode, [NativeTypeName("const char *")] sbyte* inbuf, [NativeTypeName("size_t")] UIntPtr inbytesleft);

        [NativeTypeName("#define SDL_SIZE_MAX SIZE_MAX")]
        public const ulong SDL_SIZE_MAX = 0xffffffffffffffffUL;

        [NativeTypeName("#define SDL_MAX_SINT8 ((Sint8)0x7F)")]
        public const sbyte SDL_MAX_SINT8 = ((sbyte)(0x7F));

        [NativeTypeName("#define SDL_MIN_SINT8 ((Sint8)(~0x7F))")]
        public const sbyte SDL_MIN_SINT8 = ((sbyte)(~0x7F));

        [NativeTypeName("#define SDL_MAX_UINT8 ((Uint8)0xFF)")]
        public const byte SDL_MAX_UINT8 = ((byte)(0xFF));

        [NativeTypeName("#define SDL_MIN_UINT8 ((Uint8)0x00)")]
        public const byte SDL_MIN_UINT8 = ((byte)(0x00));

        [NativeTypeName("#define SDL_MAX_SINT16 ((Sint16)0x7FFF)")]
        public const short SDL_MAX_SINT16 = ((short)(0x7FFF));

        [NativeTypeName("#define SDL_MIN_SINT16 ((Sint16)(~0x7FFF))")]
        public const short SDL_MIN_SINT16 = ((short)(~0x7FFF));

        [NativeTypeName("#define SDL_MAX_UINT16 ((Uint16)0xFFFF)")]
        public const ushort SDL_MAX_UINT16 = ((ushort)(0xFFFF));

        [NativeTypeName("#define SDL_MIN_UINT16 ((Uint16)0x0000)")]
        public const ushort SDL_MIN_UINT16 = ((ushort)(0x0000));

        [NativeTypeName("#define SDL_MAX_SINT32 ((Sint32)0x7FFFFFFF)")]
        public const int SDL_MAX_SINT32 = ((int)(0x7FFFFFFF));

        [NativeTypeName("#define SDL_MIN_SINT32 ((Sint32)(~0x7FFFFFFF))")]
        public const int SDL_MIN_SINT32 = ((int)(~0x7FFFFFFF));

        [NativeTypeName("#define SDL_MAX_UINT32 ((Uint32)0xFFFFFFFFu)")]
        public const uint SDL_MAX_UINT32 = ((uint)(0xFFFFFFFFU));

        [NativeTypeName("#define SDL_MIN_UINT32 ((Uint32)0x00000000)")]
        public const uint SDL_MIN_UINT32 = ((uint)(0x00000000));

        [NativeTypeName("#define SDL_MAX_SINT64 SDL_SINT64_C(0x7FFFFFFFFFFFFFFF)")]
        public const long SDL_MAX_SINT64 = (0x7FFFFFFFFFFFFFFFL);

        [NativeTypeName("#define SDL_MIN_SINT64 ~SDL_SINT64_C(0x7FFFFFFFFFFFFFFF)")]
        public const long SDL_MIN_SINT64 = ~(0x7FFFFFFFFFFFFFFFL);

        [NativeTypeName("#define SDL_MAX_UINT64 SDL_UINT64_C(0xFFFFFFFFFFFFFFFF)")]
        public const ulong SDL_MAX_UINT64 = (0xFFFFFFFFFFFFFFFFUL);

        [NativeTypeName("#define SDL_MIN_UINT64 SDL_UINT64_C(0x0000000000000000)")]
        public const ulong SDL_MIN_UINT64 = (0x0000000000000000UL);

        [NativeTypeName("#define SDL_MAX_TIME SDL_MAX_SINT64")]
        public const long SDL_MAX_TIME = (0x7FFFFFFFFFFFFFFFL);

        [NativeTypeName("#define SDL_MIN_TIME SDL_MIN_SINT64")]
        public const long SDL_MIN_TIME = ~(0x7FFFFFFFFFFFFFFFL);

        [NativeTypeName("#define SDL_FLT_EPSILON 1.1920928955078125e-07F")]
        public const float SDL_FLT_EPSILON = 1.1920928955078125e-07F;

        [NativeTypeName("#define SDL_PRIs64 \"I64d\"")]
        public static ReadOnlySpan<byte> SDL_PRIs64 => new byte[] { 0x49, 0x36, 0x34, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PRIu64 \"I64u\"")]
        public static ReadOnlySpan<byte> SDL_PRIu64 => new byte[] { 0x49, 0x36, 0x34, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PRIx64 \"I64x\"")]
        public static ReadOnlySpan<byte> SDL_PRIx64 => new byte[] { 0x49, 0x36, 0x34, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PRIX64 \"I64X\"")]
        public static ReadOnlySpan<byte> SDL_PRIX64 => new byte[] { 0x49, 0x36, 0x34, 0x58, 0x00 };

        [NativeTypeName("#define SDL_PRIs32 \"d\"")]
        public static ReadOnlySpan<byte> SDL_PRIs32 => new byte[] { 0x64, 0x00 };

        [NativeTypeName("#define SDL_PRIu32 \"u\"")]
        public static ReadOnlySpan<byte> SDL_PRIu32 => new byte[] { 0x75, 0x00 };

        [NativeTypeName("#define SDL_PRIx32 \"x\"")]
        public static ReadOnlySpan<byte> SDL_PRIx32 => new byte[] { 0x78, 0x00 };

        [NativeTypeName("#define SDL_PRIX32 \"X\"")]
        public static ReadOnlySpan<byte> SDL_PRIX32 => new byte[] { 0x58, 0x00 };

        [NativeTypeName("#define SDL_PRILL_PREFIX \"I64\"")]
        public static ReadOnlySpan<byte> SDL_PRILL_PREFIX => new byte[] { 0x49, 0x36, 0x34, 0x00 };

        [NativeTypeName("#define SDL_PRILLd SDL_PRILL_PREFIX \"d\"")]
        public static ReadOnlySpan<byte> SDL_PRILLd => new byte[] { 0x49, 0x36, 0x34, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PRILLu SDL_PRILL_PREFIX \"u\"")]
        public static ReadOnlySpan<byte> SDL_PRILLu => new byte[] { 0x49, 0x36, 0x34, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PRILLx SDL_PRILL_PREFIX \"x\"")]
        public static ReadOnlySpan<byte> SDL_PRILLx => new byte[] { 0x49, 0x36, 0x34, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PRILLX SDL_PRILL_PREFIX \"X\"")]
        public static ReadOnlySpan<byte> SDL_PRILLX => new byte[] { 0x49, 0x36, 0x34, 0x58, 0x00 };

        [NativeTypeName("#define SDL_INVALID_UNICODE_CODEPOINT 0xFFFD")]
        public const int SDL_INVALID_UNICODE_CODEPOINT = 0xFFFD;

        [NativeTypeName("#define SDL_PI_D 3.141592653589793238462643383279502884")]
        public const double SDL_PI_D = 3.141592653589793238462643383279502884;

        [NativeTypeName("#define SDL_PI_F 3.141592653589793238462643383279502884F")]
        public const float SDL_PI_F = 3.141592653589793238462643383279502884F;

        [NativeTypeName("#define SDL_ICONV_ERROR (size_t)-1")]
        public static readonly UIntPtr SDL_ICONV_ERROR = unchecked((nuint)(-1));

        [NativeTypeName("#define SDL_ICONV_E2BIG (size_t)-2")]
        public static readonly UIntPtr SDL_ICONV_E2BIG = unchecked((nuint)(-2));

        [NativeTypeName("#define SDL_ICONV_EILSEQ (size_t)-3")]
        public static readonly UIntPtr SDL_ICONV_EILSEQ = unchecked((nuint)(-3));

        [NativeTypeName("#define SDL_ICONV_EINVAL (size_t)-4")]
        public static readonly UIntPtr SDL_ICONV_EINVAL = unchecked((nuint)(-4));
    }
}
