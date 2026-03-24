using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Vertex
    {
        public SDL_FPoint position;

        public SDL_FColor color;

        public SDL_FPoint tex_coord;
    }

    public enum SDL_TextureAccess
    {
        SDL_TEXTUREACCESS_STATIC,
        SDL_TEXTUREACCESS_STREAMING,
        SDL_TEXTUREACCESS_TARGET,
    }

    public enum SDL_TextureAddressMode
    {
        SDL_TEXTURE_ADDRESS_INVALID = -1,
        SDL_TEXTURE_ADDRESS_AUTO,
        SDL_TEXTURE_ADDRESS_CLAMP,
        SDL_TEXTURE_ADDRESS_WRAP,
    }

    public enum SDL_RendererLogicalPresentation
    {
        SDL_LOGICAL_PRESENTATION_DISABLED,
        SDL_LOGICAL_PRESENTATION_STRETCH,
        SDL_LOGICAL_PRESENTATION_LETTERBOX,
        SDL_LOGICAL_PRESENTATION_OVERSCAN,
        SDL_LOGICAL_PRESENTATION_INTEGER_SCALE,
    }

    public partial struct SDL_Renderer
    {
    }

    public partial struct SDL_Texture
    {
        public SDL_PixelFormat format;

        public int w;

        public int h;

        public int refcount;
    }

    public unsafe partial struct SDL_GPURenderStateCreateInfo
    {
        public SDL_GPUShader* fragment_shader;

        [NativeTypeName("Sint32")]
        public int num_sampler_bindings;

        [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
        public SDL_GPUTextureSamplerBinding* sampler_bindings;

        [NativeTypeName("Sint32")]
        public int num_storage_textures;

        [NativeTypeName("SDL_GPUTexture *const *")]
        public SDL_GPUTexture** storage_textures;

        [NativeTypeName("Sint32")]
        public int num_storage_buffers;

        [NativeTypeName("SDL_GPUBuffer *const *")]
        public SDL_GPUBuffer** storage_buffers;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    public partial struct SDL_GPURenderState
    {
    }

    public static unsafe partial class SDLRender
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumRenderDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetRenderDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CreateWindowAndRenderer([NativeTypeName("const char *")] sbyte* title, int width, int height, [NativeTypeName("SDL_WindowFlags")] ulong window_flags, SDL_Window** window, SDL_Renderer** renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_CreateRenderer(SDL_Window* window, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_CreateRendererWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_CreateGPURenderer(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUDevice* SDL_GetGPURendererDevice(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_CreateSoftwareRenderer(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_GetRenderer(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetRenderWindow(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetRendererName(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetRendererProperties(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int w, int h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_CreateTextureWithProperties(SDL_Renderer* renderer, [NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetTextureProperties(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_GetRendererFromTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTextureSize(SDL_Texture* texture, float* w, float* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetTexturePalette(SDL_Texture* texture, SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Palette* SDL_GetTexturePalette(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTextureColorMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTextureColorModFloat(SDL_Texture* texture, float* r, float* g, float* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8")] byte alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetTextureAlphaModFloat(SDL_Texture* texture, float alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTextureAlphaMod(SDL_Texture* texture, [NativeTypeName("Uint8 *")] byte* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTextureAlphaModFloat(SDL_Texture* texture, float* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetTextureBlendMode(SDL_Texture* texture, [NativeTypeName("SDL_BlendMode")] uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTextureBlendMode(SDL_Texture* texture, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_UpdateTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const void *")] void* pixels, int pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_UpdateYUVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* Uplane, int Upitch, [NativeTypeName("const Uint8 *")] byte* Vplane, int Vpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_UpdateNVTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, [NativeTypeName("const Uint8 *")] byte* Yplane, int Ypitch, [NativeTypeName("const Uint8 *")] byte* UVplane, int UVpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_LockTexture(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, void** pixels, int* pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_LockTextureToSurface(SDL_Texture* texture, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect, SDL_Surface** surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_GetRenderTarget(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderLogicalPresentation(SDL_Renderer* renderer, int w, int h, SDL_RendererLogicalPresentation mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderLogicalPresentation(SDL_Renderer* renderer, int* w, int* h, SDL_RendererLogicalPresentation* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderLogicalPresentationRect(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderCoordinatesFromWindow(SDL_Renderer* renderer, float window_x, float window_y, float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, float* window_x, float* window_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderViewport(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderViewportSet(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderSafeArea(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderClipRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderClipEnabled(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8")] byte r, [NativeTypeName("Uint8")] byte g, [NativeTypeName("Uint8")] byte b, [NativeTypeName("Uint8")] byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderDrawColor(SDL_Renderer* renderer, [NativeTypeName("Uint8 *")] byte* r, [NativeTypeName("Uint8 *")] byte* g, [NativeTypeName("Uint8 *")] byte* b, [NativeTypeName("Uint8 *")] byte* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderDrawColorFloat(SDL_Renderer* renderer, float* r, float* g, float* b, float* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderColorScale(SDL_Renderer* renderer, float scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderColorScale(SDL_Renderer* renderer, float* scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderDrawBlendMode(SDL_Renderer* renderer, [NativeTypeName("SDL_BlendMode")] uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderDrawBlendMode(SDL_Renderer* renderer, [NativeTypeName("SDL_BlendMode *")] uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderClear(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderPoint(SDL_Renderer* renderer, float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderPoints(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderLines(SDL_Renderer* renderer, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderFillRect(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderFillRects(SDL_Renderer* renderer, [NativeTypeName("const SDL_FRect *")] SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect, double angle, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* center, SDL_FlipMode flip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderTextureAffine(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* origin, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* right, [NativeTypeName("const SDL_FPoint *")] SDL_FPoint* down);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderTextureTiled(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderTexture9Grid(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderTexture9GridTiled(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_FRect *")] SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, [NativeTypeName("const SDL_FRect *")] SDL_FRect* dstrect, float tileScale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const SDL_Vertex *")] SDL_Vertex* vertices, int num_vertices, [NativeTypeName("const int *")] int* indices, int num_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, [NativeTypeName("const float *")] float* xy, int xy_stride, [NativeTypeName("const SDL_FColor *")] SDL_FColor* color, int color_stride, [NativeTypeName("const float *")] float* uv, int uv_stride, int num_vertices, [NativeTypeName("const void *")] void* indices, int num_indices, int size_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderTextureAddressMode(SDL_Renderer* renderer, SDL_TextureAddressMode u_mode, SDL_TextureAddressMode v_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderTextureAddressMode(SDL_Renderer* renderer, SDL_TextureAddressMode* u_mode, SDL_TextureAddressMode* v_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_RenderReadPixels(SDL_Renderer* renderer, [NativeTypeName("const SDL_Rect *")] SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderPresent(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_FlushRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetRenderMetalLayer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetRenderMetalCommandEncoder(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_AddVulkanRenderSemaphores(SDL_Renderer* renderer, [NativeTypeName("Uint32")] uint wait_stage_mask, [NativeTypeName("Sint64")] long wait_semaphore, [NativeTypeName("Sint64")] long signal_semaphore);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetRenderVSync(SDL_Renderer* renderer, int vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetRenderVSync(SDL_Renderer* renderer, int* vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderDebugText(SDL_Renderer* renderer, float x, float y, [NativeTypeName("const char *")] sbyte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_RenderDebugTextFormat(SDL_Renderer* renderer, float x, float y, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetDefaultTextureScaleMode(SDL_Renderer* renderer, SDL_ScaleMode scale_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetDefaultTextureScaleMode(SDL_Renderer* renderer, SDL_ScaleMode* scale_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPURenderState* SDL_CreateGPURenderState(SDL_Renderer* renderer, [NativeTypeName("const SDL_GPURenderStateCreateInfo *")] SDL_GPURenderStateCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetGPURenderStateFragmentUniforms(SDL_GPURenderState* state, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetGPURenderState(SDL_Renderer* renderer, SDL_GPURenderState* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyGPURenderState(SDL_GPURenderState* state);

        [NativeTypeName("#define SDL_SOFTWARE_RENDERER \"software\"")]
        public static ReadOnlySpan<byte> SDL_SOFTWARE_RENDERER => new byte[] { 0x73, 0x6F, 0x66, 0x74, 0x77, 0x61, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_GPU_RENDERER \"gpu\"")]
        public static ReadOnlySpan<byte> SDL_GPU_RENDERER => new byte[] { 0x67, 0x70, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_NAME_STRING \"SDL.renderer.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_WINDOW_POINTER \"SDL.renderer.create.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_WINDOW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_SURFACE_POINTER \"SDL.renderer.create.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_SURFACE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_OUTPUT_COLORSPACE_NUMBER \"SDL.renderer.create.output_colorspace\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_OUTPUT_COLORSPACE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x75, 0x74, 0x70, 0x75, 0x74, 0x5F, 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x73, 0x70, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_PRESENT_VSYNC_NUMBER \"SDL.renderer.create.present_vsync\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_PRESENT_VSYNC_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x70, 0x72, 0x65, 0x73, 0x65, 0x6E, 0x74, 0x5F, 0x76, 0x73, 0x79, 0x6E, 0x63, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_GPU_DEVICE_POINTER \"SDL.renderer.create.gpu.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_GPU_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_GPU_SHADERS_SPIRV_BOOLEAN \"SDL.renderer.create.gpu.shaders_spirv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_GPU_SHADERS_SPIRV_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x73, 0x5F, 0x73, 0x70, 0x69, 0x72, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_GPU_SHADERS_DXIL_BOOLEAN \"SDL.renderer.create.gpu.shaders_dxil\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_GPU_SHADERS_DXIL_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x73, 0x5F, 0x64, 0x78, 0x69, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_GPU_SHADERS_MSL_BOOLEAN \"SDL.renderer.create.gpu.shaders_msl\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_GPU_SHADERS_MSL_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x73, 0x5F, 0x6D, 0x73, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_INSTANCE_POINTER \"SDL.renderer.create.vulkan.instance\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_INSTANCE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x69, 0x6E, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_SURFACE_NUMBER \"SDL.renderer.create.vulkan.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_SURFACE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_PHYSICAL_DEVICE_POINTER \"SDL.renderer.create.vulkan.physical_device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_PHYSICAL_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x70, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_DEVICE_POINTER \"SDL.renderer.create.vulkan.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.create.vulkan.graphics_queue_family_index\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x73, 0x5F, 0x71, 0x75, 0x65, 0x75, 0x65, 0x5F, 0x66, 0x61, 0x6D, 0x69, 0x6C, 0x79, 0x5F, 0x69, 0x6E, 0x64, 0x65, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.create.vulkan.present_queue_family_index\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_CREATE_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x70, 0x72, 0x65, 0x73, 0x65, 0x6E, 0x74, 0x5F, 0x71, 0x75, 0x65, 0x75, 0x65, 0x5F, 0x66, 0x61, 0x6D, 0x69, 0x6C, 0x79, 0x5F, 0x69, 0x6E, 0x64, 0x65, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_NAME_STRING \"SDL.renderer.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_WINDOW_POINTER \"SDL.renderer.window\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_WINDOW_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x77, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_SURFACE_POINTER \"SDL.renderer.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_SURFACE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_VSYNC_NUMBER \"SDL.renderer.vsync\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VSYNC_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x76, 0x73, 0x79, 0x6E, 0x63, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_MAX_TEXTURE_SIZE_NUMBER \"SDL.renderer.max_texture_size\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_MAX_TEXTURE_SIZE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x6D, 0x61, 0x78, 0x5F, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x73, 0x69, 0x7A, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_TEXTURE_FORMATS_POINTER \"SDL.renderer.texture_formats\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_TEXTURE_FORMATS_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x73, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_TEXTURE_WRAPPING_BOOLEAN \"SDL.renderer.texture_wrapping\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_TEXTURE_WRAPPING_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x77, 0x72, 0x61, 0x70, 0x70, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_OUTPUT_COLORSPACE_NUMBER \"SDL.renderer.output_colorspace\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_OUTPUT_COLORSPACE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x6F, 0x75, 0x74, 0x70, 0x75, 0x74, 0x5F, 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x73, 0x70, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_HDR_ENABLED_BOOLEAN \"SDL.renderer.HDR_enabled\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_HDR_ENABLED_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x48, 0x44, 0x52, 0x5F, 0x65, 0x6E, 0x61, 0x62, 0x6C, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_SDR_WHITE_POINT_FLOAT \"SDL.renderer.SDR_white_point\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_SDR_WHITE_POINT_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x53, 0x44, 0x52, 0x5F, 0x77, 0x68, 0x69, 0x74, 0x65, 0x5F, 0x70, 0x6F, 0x69, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_HDR_HEADROOM_FLOAT \"SDL.renderer.HDR_headroom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_HDR_HEADROOM_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x48, 0x44, 0x52, 0x5F, 0x68, 0x65, 0x61, 0x64, 0x72, 0x6F, 0x6F, 0x6D, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D9_DEVICE_POINTER \"SDL.renderer.d3d9.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D9_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x64, 0x33, 0x64, 0x39, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D11_DEVICE_POINTER \"SDL.renderer.d3d11.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D11_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x31, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D11_SWAPCHAIN_POINTER \"SDL.renderer.d3d11.swap_chain\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D11_SWAPCHAIN_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x31, 0x2E, 0x73, 0x77, 0x61, 0x70, 0x5F, 0x63, 0x68, 0x61, 0x69, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D12_DEVICE_POINTER \"SDL.renderer.d3d12.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D12_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D12_SWAPCHAIN_POINTER \"SDL.renderer.d3d12.swap_chain\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D12_SWAPCHAIN_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x73, 0x77, 0x61, 0x70, 0x5F, 0x63, 0x68, 0x61, 0x69, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_D3D12_COMMAND_QUEUE_POINTER \"SDL.renderer.d3d12.command_queue\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_D3D12_COMMAND_QUEUE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x63, 0x6F, 0x6D, 0x6D, 0x61, 0x6E, 0x64, 0x5F, 0x71, 0x75, 0x65, 0x75, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_INSTANCE_POINTER \"SDL.renderer.vulkan.instance\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_INSTANCE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x69, 0x6E, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_SURFACE_NUMBER \"SDL.renderer.vulkan.surface\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_SURFACE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_PHYSICAL_DEVICE_POINTER \"SDL.renderer.vulkan.physical_device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_PHYSICAL_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x70, 0x68, 0x79, 0x73, 0x69, 0x63, 0x61, 0x6C, 0x5F, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_DEVICE_POINTER \"SDL.renderer.vulkan.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.vulkan.graphics_queue_family_index\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x73, 0x5F, 0x71, 0x75, 0x65, 0x75, 0x65, 0x5F, 0x66, 0x61, 0x6D, 0x69, 0x6C, 0x79, 0x5F, 0x69, 0x6E, 0x64, 0x65, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.vulkan.present_queue_family_index\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x70, 0x72, 0x65, 0x73, 0x65, 0x6E, 0x74, 0x5F, 0x71, 0x75, 0x65, 0x75, 0x65, 0x5F, 0x66, 0x61, 0x6D, 0x69, 0x6C, 0x79, 0x5F, 0x69, 0x6E, 0x64, 0x65, 0x78, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_VULKAN_SWAPCHAIN_IMAGE_COUNT_NUMBER \"SDL.renderer.vulkan.swapchain_image_count\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_VULKAN_SWAPCHAIN_IMAGE_COUNT_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x73, 0x77, 0x61, 0x70, 0x63, 0x68, 0x61, 0x69, 0x6E, 0x5F, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x5F, 0x63, 0x6F, 0x75, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_RENDERER_GPU_DEVICE_POINTER \"SDL.renderer.gpu.device\"")]
        public static ReadOnlySpan<byte> SDL_PROP_RENDERER_GPU_DEVICE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x72, 0x65, 0x6E, 0x64, 0x65, 0x72, 0x65, 0x72, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_COLORSPACE_NUMBER \"SDL.texture.create.colorspace\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_COLORSPACE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x73, 0x70, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_FORMAT_NUMBER \"SDL.texture.create.format\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_FORMAT_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_ACCESS_NUMBER \"SDL.texture.create.access\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_ACCESS_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x61, 0x63, 0x63, 0x65, 0x73, 0x73, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_WIDTH_NUMBER \"SDL.texture.create.width\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_WIDTH_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x77, 0x69, 0x64, 0x74, 0x68, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_HEIGHT_NUMBER \"SDL.texture.create.height\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_HEIGHT_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_PALETTE_POINTER \"SDL.texture.create.palette\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_PALETTE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x70, 0x61, 0x6C, 0x65, 0x74, 0x74, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_SDR_WHITE_POINT_FLOAT \"SDL.texture.create.SDR_white_point\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_SDR_WHITE_POINT_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x53, 0x44, 0x52, 0x5F, 0x77, 0x68, 0x69, 0x74, 0x65, 0x5F, 0x70, 0x6F, 0x69, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_HDR_HEADROOM_FLOAT \"SDL.texture.create.HDR_headroom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_HDR_HEADROOM_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x48, 0x44, 0x52, 0x5F, 0x68, 0x65, 0x61, 0x64, 0x72, 0x6F, 0x6F, 0x6D, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_POINTER \"SDL.texture.create.d3d11.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x31, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_U_POINTER \"SDL.texture.create.d3d11.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_U_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x31, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_V_POINTER \"SDL.texture.create.d3d11.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_V_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x31, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_POINTER \"SDL.texture.create.d3d12.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_U_POINTER \"SDL.texture.create.d3d12.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_U_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_V_POINTER \"SDL.texture.create.d3d12.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_V_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_METAL_PIXELBUFFER_POINTER \"SDL.texture.create.metal.pixelbuffer\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_METAL_PIXELBUFFER_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x6C, 0x2E, 0x70, 0x69, 0x78, 0x65, 0x6C, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_NUMBER \"SDL.texture.create.opengl.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_UV_NUMBER \"SDL.texture.create.opengl.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_UV_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_U_NUMBER \"SDL.texture.create.opengl.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_U_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_V_NUMBER \"SDL.texture.create.opengl.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_V_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_NUMBER \"SDL.texture.create.opengles2.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_UV_NUMBER \"SDL.texture.create.opengles2.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_UV_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_U_NUMBER \"SDL.texture.create.opengles2.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_U_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_V_NUMBER \"SDL.texture.create.opengles2.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_V_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_NUMBER \"SDL.texture.create.vulkan.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_VULKAN_LAYOUT_NUMBER \"SDL.texture.create.vulkan.layout\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_VULKAN_LAYOUT_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x6C, 0x61, 0x79, 0x6F, 0x75, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_POINTER \"SDL.texture.create.gpu.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_UV_POINTER \"SDL.texture.create.gpu.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_UV_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_U_POINTER \"SDL.texture.create.gpu.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_U_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_V_POINTER \"SDL.texture.create.gpu.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_V_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_COLORSPACE_NUMBER \"SDL.texture.colorspace\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_COLORSPACE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x6F, 0x6C, 0x6F, 0x72, 0x73, 0x70, 0x61, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_FORMAT_NUMBER \"SDL.texture.format\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_FORMAT_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_ACCESS_NUMBER \"SDL.texture.access\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_ACCESS_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x61, 0x63, 0x63, 0x65, 0x73, 0x73, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_WIDTH_NUMBER \"SDL.texture.width\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_WIDTH_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x77, 0x69, 0x64, 0x74, 0x68, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_HEIGHT_NUMBER \"SDL.texture.height\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_HEIGHT_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x68, 0x65, 0x69, 0x67, 0x68, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_SDR_WHITE_POINT_FLOAT \"SDL.texture.SDR_white_point\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_SDR_WHITE_POINT_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x53, 0x44, 0x52, 0x5F, 0x77, 0x68, 0x69, 0x74, 0x65, 0x5F, 0x70, 0x6F, 0x69, 0x6E, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_HDR_HEADROOM_FLOAT \"SDL.texture.HDR_headroom\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_HDR_HEADROOM_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x48, 0x44, 0x52, 0x5F, 0x68, 0x65, 0x61, 0x64, 0x72, 0x6F, 0x6F, 0x6D, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_POINTER \"SDL.texture.d3d11.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D11_TEXTURE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x31, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_U_POINTER \"SDL.texture.d3d11.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D11_TEXTURE_U_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x31, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_V_POINTER \"SDL.texture.d3d11.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D11_TEXTURE_V_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x31, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_POINTER \"SDL.texture.d3d12.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D12_TEXTURE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_U_POINTER \"SDL.texture.d3d12.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D12_TEXTURE_U_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_V_POINTER \"SDL.texture.d3d12.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_D3D12_TEXTURE_V_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_NUMBER \"SDL.texture.opengl.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_UV_NUMBER \"SDL.texture.opengl.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_UV_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_U_NUMBER \"SDL.texture.opengl.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_U_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_V_NUMBER \"SDL.texture.opengl.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_V_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_TARGET_NUMBER \"SDL.texture.opengl.target\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEXTURE_TARGET_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x61, 0x72, 0x67, 0x65, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEX_W_FLOAT \"SDL.texture.opengl.tex_w\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEX_W_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x5F, 0x77, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEX_H_FLOAT \"SDL.texture.opengl.tex_h\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGL_TEX_H_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x2E, 0x74, 0x65, 0x78, 0x5F, 0x68, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_NUMBER \"SDL.texture.opengles2.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_UV_NUMBER \"SDL.texture.opengles2.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_UV_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_U_NUMBER \"SDL.texture.opengles2.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_U_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_V_NUMBER \"SDL.texture.opengles2.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_V_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x32, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_TARGET_NUMBER \"SDL.texture.opengles2.target\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_TARGET_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x6F, 0x70, 0x65, 0x6E, 0x67, 0x6C, 0x65, 0x73, 0x32, 0x2E, 0x74, 0x61, 0x72, 0x67, 0x65, 0x74, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_VULKAN_TEXTURE_NUMBER \"SDL.texture.vulkan.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_VULKAN_TEXTURE_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_GPU_TEXTURE_POINTER \"SDL.texture.gpu.texture\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_GPU_TEXTURE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_GPU_TEXTURE_UV_POINTER \"SDL.texture.gpu.texture_uv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_GPU_TEXTURE_UV_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_GPU_TEXTURE_U_POINTER \"SDL.texture.gpu.texture_u\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_GPU_TEXTURE_U_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x75, 0x00 };

        [NativeTypeName("#define SDL_PROP_TEXTURE_GPU_TEXTURE_V_POINTER \"SDL.texture.gpu.texture_v\"")]
        public static ReadOnlySpan<byte> SDL_PROP_TEXTURE_GPU_TEXTURE_V_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x5F, 0x76, 0x00 };

        [NativeTypeName("#define SDL_RENDERER_VSYNC_DISABLED 0")]
        public const int SDL_RENDERER_VSYNC_DISABLED = 0;

        [NativeTypeName("#define SDL_RENDERER_VSYNC_ADAPTIVE (-1)")]
        public const int SDL_RENDERER_VSYNC_ADAPTIVE = (-1);

        [NativeTypeName("#define SDL_DEBUG_TEXT_FONT_CHARACTER_SIZE 8")]
        public const int SDL_DEBUG_TEXT_FONT_CHARACTER_SIZE = 8;
    }
}
