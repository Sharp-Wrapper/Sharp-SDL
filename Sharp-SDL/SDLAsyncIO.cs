using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_AsyncIO
    {
    }

    public enum SDL_AsyncIOTaskType
    {
        SDL_ASYNCIO_TASK_READ,
        SDL_ASYNCIO_TASK_WRITE,
        SDL_ASYNCIO_TASK_CLOSE,
    }

    public enum SDL_AsyncIOResult
    {
        SDL_ASYNCIO_COMPLETE,
        SDL_ASYNCIO_FAILURE,
        SDL_ASYNCIO_CANCELED,
    }

    public unsafe partial struct SDL_AsyncIOOutcome
    {
        public SDL_AsyncIO* asyncio;

        public SDL_AsyncIOTaskType type;

        public SDL_AsyncIOResult result;

        public void* buffer;

        [NativeTypeName("Uint64")]
        public ulong offset;

        [NativeTypeName("Uint64")]
        public ulong bytes_requested;

        [NativeTypeName("Uint64")]
        public ulong bytes_transferred;

        public void* userdata;
    }

    public partial struct SDL_AsyncIOQueue
    {
    }

    public static unsafe partial class SDLAsyncIO
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AsyncIO* SDL_AsyncIOFromFile([NativeTypeName("const char *")] sbyte* file, [NativeTypeName("const char *")] sbyte* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Sint64")]
        public static extern long SDL_GetAsyncIOSize(SDL_AsyncIO* asyncio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ReadAsyncIO(SDL_AsyncIO* asyncio, void* ptr, [NativeTypeName("Uint64")] ulong offset, [NativeTypeName("Uint64")] ulong size, SDL_AsyncIOQueue* queue, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WriteAsyncIO(SDL_AsyncIO* asyncio, void* ptr, [NativeTypeName("Uint64")] ulong offset, [NativeTypeName("Uint64")] ulong size, SDL_AsyncIOQueue* queue, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CloseAsyncIO(SDL_AsyncIO* asyncio, [NativeTypeName("bool")] byte flush, SDL_AsyncIOQueue* queue, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AsyncIOQueue* SDL_CreateAsyncIOQueue();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyAsyncIOQueue(SDL_AsyncIOQueue* queue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WaitAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome, [NativeTypeName("Sint32")] int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SignalAsyncIOQueue(SDL_AsyncIOQueue* queue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_LoadFileAsync([NativeTypeName("const char *")] sbyte* file, SDL_AsyncIOQueue* queue, void* userdata);
    }
}
