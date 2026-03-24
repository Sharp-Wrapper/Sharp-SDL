using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public enum SDL_ScaleMode
    {
        SDL_SCALEMODE_INVALID = -1,
        SDL_SCALEMODE_NEAREST,
        SDL_SCALEMODE_LINEAR,
        SDL_SCALEMODE_PIXELART,
    }

    public enum SDL_FlipMode
    {
        SDL_FLIP_NONE,
        SDL_FLIP_HORIZONTAL,
        SDL_FLIP_VERTICAL,
        SDL_FLIP_HORIZONTAL_AND_VERTICAL = (SDL_FLIP_HORIZONTAL | SDL_FLIP_VERTICAL),
    }

    public unsafe partial struct SDL_Surface
    {
        [NativeTypeName("SDL_SurfaceFlags")]
        public uint flags;

        public SDL_PixelFormat format;

        public int w;

        public int h;

        public int pitch;

        public void* pixels;

        public int refcount;

        public void* reserved;
    }

    public static unsafe partial class SDLSurface
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_CreateSurface(int width, int height, SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_CreateSurfaceFrom(int width, int height, SDL_PixelFormat format, void* pixels, int pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroySurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetSurfaceProperties(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Colorspace SDL_GetSurfaceColorspace(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Palette* SDL_CreateSurfacePalette(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Palette* SDL_GetSurfacePalette(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_AddSurfaceAlternateImage(SDL_Surface* surface, SDL_Surface* image);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SurfaceHasAlternateImages(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface** SDL_GetSurfaceImages(SDL_Surface* surface, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RemoveSurfaceAlternateImages(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_LockSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_LoadSurface_IO(SDL_IOStream* src, [NativeTypeName("bool")] byte closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_LoadSurface([NativeTypeName("const char *")] sbyte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_LoadBMP_IO(SDL_IOStream* src, [NativeTypeName("bool")] byte closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_LoadBMP([NativeTypeName("const char *")] sbyte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SaveBMP_IO(SDL_Surface* surface, SDL_IOStream* dst, [NativeTypeName("bool")] byte closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SaveBMP(SDL_Surface* surface, [NativeTypeName("const char *")] sbyte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_LoadPNG_IO(SDL_IOStream* src, [NativeTypeName("bool")] byte closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_LoadPNG([NativeTypeName("const char *")] sbyte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SavePNG_IO(SDL_Surface* surface, SDL_IOStream* dst, [NativeTypeName("bool")] byte closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SavePNG(SDL_Surface* surface, [NativeTypeName("const char *")] sbyte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetSurfaceRLE(SDL_Surface* surface, [NativeTypeName("bool")] byte enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SurfaceHasRLE(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("bool")] byte enabled, [NativeTypeName("Uint32")] uint key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SurfaceHasColorKey(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetSurfaceColorKey(SDL_Surface* surface, [NativeTypeName("Uint32 *")] uint* key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetSurfaceColorMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetSurfaceAlphaMod(SDL_Surface* surface, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetSurfaceBlendMode(SDL_Surface* surface, [NativeTypeName("SDL_BlendMode")] uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetSurfaceBlendMode(SDL_Surface* surface, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetSurfaceClipRect(SDL_Surface* surface, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_FlipSurface(SDL_Surface* surface, SDL_FlipMode flip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_RotateSurface(SDL_Surface* surface, float angle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_DuplicateSurface(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_ScaleSurface(SDL_Surface* surface, int width, int height, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_ConvertSurface(SDL_Surface* surface, SDL_PixelFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_ConvertSurfaceAndColorspace(SDL_Surface* surface, SDL_PixelFormat format, SDL_Palette* palette, SDL_Colorspace colorspace, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ConvertPixels(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, void* dst, int dst_pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ConvertPixelsAndColorspace(int width, int height, SDL_PixelFormat src_format, SDL_Colorspace src_colorspace, [NativeTypeName("SDL_PropertiesID")] uint src_properties, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, SDL_Colorspace dst_colorspace, [NativeTypeName("SDL_PropertiesID")] uint dst_properties, void* dst, int dst_pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_PremultiplyAlpha(int width, int height, SDL_PixelFormat src_format, [NativeTypeName("const void *")] void* src, int src_pitch, SDL_PixelFormat dst_format, void* dst, int dst_pitch, [NativeTypeName("bool")] byte linear);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_PremultiplySurfaceAlpha(SDL_Surface* surface, [NativeTypeName("bool")] byte linear);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ClearSurface(SDL_Surface* surface, float r, float g, float b, float a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_FillSurfaceRect(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_FillSurfaceRects(SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rects, int count, [NativeTypeName("Uint32")] uint color);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_BlitSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_BlitSurfaceUnchecked(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_BlitSurfaceScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_BlitSurfaceUncheckedScaled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_StretchSurface(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_BlitSurfaceTiled(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_BlitSurfaceTiledWithScale(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_BlitSurface9Grid(SDL_Surface* src, [NativeTypeName("const SDL_Rect *")] SDL_Rect* srcrect, int left_width, int right_width, int top_height, int bottom_height, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, [NativeTypeName("const SDL_Rect *")] SDL_Rect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_MapSurfaceRGB(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_MapSurfaceRGBA(SDL_Surface* surface, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ReadSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ReadSurfacePixelFloat(SDL_Surface* surface, int x, int y, float* r, float* g, float* b, float* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WriteSurfacePixel(SDL_Surface* surface, int x, int y, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WriteSurfacePixelFloat(SDL_Surface* surface, int x, int y, float r, float g, float b, float a);

        [NativeTypeName("#define SDL_SURFACE_PREALLOCATED 0x00000001u")]
        public const uint SDL_SURFACE_PREALLOCATED = 0x00000001U;

        [NativeTypeName("#define SDL_SURFACE_LOCK_NEEDED 0x00000002u")]
        public const uint SDL_SURFACE_LOCK_NEEDED = 0x00000002U;

        [NativeTypeName("#define SDL_SURFACE_LOCKED 0x00000004u")]
        public const uint SDL_SURFACE_LOCKED = 0x00000004U;

        [NativeTypeName("#define SDL_SURFACE_SIMD_ALIGNED 0x00000008u")]
        public const uint SDL_SURFACE_SIMD_ALIGNED = 0x00000008U;

        [NativeTypeName("#define SDL_PROP_SURFACE_SDR_WHITE_POINT_FLOAT \"SDL.surface.SDR_white_point\"")]
        public static ReadOnlySpan<byte> SDL_PROP_SURFACE_SDR_WHITE_POINT_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x2E, 0x53, 0x44, 0x52, 0x5F, 0x77, 0x68, 0x69, 0x74, 0x65, 0x5F, 0x70, 0x6F, 0x69, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_SURFACE_HDR_HEADROOM_FLOAT \"SDL.surface.HDR_headroom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_SURFACE_HDR_HEADROOM_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x2E, 0x48, 0x44, 0x52, 0x5F, 0x68, 0x65, 0x61, 0x64, 0x72, 0x6F, 0x6F, 0x6D, 0x00 };

        [NativeTypeName("#define SDL_PROP_SURFACE_TONEMAP_OPERATOR_STRING \"SDL.surface.tonemap\"")]
        public static ReadOnlySpan<byte> SDL_PROP_SURFACE_TONEMAP_OPERATOR_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x2E, 0x74, 0x6F, 0x6E, 0x65, 0x6D, 0x61, 0x70, 0x00 };

        [NativeTypeName("#define SDL_PROP_SURFACE_HOTSPOT_X_NUMBER \"SDL.surface.hotspot.x\"")]
        public static ReadOnlySpan<byte> SDL_PROP_SURFACE_HOTSPOT_X_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x2E, 0x68, 0x6F, 0x74, 0x73, 0x70, 0x6F, 0x74, 0x2E, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PROP_SURFACE_HOTSPOT_Y_NUMBER \"SDL.surface.hotspot.y\"")]
        public static ReadOnlySpan<byte> SDL_PROP_SURFACE_HOTSPOT_Y_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x2E, 0x68, 0x6F, 0x74, 0x73, 0x70, 0x6F, 0x74, 0x2E, 0x79, 0x00 };

        [NativeTypeName("#define SDL_PROP_SURFACE_ROTATION_FLOAT \"SDL.surface.rotation\"")]
        public static ReadOnlySpan<byte> SDL_PROP_SURFACE_ROTATION_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x2E, 0x72, 0x6F, 0x74, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };
    }
}
