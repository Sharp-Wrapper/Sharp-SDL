using static Sharp_SDL.SDLStdInc;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Point
    {
        public int x;

        public int y;
    }

    public partial struct SDL_FPoint
    {
        public float x;

        public float y;
    }

    public partial struct SDL_Rect
    {
        public int x;

        public int y;

        public int w;

        public int h;
    }

    public partial struct SDL_FRect
    {
        public float x;

        public float y;

        public float w;

        public float h;
    }

    public static unsafe partial class SDLRect
    {
        public static void SDL_RectToFRect([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_FRect* frect)
        {
            frect->x = (float)(rect->x);
            frect->y = (float)(rect->y);
            frect->w = (float)(rect->w);
            frect->h = (float)(rect->h);
        }

        public static bool SDL_PointInRect([NativeTypeName("const SDL_Point *")] SDL_Point* p, [NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
        {
            return ((p) != null && (r) != null && (p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? true : false;
        }

        public static bool SDL_RectEmpty([NativeTypeName("const SDL_Rect *")] SDL_Rect* r)
        {
            return ((r == null) || (r->w <= 0) || (r->h <= 0)) ? true : false;
        }

        public static bool SDL_RectsEqual([NativeTypeName("const SDL_Rect *")] SDL_Rect* a, [NativeTypeName("const SDL_Rect *")] SDL_Rect* b)
        {
            return ((a) != null && (b) != null && (a->x == b->x) && (a->y == b->y) && (a->w == b->w) && (a->h == b->h)) ? true : false;
        }

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasRectIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRectIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRectUnion([NativeTypeName("const SDL_Rect *")] SDL_Rect* A, [NativeTypeName("const SDL_Rect *")] SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRectEnclosingPoints([NativeTypeName("const SDL_Point *")] SDL_Point* points, int count, [NativeTypeName("const SDL_Rect *")] SDL_Rect* clip, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRectAndLineIntersection([NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, int* X1, int* Y1, int* X2, int* Y2);

        public static bool SDL_PointInRectFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* p, [NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
        {
            return ((p) != null && (r) != null && (p->x >= r->x) && (p->x <= (r->x + r->w)) && (p->y >= r->y) && (p->y <= (r->y + r->h))) ? true : false;
        }

        public static bool SDL_RectEmptyFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* r)
        {
            return ((r == null) || (r->w < 0.0f) || (r->h < 0.0f)) ? true : false;
        }

        public static bool SDL_RectsEqualEpsilon([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b, float epsilon)
        {
            return ((a) != null && (b) != null && ((a == b) || ((SDL_fabsf(a->x - b->x) <= epsilon) && (SDL_fabsf(a->y - b->y) <= epsilon) && (SDL_fabsf(a->w - b->w) <= epsilon) && (SDL_fabsf(a->h - b->h) <= epsilon)))) ? true : false;
        }

        public static bool SDL_RectsEqualFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* a, [NativeTypeName("const SDL_FRect *")] SDL_FRect* b)
        {
            return SDL_RectsEqualEpsilon(a, b, 1.1920928955078125e-07F);
        }

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_HasRectIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRectIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRectUnionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* A, [NativeTypeName("const SDL_FRect *")] SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRectEnclosingPointsFloat([NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count, [NativeTypeName("const SDL_FRect *")] SDL_FRect* clip, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRectAndLineIntersectionFloat([NativeTypeName("const SDL_FRect *")] SDL_FRect* rect, float* X1, float* Y1, float* X2, float* Y2);
    }
}
