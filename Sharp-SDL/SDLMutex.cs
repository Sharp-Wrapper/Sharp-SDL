using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Mutex
    {
    }

    public partial struct SDL_RWLock
    {
    }

    public partial struct SDL_Semaphore
    {
    }

    public partial struct SDL_Condition
    {
    }

    public enum SDL_InitStatus
    {
        SDL_INIT_STATUS_UNINITIALIZED,
        SDL_INIT_STATUS_INITIALIZING,
        SDL_INIT_STATUS_INITIALIZED,
        SDL_INIT_STATUS_UNINITIALIZING,
    }

    public unsafe partial struct SDL_InitState
    {
        public SDL_AtomicInt status;

        [NativeTypeName("SDL_ThreadID")]
        public ulong thread;

        public void* reserved;
    }

    public static unsafe partial class SDLMutex
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Mutex* SDL_CreateMutex();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_TryLockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_RWLock* SDL_CreateRWLock();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockRWLockForReading(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockRWLockForWriting(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_TryLockRWLockForReading(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_TryLockRWLockForWriting(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockRWLock(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyRWLock(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Semaphore* SDL_CreateSemaphore([NativeTypeName("Uint32")] uint initial_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroySemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_WaitSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_TryWaitSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WaitSemaphoreTimeout(SDL_Semaphore* sem, [NativeTypeName("Sint32")] int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SignalSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_GetSemaphoreValue(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Condition* SDL_CreateCondition();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SignalCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BroadcastCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_WaitCondition(SDL_Condition* cond, SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WaitConditionTimeout(SDL_Condition* cond, SDL_Mutex* mutex, [NativeTypeName("Sint32")] int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ShouldInit(SDL_InitState* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ShouldQuit(SDL_InitState* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetInitialized(SDL_InitState* state, [NativeTypeName("bool")] byte initialized);
    }
}
