using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_AtomicInt
    {
        public int value;
    }

    public partial struct SDL_AtomicU32
    {
        [NativeTypeName("Uint32")]
        public uint value;
    }

    public static unsafe partial class SDLAtomic
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_MemoryBarrierReleaseFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_MemoryBarrierAcquireFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CompareAndSwapAtomicInt(SDL_AtomicInt* a, int oldval, int newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetAtomicInt(SDL_AtomicInt* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetAtomicInt(SDL_AtomicInt* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AddAtomicInt(SDL_AtomicInt* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CompareAndSwapAtomicU32(SDL_AtomicU32* a, [NativeTypeName("Uint32")] uint oldval, [NativeTypeName("Uint32")] uint newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_SetAtomicU32(SDL_AtomicU32* a, [NativeTypeName("Uint32")] uint v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_GetAtomicU32(SDL_AtomicU32* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_AddAtomicU32(SDL_AtomicU32* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_SetAtomicPointer(void** a, void* v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetAtomicPointer(void** a);
    }
}
