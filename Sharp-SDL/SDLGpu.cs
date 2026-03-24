using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_GPUDevice
    {
    }

    public partial struct SDL_GPUBuffer
    {
    }

    public partial struct SDL_GPUTransferBuffer
    {
    }

    public partial struct SDL_GPUTexture
    {
    }

    public partial struct SDL_GPUSampler
    {
    }

    public partial struct SDL_GPUShader
    {
    }

    public partial struct SDL_GPUComputePipeline
    {
    }

    public partial struct SDL_GPUGraphicsPipeline
    {
    }

    public partial struct SDL_GPUCommandBuffer
    {
    }

    public partial struct SDL_GPURenderPass
    {
    }

    public partial struct SDL_GPUComputePass
    {
    }

    public partial struct SDL_GPUCopyPass
    {
    }

    public partial struct SDL_GPUFence
    {
    }

    public enum SDL_GPUPrimitiveType
    {
        SDL_GPU_PRIMITIVETYPE_TRIANGLELIST,
        SDL_GPU_PRIMITIVETYPE_TRIANGLESTRIP,
        SDL_GPU_PRIMITIVETYPE_LINELIST,
        SDL_GPU_PRIMITIVETYPE_LINESTRIP,
        SDL_GPU_PRIMITIVETYPE_POINTLIST,
    }

    public enum SDL_GPULoadOp
    {
        SDL_GPU_LOADOP_LOAD,
        SDL_GPU_LOADOP_CLEAR,
        SDL_GPU_LOADOP_DONT_CARE,
    }

    public enum SDL_GPUStoreOp
    {
        SDL_GPU_STOREOP_STORE,
        SDL_GPU_STOREOP_DONT_CARE,
        SDL_GPU_STOREOP_RESOLVE,
        SDL_GPU_STOREOP_RESOLVE_AND_STORE,
    }

    public enum SDL_GPUIndexElementSize
    {
        SDL_GPU_INDEXELEMENTSIZE_16BIT,
        SDL_GPU_INDEXELEMENTSIZE_32BIT,
    }

    public enum SDL_GPUTextureFormat
    {
        SDL_GPU_TEXTUREFORMAT_INVALID,
        SDL_GPU_TEXTUREFORMAT_A8_UNORM,
        SDL_GPU_TEXTUREFORMAT_R8_UNORM,
        SDL_GPU_TEXTUREFORMAT_R8G8_UNORM,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UNORM,
        SDL_GPU_TEXTUREFORMAT_R16_UNORM,
        SDL_GPU_TEXTUREFORMAT_R16G16_UNORM,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_UNORM,
        SDL_GPU_TEXTUREFORMAT_R10G10B10A2_UNORM,
        SDL_GPU_TEXTUREFORMAT_B5G6R5_UNORM,
        SDL_GPU_TEXTUREFORMAT_B5G5R5A1_UNORM,
        SDL_GPU_TEXTUREFORMAT_B4G4R4A4_UNORM,
        SDL_GPU_TEXTUREFORMAT_B8G8R8A8_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC1_RGBA_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC2_RGBA_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC3_RGBA_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC4_R_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC5_RG_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC7_RGBA_UNORM,
        SDL_GPU_TEXTUREFORMAT_BC6H_RGB_FLOAT,
        SDL_GPU_TEXTUREFORMAT_BC6H_RGB_UFLOAT,
        SDL_GPU_TEXTUREFORMAT_R8_SNORM,
        SDL_GPU_TEXTUREFORMAT_R8G8_SNORM,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_SNORM,
        SDL_GPU_TEXTUREFORMAT_R16_SNORM,
        SDL_GPU_TEXTUREFORMAT_R16G16_SNORM,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_SNORM,
        SDL_GPU_TEXTUREFORMAT_R16_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R16G16_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R32_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R32G32_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R32G32B32A32_FLOAT,
        SDL_GPU_TEXTUREFORMAT_R11G11B10_UFLOAT,
        SDL_GPU_TEXTUREFORMAT_R8_UINT,
        SDL_GPU_TEXTUREFORMAT_R8G8_UINT,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UINT,
        SDL_GPU_TEXTUREFORMAT_R16_UINT,
        SDL_GPU_TEXTUREFORMAT_R16G16_UINT,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_UINT,
        SDL_GPU_TEXTUREFORMAT_R32_UINT,
        SDL_GPU_TEXTUREFORMAT_R32G32_UINT,
        SDL_GPU_TEXTUREFORMAT_R32G32B32A32_UINT,
        SDL_GPU_TEXTUREFORMAT_R8_INT,
        SDL_GPU_TEXTUREFORMAT_R8G8_INT,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_INT,
        SDL_GPU_TEXTUREFORMAT_R16_INT,
        SDL_GPU_TEXTUREFORMAT_R16G16_INT,
        SDL_GPU_TEXTUREFORMAT_R16G16B16A16_INT,
        SDL_GPU_TEXTUREFORMAT_R32_INT,
        SDL_GPU_TEXTUREFORMAT_R32G32_INT,
        SDL_GPU_TEXTUREFORMAT_R32G32B32A32_INT,
        SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_B8G8R8A8_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_BC1_RGBA_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_BC2_RGBA_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_BC3_RGBA_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_BC7_RGBA_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_D16_UNORM,
        SDL_GPU_TEXTUREFORMAT_D24_UNORM,
        SDL_GPU_TEXTUREFORMAT_D32_FLOAT,
        SDL_GPU_TEXTUREFORMAT_D24_UNORM_S8_UINT,
        SDL_GPU_TEXTUREFORMAT_D32_FLOAT_S8_UINT,
        SDL_GPU_TEXTUREFORMAT_ASTC_4x4_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x4_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x5_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x5_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x6_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x5_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x6_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x8_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x5_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x6_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x8_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x10_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x10_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x12_UNORM,
        SDL_GPU_TEXTUREFORMAT_ASTC_4x4_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x4_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x5_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x5_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x6_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x5_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x6_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x8_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x5_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x6_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x8_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x10_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x10_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x12_UNORM_SRGB,
        SDL_GPU_TEXTUREFORMAT_ASTC_4x4_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x4_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_5x5_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x5_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_6x6_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x5_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x6_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_8x8_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x5_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x6_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x8_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_10x10_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x10_FLOAT,
        SDL_GPU_TEXTUREFORMAT_ASTC_12x12_FLOAT,
    }

    public enum SDL_GPUTextureType
    {
        SDL_GPU_TEXTURETYPE_2D,
        SDL_GPU_TEXTURETYPE_2D_ARRAY,
        SDL_GPU_TEXTURETYPE_3D,
        SDL_GPU_TEXTURETYPE_CUBE,
        SDL_GPU_TEXTURETYPE_CUBE_ARRAY,
    }

    public enum SDL_GPUSampleCount
    {
        SDL_GPU_SAMPLECOUNT_1,
        SDL_GPU_SAMPLECOUNT_2,
        SDL_GPU_SAMPLECOUNT_4,
        SDL_GPU_SAMPLECOUNT_8,
    }

    public enum SDL_GPUCubeMapFace
    {
        SDL_GPU_CUBEMAPFACE_POSITIVEX,
        SDL_GPU_CUBEMAPFACE_NEGATIVEX,
        SDL_GPU_CUBEMAPFACE_POSITIVEY,
        SDL_GPU_CUBEMAPFACE_NEGATIVEY,
        SDL_GPU_CUBEMAPFACE_POSITIVEZ,
        SDL_GPU_CUBEMAPFACE_NEGATIVEZ,
    }

    public enum SDL_GPUTransferBufferUsage
    {
        SDL_GPU_TRANSFERBUFFERUSAGE_UPLOAD,
        SDL_GPU_TRANSFERBUFFERUSAGE_DOWNLOAD,
    }

    public enum SDL_GPUShaderStage
    {
        SDL_GPU_SHADERSTAGE_VERTEX,
        SDL_GPU_SHADERSTAGE_FRAGMENT,
    }

    public enum SDL_GPUVertexElementFormat
    {
        SDL_GPU_VERTEXELEMENTFORMAT_INVALID,
        SDL_GPU_VERTEXELEMENTFORMAT_INT,
        SDL_GPU_VERTEXELEMENTFORMAT_INT2,
        SDL_GPU_VERTEXELEMENTFORMAT_INT3,
        SDL_GPU_VERTEXELEMENTFORMAT_INT4,
        SDL_GPU_VERTEXELEMENTFORMAT_UINT,
        SDL_GPU_VERTEXELEMENTFORMAT_UINT2,
        SDL_GPU_VERTEXELEMENTFORMAT_UINT3,
        SDL_GPU_VERTEXELEMENTFORMAT_UINT4,
        SDL_GPU_VERTEXELEMENTFORMAT_FLOAT,
        SDL_GPU_VERTEXELEMENTFORMAT_FLOAT2,
        SDL_GPU_VERTEXELEMENTFORMAT_FLOAT3,
        SDL_GPU_VERTEXELEMENTFORMAT_FLOAT4,
        SDL_GPU_VERTEXELEMENTFORMAT_BYTE2,
        SDL_GPU_VERTEXELEMENTFORMAT_BYTE4,
        SDL_GPU_VERTEXELEMENTFORMAT_UBYTE2,
        SDL_GPU_VERTEXELEMENTFORMAT_UBYTE4,
        SDL_GPU_VERTEXELEMENTFORMAT_BYTE2_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_BYTE4_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_UBYTE2_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_UBYTE4_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_SHORT2,
        SDL_GPU_VERTEXELEMENTFORMAT_SHORT4,
        SDL_GPU_VERTEXELEMENTFORMAT_USHORT2,
        SDL_GPU_VERTEXELEMENTFORMAT_USHORT4,
        SDL_GPU_VERTEXELEMENTFORMAT_SHORT2_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_SHORT4_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_USHORT2_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_USHORT4_NORM,
        SDL_GPU_VERTEXELEMENTFORMAT_HALF2,
        SDL_GPU_VERTEXELEMENTFORMAT_HALF4,
    }

    public enum SDL_GPUVertexInputRate
    {
        SDL_GPU_VERTEXINPUTRATE_VERTEX,
        SDL_GPU_VERTEXINPUTRATE_INSTANCE,
    }

    public enum SDL_GPUFillMode
    {
        SDL_GPU_FILLMODE_FILL,
        SDL_GPU_FILLMODE_LINE,
    }

    public enum SDL_GPUCullMode
    {
        SDL_GPU_CULLMODE_NONE,
        SDL_GPU_CULLMODE_FRONT,
        SDL_GPU_CULLMODE_BACK,
    }

    public enum SDL_GPUFrontFace
    {
        SDL_GPU_FRONTFACE_COUNTER_CLOCKWISE,
        SDL_GPU_FRONTFACE_CLOCKWISE,
    }

    public enum SDL_GPUCompareOp
    {
        SDL_GPU_COMPAREOP_INVALID,
        SDL_GPU_COMPAREOP_NEVER,
        SDL_GPU_COMPAREOP_LESS,
        SDL_GPU_COMPAREOP_EQUAL,
        SDL_GPU_COMPAREOP_LESS_OR_EQUAL,
        SDL_GPU_COMPAREOP_GREATER,
        SDL_GPU_COMPAREOP_NOT_EQUAL,
        SDL_GPU_COMPAREOP_GREATER_OR_EQUAL,
        SDL_GPU_COMPAREOP_ALWAYS,
    }

    public enum SDL_GPUStencilOp
    {
        SDL_GPU_STENCILOP_INVALID,
        SDL_GPU_STENCILOP_KEEP,
        SDL_GPU_STENCILOP_ZERO,
        SDL_GPU_STENCILOP_REPLACE,
        SDL_GPU_STENCILOP_INCREMENT_AND_CLAMP,
        SDL_GPU_STENCILOP_DECREMENT_AND_CLAMP,
        SDL_GPU_STENCILOP_INVERT,
        SDL_GPU_STENCILOP_INCREMENT_AND_WRAP,
        SDL_GPU_STENCILOP_DECREMENT_AND_WRAP,
    }

    public enum SDL_GPUBlendOp
    {
        SDL_GPU_BLENDOP_INVALID,
        SDL_GPU_BLENDOP_ADD,
        SDL_GPU_BLENDOP_SUBTRACT,
        SDL_GPU_BLENDOP_REVERSE_SUBTRACT,
        SDL_GPU_BLENDOP_MIN,
        SDL_GPU_BLENDOP_MAX,
    }

    public enum SDL_GPUBlendFactor
    {
        SDL_GPU_BLENDFACTOR_INVALID,
        SDL_GPU_BLENDFACTOR_ZERO,
        SDL_GPU_BLENDFACTOR_ONE,
        SDL_GPU_BLENDFACTOR_SRC_COLOR,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_SRC_COLOR,
        SDL_GPU_BLENDFACTOR_DST_COLOR,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_DST_COLOR,
        SDL_GPU_BLENDFACTOR_SRC_ALPHA,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_SRC_ALPHA,
        SDL_GPU_BLENDFACTOR_DST_ALPHA,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_DST_ALPHA,
        SDL_GPU_BLENDFACTOR_CONSTANT_COLOR,
        SDL_GPU_BLENDFACTOR_ONE_MINUS_CONSTANT_COLOR,
        SDL_GPU_BLENDFACTOR_SRC_ALPHA_SATURATE,
    }

    public enum SDL_GPUFilter
    {
        SDL_GPU_FILTER_NEAREST,
        SDL_GPU_FILTER_LINEAR,
    }

    public enum SDL_GPUSamplerMipmapMode
    {
        SDL_GPU_SAMPLERMIPMAPMODE_NEAREST,
        SDL_GPU_SAMPLERMIPMAPMODE_LINEAR,
    }

    public enum SDL_GPUSamplerAddressMode
    {
        SDL_GPU_SAMPLERADDRESSMODE_REPEAT,
        SDL_GPU_SAMPLERADDRESSMODE_MIRRORED_REPEAT,
        SDL_GPU_SAMPLERADDRESSMODE_CLAMP_TO_EDGE,
    }

    public enum SDL_GPUPresentMode
    {
        SDL_GPU_PRESENTMODE_VSYNC,
        SDL_GPU_PRESENTMODE_IMMEDIATE,
        SDL_GPU_PRESENTMODE_MAILBOX,
    }

    public enum SDL_GPUSwapchainComposition
    {
        SDL_GPU_SWAPCHAINCOMPOSITION_SDR,
        SDL_GPU_SWAPCHAINCOMPOSITION_SDR_LINEAR,
        SDL_GPU_SWAPCHAINCOMPOSITION_HDR_EXTENDED_LINEAR,
        SDL_GPU_SWAPCHAINCOMPOSITION_HDR10_ST2084,
    }

    public partial struct SDL_GPUViewport
    {
        public float x;

        public float y;

        public float w;

        public float h;

        public float min_depth;

        public float max_depth;
    }

    public unsafe partial struct SDL_GPUTextureTransferInfo
    {
        public SDL_GPUTransferBuffer* transfer_buffer;

        [NativeTypeName("Uint32")]
        public uint offset;

        [NativeTypeName("Uint32")]
        public uint pixels_per_row;

        [NativeTypeName("Uint32")]
        public uint rows_per_layer;
    }

    public unsafe partial struct SDL_GPUTransferBufferLocation
    {
        public SDL_GPUTransferBuffer* transfer_buffer;

        [NativeTypeName("Uint32")]
        public uint offset;
    }

    public unsafe partial struct SDL_GPUTextureLocation
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer;

        [NativeTypeName("Uint32")]
        public uint x;

        [NativeTypeName("Uint32")]
        public uint y;

        [NativeTypeName("Uint32")]
        public uint z;
    }

    public unsafe partial struct SDL_GPUTextureRegion
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer;

        [NativeTypeName("Uint32")]
        public uint x;

        [NativeTypeName("Uint32")]
        public uint y;

        [NativeTypeName("Uint32")]
        public uint z;

        [NativeTypeName("Uint32")]
        public uint w;

        [NativeTypeName("Uint32")]
        public uint h;

        [NativeTypeName("Uint32")]
        public uint d;
    }

    public unsafe partial struct SDL_GPUBlitRegion
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer_or_depth_plane;

        [NativeTypeName("Uint32")]
        public uint x;

        [NativeTypeName("Uint32")]
        public uint y;

        [NativeTypeName("Uint32")]
        public uint w;

        [NativeTypeName("Uint32")]
        public uint h;
    }

    public unsafe partial struct SDL_GPUBufferLocation
    {
        public SDL_GPUBuffer* buffer;

        [NativeTypeName("Uint32")]
        public uint offset;
    }

    public unsafe partial struct SDL_GPUBufferRegion
    {
        public SDL_GPUBuffer* buffer;

        [NativeTypeName("Uint32")]
        public uint offset;

        [NativeTypeName("Uint32")]
        public uint size;
    }

    public partial struct SDL_GPUIndirectDrawCommand
    {
        [NativeTypeName("Uint32")]
        public uint num_vertices;

        [NativeTypeName("Uint32")]
        public uint num_instances;

        [NativeTypeName("Uint32")]
        public uint first_vertex;

        [NativeTypeName("Uint32")]
        public uint first_instance;
    }

    public partial struct SDL_GPUIndexedIndirectDrawCommand
    {
        [NativeTypeName("Uint32")]
        public uint num_indices;

        [NativeTypeName("Uint32")]
        public uint num_instances;

        [NativeTypeName("Uint32")]
        public uint first_index;

        [NativeTypeName("Sint32")]
        public int vertex_offset;

        [NativeTypeName("Uint32")]
        public uint first_instance;
    }

    public partial struct SDL_GPUIndirectDispatchCommand
    {
        [NativeTypeName("Uint32")]
        public uint groupcount_x;

        [NativeTypeName("Uint32")]
        public uint groupcount_y;

        [NativeTypeName("Uint32")]
        public uint groupcount_z;
    }

    public partial struct SDL_GPUSamplerCreateInfo
    {
        public SDL_GPUFilter min_filter;

        public SDL_GPUFilter mag_filter;

        public SDL_GPUSamplerMipmapMode mipmap_mode;

        public SDL_GPUSamplerAddressMode address_mode_u;

        public SDL_GPUSamplerAddressMode address_mode_v;

        public SDL_GPUSamplerAddressMode address_mode_w;

        public float mip_lod_bias;

        public float max_anisotropy;

        public SDL_GPUCompareOp compare_op;

        public float min_lod;

        public float max_lod;

        [NativeTypeName("bool")]
        public byte enable_anisotropy;

        [NativeTypeName("bool")]
        public byte enable_compare;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    public partial struct SDL_GPUVertexBufferDescription
    {
        [NativeTypeName("Uint32")]
        public uint slot;

        [NativeTypeName("Uint32")]
        public uint pitch;

        public SDL_GPUVertexInputRate input_rate;

        [NativeTypeName("Uint32")]
        public uint instance_step_rate;
    }

    public partial struct SDL_GPUVertexAttribute
    {
        [NativeTypeName("Uint32")]
        public uint location;

        [NativeTypeName("Uint32")]
        public uint buffer_slot;

        public SDL_GPUVertexElementFormat format;

        [NativeTypeName("Uint32")]
        public uint offset;
    }

    public unsafe partial struct SDL_GPUVertexInputState
    {
        [NativeTypeName("const SDL_GPUVertexBufferDescription *")]
        public SDL_GPUVertexBufferDescription* vertex_buffer_descriptions;

        [NativeTypeName("Uint32")]
        public uint num_vertex_buffers;

        [NativeTypeName("const SDL_GPUVertexAttribute *")]
        public SDL_GPUVertexAttribute* vertex_attributes;

        [NativeTypeName("Uint32")]
        public uint num_vertex_attributes;
    }

    public partial struct SDL_GPUStencilOpState
    {
        public SDL_GPUStencilOp fail_op;

        public SDL_GPUStencilOp pass_op;

        public SDL_GPUStencilOp depth_fail_op;

        public SDL_GPUCompareOp compare_op;
    }

    public partial struct SDL_GPUColorTargetBlendState
    {
        public SDL_GPUBlendFactor src_color_blendfactor;

        public SDL_GPUBlendFactor dst_color_blendfactor;

        public SDL_GPUBlendOp color_blend_op;

        public SDL_GPUBlendFactor src_alpha_blendfactor;

        public SDL_GPUBlendFactor dst_alpha_blendfactor;

        public SDL_GPUBlendOp alpha_blend_op;

        [NativeTypeName("SDL_GPUColorComponentFlags")]
        public byte color_write_mask;

        [NativeTypeName("bool")]
        public byte enable_blend;

        [NativeTypeName("bool")]
        public byte enable_color_write_mask;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;
    }

    public unsafe partial struct SDL_GPUShaderCreateInfo
    {
        [NativeTypeName("size_t")]
        public UIntPtr code_size;

        [NativeTypeName("const Uint8 *")]
        public byte* code;

        [NativeTypeName("const char *")]
        public sbyte* entrypoint;

        [NativeTypeName("SDL_GPUShaderFormat")]
        public uint format;

        public SDL_GPUShaderStage stage;

        [NativeTypeName("Uint32")]
        public uint num_samplers;

        [NativeTypeName("Uint32")]
        public uint num_storage_textures;

        [NativeTypeName("Uint32")]
        public uint num_storage_buffers;

        [NativeTypeName("Uint32")]
        public uint num_uniform_buffers;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    public partial struct SDL_GPUTextureCreateInfo
    {
        public SDL_GPUTextureType type;

        public SDL_GPUTextureFormat format;

        [NativeTypeName("SDL_GPUTextureUsageFlags")]
        public uint usage;

        [NativeTypeName("Uint32")]
        public uint width;

        [NativeTypeName("Uint32")]
        public uint height;

        [NativeTypeName("Uint32")]
        public uint layer_count_or_depth;

        [NativeTypeName("Uint32")]
        public uint num_levels;

        public SDL_GPUSampleCount sample_count;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    public partial struct SDL_GPUBufferCreateInfo
    {
        [NativeTypeName("SDL_GPUBufferUsageFlags")]
        public uint usage;

        [NativeTypeName("Uint32")]
        public uint size;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    public partial struct SDL_GPUTransferBufferCreateInfo
    {
        public SDL_GPUTransferBufferUsage usage;

        [NativeTypeName("Uint32")]
        public uint size;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    public partial struct SDL_GPURasterizerState
    {
        public SDL_GPUFillMode fill_mode;

        public SDL_GPUCullMode cull_mode;

        public SDL_GPUFrontFace front_face;

        public float depth_bias_constant_factor;

        public float depth_bias_clamp;

        public float depth_bias_slope_factor;

        [NativeTypeName("bool")]
        public byte enable_depth_bias;

        [NativeTypeName("bool")]
        public byte enable_depth_clip;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;
    }

    public partial struct SDL_GPUMultisampleState
    {
        public SDL_GPUSampleCount sample_count;

        [NativeTypeName("Uint32")]
        public uint sample_mask;

        [NativeTypeName("bool")]
        public byte enable_mask;

        [NativeTypeName("bool")]
        public byte enable_alpha_to_coverage;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    public partial struct SDL_GPUDepthStencilState
    {
        public SDL_GPUCompareOp compare_op;

        public SDL_GPUStencilOpState back_stencil_state;

        public SDL_GPUStencilOpState front_stencil_state;

        [NativeTypeName("Uint8")]
        public byte compare_mask;

        [NativeTypeName("Uint8")]
        public byte write_mask;

        [NativeTypeName("bool")]
        public byte enable_depth_test;

        [NativeTypeName("bool")]
        public byte enable_depth_write;

        [NativeTypeName("bool")]
        public byte enable_stencil_test;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    public partial struct SDL_GPUColorTargetDescription
    {
        public SDL_GPUTextureFormat format;

        public SDL_GPUColorTargetBlendState blend_state;
    }

    public unsafe partial struct SDL_GPUGraphicsPipelineTargetInfo
    {
        [NativeTypeName("const SDL_GPUColorTargetDescription *")]
        public SDL_GPUColorTargetDescription* color_target_descriptions;

        [NativeTypeName("Uint32")]
        public uint num_color_targets;

        public SDL_GPUTextureFormat depth_stencil_format;

        [NativeTypeName("bool")]
        public byte has_depth_stencil_target;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    public unsafe partial struct SDL_GPUGraphicsPipelineCreateInfo
    {
        public SDL_GPUShader* vertex_shader;

        public SDL_GPUShader* fragment_shader;

        public SDL_GPUVertexInputState vertex_input_state;

        public SDL_GPUPrimitiveType primitive_type;

        public SDL_GPURasterizerState rasterizer_state;

        public SDL_GPUMultisampleState multisample_state;

        public SDL_GPUDepthStencilState depth_stencil_state;

        public SDL_GPUGraphicsPipelineTargetInfo target_info;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    public unsafe partial struct SDL_GPUComputePipelineCreateInfo
    {
        [NativeTypeName("size_t")]
        public UIntPtr code_size;

        [NativeTypeName("const Uint8 *")]
        public byte* code;

        [NativeTypeName("const char *")]
        public sbyte* entrypoint;

        [NativeTypeName("SDL_GPUShaderFormat")]
        public uint format;

        [NativeTypeName("Uint32")]
        public uint num_samplers;

        [NativeTypeName("Uint32")]
        public uint num_readonly_storage_textures;

        [NativeTypeName("Uint32")]
        public uint num_readonly_storage_buffers;

        [NativeTypeName("Uint32")]
        public uint num_readwrite_storage_textures;

        [NativeTypeName("Uint32")]
        public uint num_readwrite_storage_buffers;

        [NativeTypeName("Uint32")]
        public uint num_uniform_buffers;

        [NativeTypeName("Uint32")]
        public uint threadcount_x;

        [NativeTypeName("Uint32")]
        public uint threadcount_y;

        [NativeTypeName("Uint32")]
        public uint threadcount_z;

        [NativeTypeName("SDL_PropertiesID")]
        public uint props;
    }

    public unsafe partial struct SDL_GPUColorTargetInfo
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer_or_depth_plane;

        public SDL_FColor clear_color;

        public SDL_GPULoadOp load_op;

        public SDL_GPUStoreOp store_op;

        public SDL_GPUTexture* resolve_texture;

        [NativeTypeName("Uint32")]
        public uint resolve_mip_level;

        [NativeTypeName("Uint32")]
        public uint resolve_layer;

        [NativeTypeName("bool")]
        public byte cycle;

        [NativeTypeName("bool")]
        public byte cycle_resolve_texture;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;
    }

    public unsafe partial struct SDL_GPUDepthStencilTargetInfo
    {
        public SDL_GPUTexture* texture;

        public float clear_depth;

        public SDL_GPULoadOp load_op;

        public SDL_GPUStoreOp store_op;

        public SDL_GPULoadOp stencil_load_op;

        public SDL_GPUStoreOp stencil_store_op;

        [NativeTypeName("bool")]
        public byte cycle;

        [NativeTypeName("Uint8")]
        public byte clear_stencil;

        [NativeTypeName("Uint8")]
        public byte mip_level;

        [NativeTypeName("Uint8")]
        public byte layer;
    }

    public partial struct SDL_GPUBlitInfo
    {
        public SDL_GPUBlitRegion source;

        public SDL_GPUBlitRegion destination;

        public SDL_GPULoadOp load_op;

        public SDL_FColor clear_color;

        public SDL_FlipMode flip_mode;

        public SDL_GPUFilter filter;

        [NativeTypeName("bool")]
        public byte cycle;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    public unsafe partial struct SDL_GPUBufferBinding
    {
        public SDL_GPUBuffer* buffer;

        [NativeTypeName("Uint32")]
        public uint offset;
    }

    public unsafe partial struct SDL_GPUTextureSamplerBinding
    {
        public SDL_GPUTexture* texture;

        public SDL_GPUSampler* sampler;
    }

    public unsafe partial struct SDL_GPUStorageBufferReadWriteBinding
    {
        public SDL_GPUBuffer* buffer;

        [NativeTypeName("bool")]
        public byte cycle;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    public unsafe partial struct SDL_GPUStorageTextureReadWriteBinding
    {
        public SDL_GPUTexture* texture;

        [NativeTypeName("Uint32")]
        public uint mip_level;

        [NativeTypeName("Uint32")]
        public uint layer;

        [NativeTypeName("bool")]
        public byte cycle;

        [NativeTypeName("Uint8")]
        public byte padding1;

        [NativeTypeName("Uint8")]
        public byte padding2;

        [NativeTypeName("Uint8")]
        public byte padding3;
    }

    public unsafe partial struct SDL_GPUVulkanOptions
    {
        [NativeTypeName("Uint32")]
        public uint vulkan_api_version;

        public void* feature_list;

        public void* vulkan_10_physical_device_features;

        [NativeTypeName("Uint32")]
        public uint device_extension_count;

        [NativeTypeName("const char **")]
        public sbyte** device_extension_names;

        [NativeTypeName("Uint32")]
        public uint instance_extension_count;

        [NativeTypeName("const char **")]
        public sbyte** instance_extension_names;
    }

    public static unsafe partial class SDLGpu
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GPUSupportsShaderFormats([NativeTypeName("SDL_GPUShaderFormat")] uint format_flags, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GPUSupportsProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUDevice* SDL_CreateGPUDevice([NativeTypeName("SDL_GPUShaderFormat")] uint format_flags, [NativeTypeName("bool")] byte debug_mode, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUDevice* SDL_CreateGPUDeviceWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyGPUDevice(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumGPUDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGPUDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetGPUDeviceDriver(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_GPUShaderFormat")]
        public static extern uint SDL_GetGPUShaderFormats(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetGPUDeviceProperties(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUComputePipeline* SDL_CreateGPUComputePipeline(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUComputePipelineCreateInfo *")] SDL_GPUComputePipelineCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUGraphicsPipeline* SDL_CreateGPUGraphicsPipeline(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUGraphicsPipelineCreateInfo *")] SDL_GPUGraphicsPipelineCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUSampler* SDL_CreateGPUSampler(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUSamplerCreateInfo *")] SDL_GPUSamplerCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUShader* SDL_CreateGPUShader(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUShaderCreateInfo *")] SDL_GPUShaderCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUTexture* SDL_CreateGPUTexture(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUTextureCreateInfo *")] SDL_GPUTextureCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUBuffer* SDL_CreateGPUBuffer(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUBufferCreateInfo *")] SDL_GPUBufferCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUTransferBuffer* SDL_CreateGPUTransferBuffer(SDL_GPUDevice* device, [NativeTypeName("const SDL_GPUTransferBufferCreateInfo *")] SDL_GPUTransferBufferCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetGPUBufferName(SDL_GPUDevice* device, SDL_GPUBuffer* buffer, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetGPUTextureName(SDL_GPUDevice* device, SDL_GPUTexture* texture, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_InsertGPUDebugLabel(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_PushGPUDebugGroup(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_PopGPUDebugGroup(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseGPUTexture(SDL_GPUDevice* device, SDL_GPUTexture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseGPUSampler(SDL_GPUDevice* device, SDL_GPUSampler* sampler);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseGPUBuffer(SDL_GPUDevice* device, SDL_GPUBuffer* buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseGPUComputePipeline(SDL_GPUDevice* device, SDL_GPUComputePipeline* compute_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseGPUShader(SDL_GPUDevice* device, SDL_GPUShader* shader);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseGPUGraphicsPipeline(SDL_GPUDevice* device, SDL_GPUGraphicsPipeline* graphics_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUCommandBuffer* SDL_AcquireGPUCommandBuffer(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_PushGPUVertexUniformData(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_PushGPUFragmentUniformData(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_PushGPUComputeUniformData(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("Uint32")] uint slot_index, [NativeTypeName("const void *")] void* data, [NativeTypeName("Uint32")] uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPURenderPass* SDL_BeginGPURenderPass(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const SDL_GPUColorTargetInfo *")] SDL_GPUColorTargetInfo* color_target_infos, [NativeTypeName("Uint32")] uint num_color_targets, [NativeTypeName("const SDL_GPUDepthStencilTargetInfo *")] SDL_GPUDepthStencilTargetInfo* depth_stencil_target_info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUGraphicsPipeline(SDL_GPURenderPass* render_pass, SDL_GPUGraphicsPipeline* graphics_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetGPUViewport(SDL_GPURenderPass* render_pass, [NativeTypeName("const SDL_GPUViewport *")] SDL_GPUViewport* viewport);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetGPUScissor(SDL_GPURenderPass* render_pass, [NativeTypeName("const SDL_Rect *")] SDL_Rect* scissor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetGPUBlendConstants(SDL_GPURenderPass* render_pass, SDL_FColor blend_constants);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetGPUStencilReference(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint8")] byte reference);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUVertexBuffers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUBufferBinding *")] SDL_GPUBufferBinding* bindings, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUIndexBuffer(SDL_GPURenderPass* render_pass, [NativeTypeName("const SDL_GPUBufferBinding *")] SDL_GPUBufferBinding* binding, SDL_GPUIndexElementSize index_element_size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUVertexSamplers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* texture_sampler_bindings, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUVertexStorageTextures(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUVertexStorageBuffers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUFragmentSamplers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* texture_sampler_bindings, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUFragmentStorageTextures(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUFragmentStorageBuffers(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DrawGPUIndexedPrimitives(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint num_indices, [NativeTypeName("Uint32")] uint num_instances, [NativeTypeName("Uint32")] uint first_index, [NativeTypeName("Sint32")] int vertex_offset, [NativeTypeName("Uint32")] uint first_instance);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DrawGPUPrimitives(SDL_GPURenderPass* render_pass, [NativeTypeName("Uint32")] uint num_vertices, [NativeTypeName("Uint32")] uint num_instances, [NativeTypeName("Uint32")] uint first_vertex, [NativeTypeName("Uint32")] uint first_instance);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DrawGPUPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer, [NativeTypeName("Uint32")] uint offset, [NativeTypeName("Uint32")] uint draw_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DrawGPUIndexedPrimitivesIndirect(SDL_GPURenderPass* render_pass, SDL_GPUBuffer* buffer, [NativeTypeName("Uint32")] uint offset, [NativeTypeName("Uint32")] uint draw_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_EndGPURenderPass(SDL_GPURenderPass* render_pass);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUComputePass* SDL_BeginGPUComputePass(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const SDL_GPUStorageTextureReadWriteBinding *")] SDL_GPUStorageTextureReadWriteBinding* storage_texture_bindings, [NativeTypeName("Uint32")] uint num_storage_texture_bindings, [NativeTypeName("const SDL_GPUStorageBufferReadWriteBinding *")] SDL_GPUStorageBufferReadWriteBinding* storage_buffer_bindings, [NativeTypeName("Uint32")] uint num_storage_buffer_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUComputePipeline(SDL_GPUComputePass* compute_pass, SDL_GPUComputePipeline* compute_pipeline);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUComputeSamplers(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("const SDL_GPUTextureSamplerBinding *")] SDL_GPUTextureSamplerBinding* texture_sampler_bindings, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUComputeStorageTextures(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUTexture *const *")] SDL_GPUTexture** storage_textures, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BindGPUComputeStorageBuffers(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint first_slot, [NativeTypeName("SDL_GPUBuffer *const *")] SDL_GPUBuffer** storage_buffers, [NativeTypeName("Uint32")] uint num_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DispatchGPUCompute(SDL_GPUComputePass* compute_pass, [NativeTypeName("Uint32")] uint groupcount_x, [NativeTypeName("Uint32")] uint groupcount_y, [NativeTypeName("Uint32")] uint groupcount_z);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DispatchGPUComputeIndirect(SDL_GPUComputePass* compute_pass, SDL_GPUBuffer* buffer, [NativeTypeName("Uint32")] uint offset);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_EndGPUComputePass(SDL_GPUComputePass* compute_pass);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_MapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer, [NativeTypeName("bool")] byte cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnmapGPUTransferBuffer(SDL_GPUDevice* device, SDL_GPUTransferBuffer* transfer_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUCopyPass* SDL_BeginGPUCopyPass(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UploadToGPUTexture(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTextureTransferInfo *")] SDL_GPUTextureTransferInfo* source, [NativeTypeName("const SDL_GPUTextureRegion *")] SDL_GPUTextureRegion* destination, [NativeTypeName("bool")] byte cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UploadToGPUBuffer(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTransferBufferLocation *")] SDL_GPUTransferBufferLocation* source, [NativeTypeName("const SDL_GPUBufferRegion *")] SDL_GPUBufferRegion* destination, [NativeTypeName("bool")] byte cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CopyGPUTextureToTexture(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTextureLocation *")] SDL_GPUTextureLocation* source, [NativeTypeName("const SDL_GPUTextureLocation *")] SDL_GPUTextureLocation* destination, [NativeTypeName("Uint32")] uint w, [NativeTypeName("Uint32")] uint h, [NativeTypeName("Uint32")] uint d, [NativeTypeName("bool")] byte cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CopyGPUBufferToBuffer(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUBufferLocation *")] SDL_GPUBufferLocation* source, [NativeTypeName("const SDL_GPUBufferLocation *")] SDL_GPUBufferLocation* destination, [NativeTypeName("Uint32")] uint size, [NativeTypeName("bool")] byte cycle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DownloadFromGPUTexture(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUTextureRegion *")] SDL_GPUTextureRegion* source, [NativeTypeName("const SDL_GPUTextureTransferInfo *")] SDL_GPUTextureTransferInfo* destination);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DownloadFromGPUBuffer(SDL_GPUCopyPass* copy_pass, [NativeTypeName("const SDL_GPUBufferRegion *")] SDL_GPUBufferRegion* source, [NativeTypeName("const SDL_GPUTransferBufferLocation *")] SDL_GPUTransferBufferLocation* destination);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_EndGPUCopyPass(SDL_GPUCopyPass* copy_pass);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GenerateMipmapsForGPUTexture(SDL_GPUCommandBuffer* command_buffer, SDL_GPUTexture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_BlitGPUTexture(SDL_GPUCommandBuffer* command_buffer, [NativeTypeName("const SDL_GPUBlitInfo *")] SDL_GPUBlitInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WindowSupportsGPUSwapchainComposition(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WindowSupportsGPUPresentMode(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUPresentMode present_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ClaimWindowForGPUDevice(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseWindowFromGPUDevice(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetGPUSwapchainParameters(SDL_GPUDevice* device, SDL_Window* window, SDL_GPUSwapchainComposition swapchain_composition, SDL_GPUPresentMode present_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetGPUAllowedFramesInFlight(SDL_GPUDevice* device, [NativeTypeName("Uint32")] uint allowed_frames_in_flight);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUTextureFormat SDL_GetGPUSwapchainTextureFormat(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_AcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture, [NativeTypeName("Uint32 *")] uint* swapchain_texture_width, [NativeTypeName("Uint32 *")] uint* swapchain_texture_height);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WaitForGPUSwapchain(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WaitAndAcquireGPUSwapchainTexture(SDL_GPUCommandBuffer* command_buffer, SDL_Window* window, SDL_GPUTexture** swapchain_texture, [NativeTypeName("Uint32 *")] uint* swapchain_texture_width, [NativeTypeName("Uint32 *")] uint* swapchain_texture_height);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SubmitGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUFence* SDL_SubmitGPUCommandBufferAndAcquireFence(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_CancelGPUCommandBuffer(SDL_GPUCommandBuffer* command_buffer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WaitForGPUIdle(SDL_GPUDevice* device);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_WaitForGPUFences(SDL_GPUDevice* device, [NativeTypeName("bool")] byte wait_all, [NativeTypeName("SDL_GPUFence *const *")] SDL_GPUFence** fences, [NativeTypeName("Uint32")] uint num_fences);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_QueryGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ReleaseGPUFence(SDL_GPUDevice* device, SDL_GPUFence* fence);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_GPUTextureFormatTexelBlockSize(SDL_GPUTextureFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GPUTextureSupportsFormat(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUTextureType type, [NativeTypeName("SDL_GPUTextureUsageFlags")] uint usage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GPUTextureSupportsSampleCount(SDL_GPUDevice* device, SDL_GPUTextureFormat format, SDL_GPUSampleCount sample_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_CalculateGPUTextureFormatSize(SDL_GPUTextureFormat format, [NativeTypeName("Uint32")] uint width, [NativeTypeName("Uint32")] uint height, [NativeTypeName("Uint32")] uint depth_or_layer_count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PixelFormat SDL_GetPixelFormatFromGPUTextureFormat(SDL_GPUTextureFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GPUTextureFormat SDL_GetGPUTextureFormatFromPixelFormat(SDL_PixelFormat format);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_SAMPLER (1u << 0)")]
        public const uint SDL_GPU_TEXTUREUSAGE_SAMPLER = (1U << 0);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_COLOR_TARGET (1u << 1)")]
        public const uint SDL_GPU_TEXTUREUSAGE_COLOR_TARGET = (1U << 1);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_DEPTH_STENCIL_TARGET (1u << 2)")]
        public const uint SDL_GPU_TEXTUREUSAGE_DEPTH_STENCIL_TARGET = (1U << 2);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_GRAPHICS_STORAGE_READ (1u << 3)")]
        public const uint SDL_GPU_TEXTUREUSAGE_GRAPHICS_STORAGE_READ = (1U << 3);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_READ (1u << 4)")]
        public const uint SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_READ = (1U << 4);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_WRITE (1u << 5)")]
        public const uint SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_WRITE = (1U << 5);

        [NativeTypeName("#define SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_SIMULTANEOUS_READ_WRITE (1u << 6)")]
        public const uint SDL_GPU_TEXTUREUSAGE_COMPUTE_STORAGE_SIMULTANEOUS_READ_WRITE = (1U << 6);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_VERTEX (1u << 0)")]
        public const uint SDL_GPU_BUFFERUSAGE_VERTEX = (1U << 0);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_INDEX (1u << 1)")]
        public const uint SDL_GPU_BUFFERUSAGE_INDEX = (1U << 1);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_INDIRECT (1u << 2)")]
        public const uint SDL_GPU_BUFFERUSAGE_INDIRECT = (1U << 2);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_GRAPHICS_STORAGE_READ (1u << 3)")]
        public const uint SDL_GPU_BUFFERUSAGE_GRAPHICS_STORAGE_READ = (1U << 3);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_READ (1u << 4)")]
        public const uint SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_READ = (1U << 4);

        [NativeTypeName("#define SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_WRITE (1u << 5)")]
        public const uint SDL_GPU_BUFFERUSAGE_COMPUTE_STORAGE_WRITE = (1U << 5);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_INVALID 0")]
        public const int SDL_GPU_SHADERFORMAT_INVALID = 0;

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_PRIVATE (1u << 0)")]
        public const uint SDL_GPU_SHADERFORMAT_PRIVATE = (1U << 0);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_SPIRV (1u << 1)")]
        public const uint SDL_GPU_SHADERFORMAT_SPIRV = (1U << 1);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_DXBC (1u << 2)")]
        public const uint SDL_GPU_SHADERFORMAT_DXBC = (1U << 2);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_DXIL (1u << 3)")]
        public const uint SDL_GPU_SHADERFORMAT_DXIL = (1U << 3);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_MSL (1u << 4)")]
        public const uint SDL_GPU_SHADERFORMAT_MSL = (1U << 4);

        [NativeTypeName("#define SDL_GPU_SHADERFORMAT_METALLIB (1u << 5)")]
        public const uint SDL_GPU_SHADERFORMAT_METALLIB = (1U << 5);

        [NativeTypeName("#define SDL_GPU_COLORCOMPONENT_R (1u << 0)")]
        public const uint SDL_GPU_COLORCOMPONENT_R = (1U << 0);

        [NativeTypeName("#define SDL_GPU_COLORCOMPONENT_G (1u << 1)")]
        public const uint SDL_GPU_COLORCOMPONENT_G = (1U << 1);

        [NativeTypeName("#define SDL_GPU_COLORCOMPONENT_B (1u << 2)")]
        public const uint SDL_GPU_COLORCOMPONENT_B = (1U << 2);

        [NativeTypeName("#define SDL_GPU_COLORCOMPONENT_A (1u << 3)")]
        public const uint SDL_GPU_COLORCOMPONENT_A = (1U << 3);

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_DEBUGMODE_BOOLEAN \"SDL.gpu.device.create.debugmode\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_DEBUGMODE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x65, 0x62, 0x75, 0x67, 0x6D, 0x6F, 0x64, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_PREFERLOWPOWER_BOOLEAN \"SDL.gpu.device.create.preferlowpower\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_PREFERLOWPOWER_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x70, 0x72, 0x65, 0x66, 0x65, 0x72, 0x6C, 0x6F, 0x77, 0x70, 0x6F, 0x77, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_VERBOSE_BOOLEAN \"SDL.gpu.device.create.verbose\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_VERBOSE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x65, 0x72, 0x62, 0x6F, 0x73, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_NAME_STRING \"SDL.gpu.device.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_FEATURE_CLIP_DISTANCE_BOOLEAN \"SDL.gpu.device.create.feature.clip_distance\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_FEATURE_CLIP_DISTANCE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x66, 0x65, 0x61, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x6C, 0x69, 0x70, 0x5F, 0x64, 0x69, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_FEATURE_DEPTH_CLAMPING_BOOLEAN \"SDL.gpu.device.create.feature.depth_clamping\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_FEATURE_DEPTH_CLAMPING_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x66, 0x65, 0x61, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x64, 0x65, 0x70, 0x74, 0x68, 0x5F, 0x63, 0x6C, 0x61, 0x6D, 0x70, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_FEATURE_INDIRECT_DRAW_FIRST_INSTANCE_BOOLEAN \"SDL.gpu.device.create.feature.indirect_draw_first_instance\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_FEATURE_INDIRECT_DRAW_FIRST_INSTANCE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x66, 0x65, 0x61, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x69, 0x6E, 0x64, 0x69, 0x72, 0x65, 0x63, 0x74, 0x5F, 0x64, 0x72, 0x61, 0x77, 0x5F, 0x66, 0x69, 0x72, 0x73, 0x74, 0x5F, 0x69, 0x6E, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_FEATURE_ANISOTROPY_BOOLEAN \"SDL.gpu.device.create.feature.anisotropy\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_FEATURE_ANISOTROPY_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x66, 0x65, 0x61, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x61, 0x6E, 0x69, 0x73, 0x6F, 0x74, 0x72, 0x6F, 0x70, 0x79, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_PRIVATE_BOOLEAN \"SDL.gpu.device.create.shaders.private\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_SHADERS_PRIVATE_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x73, 0x2E, 0x70, 0x72, 0x69, 0x76, 0x61, 0x74, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_SPIRV_BOOLEAN \"SDL.gpu.device.create.shaders.spirv\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_SHADERS_SPIRV_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x73, 0x2E, 0x73, 0x70, 0x69, 0x72, 0x76, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_DXBC_BOOLEAN \"SDL.gpu.device.create.shaders.dxbc\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_SHADERS_DXBC_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x73, 0x2E, 0x64, 0x78, 0x62, 0x63, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_DXIL_BOOLEAN \"SDL.gpu.device.create.shaders.dxil\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_SHADERS_DXIL_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x73, 0x2E, 0x64, 0x78, 0x69, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_MSL_BOOLEAN \"SDL.gpu.device.create.shaders.msl\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_SHADERS_MSL_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x73, 0x2E, 0x6D, 0x73, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_SHADERS_METALLIB_BOOLEAN \"SDL.gpu.device.create.shaders.metallib\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_SHADERS_METALLIB_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x73, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x6C, 0x6C, 0x69, 0x62, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_D3D12_ALLOW_FEWER_RESOURCE_SLOTS_BOOLEAN \"SDL.gpu.device.create.d3d12.allowtier1resourcebinding\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_D3D12_ALLOW_FEWER_RESOURCE_SLOTS_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x61, 0x6C, 0x6C, 0x6F, 0x77, 0x74, 0x69, 0x65, 0x72, 0x31, 0x72, 0x65, 0x73, 0x6F, 0x75, 0x72, 0x63, 0x65, 0x62, 0x69, 0x6E, 0x64, 0x69, 0x6E, 0x67, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_D3D12_SEMANTIC_NAME_STRING \"SDL.gpu.device.create.d3d12.semantic\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_D3D12_SEMANTIC_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x73, 0x65, 0x6D, 0x61, 0x6E, 0x74, 0x69, 0x63, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_D3D12_AGILITY_SDK_VERSION_NUMBER \"SDL.gpu.device.create.d3d12.agility_sdk_version\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_D3D12_AGILITY_SDK_VERSION_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x61, 0x67, 0x69, 0x6C, 0x69, 0x74, 0x79, 0x5F, 0x73, 0x64, 0x6B, 0x5F, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_D3D12_AGILITY_SDK_PATH_STRING \"SDL.gpu.device.create.d3d12.agility_sdk_path\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_D3D12_AGILITY_SDK_PATH_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x61, 0x67, 0x69, 0x6C, 0x69, 0x74, 0x79, 0x5F, 0x73, 0x64, 0x6B, 0x5F, 0x70, 0x61, 0x74, 0x68, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_VULKAN_REQUIRE_HARDWARE_ACCELERATION_BOOLEAN \"SDL.gpu.device.create.vulkan.requirehardwareacceleration\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_VULKAN_REQUIRE_HARDWARE_ACCELERATION_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x72, 0x65, 0x71, 0x75, 0x69, 0x72, 0x65, 0x68, 0x61, 0x72, 0x64, 0x77, 0x61, 0x72, 0x65, 0x61, 0x63, 0x63, 0x65, 0x6C, 0x65, 0x72, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_VULKAN_OPTIONS_POINTER \"SDL.gpu.device.create.vulkan.options\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_VULKAN_OPTIONS_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x76, 0x75, 0x6C, 0x6B, 0x61, 0x6E, 0x2E, 0x6F, 0x70, 0x74, 0x69, 0x6F, 0x6E, 0x73, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_CREATE_METAL_ALLOW_MACFAMILY1_BOOLEAN \"SDL.gpu.device.create.metal.allowmacfamily1\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_CREATE_METAL_ALLOW_MACFAMILY1_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6D, 0x65, 0x74, 0x61, 0x6C, 0x2E, 0x61, 0x6C, 0x6C, 0x6F, 0x77, 0x6D, 0x61, 0x63, 0x66, 0x61, 0x6D, 0x69, 0x6C, 0x79, 0x31, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_NAME_STRING \"SDL.gpu.device.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_DRIVER_NAME_STRING \"SDL.gpu.device.driver_name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_DRIVER_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x64, 0x72, 0x69, 0x76, 0x65, 0x72, 0x5F, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_DRIVER_VERSION_STRING \"SDL.gpu.device.driver_version\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_DRIVER_VERSION_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x64, 0x72, 0x69, 0x76, 0x65, 0x72, 0x5F, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_DEVICE_DRIVER_INFO_STRING \"SDL.gpu.device.driver_info\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_DEVICE_DRIVER_INFO_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x64, 0x72, 0x69, 0x76, 0x65, 0x72, 0x5F, 0x69, 0x6E, 0x66, 0x6F, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_COMPUTEPIPELINE_CREATE_NAME_STRING \"SDL.gpu.computepipeline.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_COMPUTEPIPELINE_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x63, 0x6F, 0x6D, 0x70, 0x75, 0x74, 0x65, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_GRAPHICSPIPELINE_CREATE_NAME_STRING \"SDL.gpu.graphicspipeline.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_GRAPHICSPIPELINE_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x67, 0x72, 0x61, 0x70, 0x68, 0x69, 0x63, 0x73, 0x70, 0x69, 0x70, 0x65, 0x6C, 0x69, 0x6E, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_SAMPLER_CREATE_NAME_STRING \"SDL.gpu.sampler.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_SAMPLER_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x73, 0x61, 0x6D, 0x70, 0x6C, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_SHADER_CREATE_NAME_STRING \"SDL.gpu.shader.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_SHADER_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x73, 0x68, 0x61, 0x64, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_R_FLOAT \"SDL.gpu.texture.create.d3d12.clear.r\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_R_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x63, 0x6C, 0x65, 0x61, 0x72, 0x2E, 0x72, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_G_FLOAT \"SDL.gpu.texture.create.d3d12.clear.g\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_G_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x63, 0x6C, 0x65, 0x61, 0x72, 0x2E, 0x67, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_B_FLOAT \"SDL.gpu.texture.create.d3d12.clear.b\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_B_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x63, 0x6C, 0x65, 0x61, 0x72, 0x2E, 0x62, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_A_FLOAT \"SDL.gpu.texture.create.d3d12.clear.a\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_A_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x63, 0x6C, 0x65, 0x61, 0x72, 0x2E, 0x61, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_DEPTH_FLOAT \"SDL.gpu.texture.create.d3d12.clear.depth\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_DEPTH_FLOAT => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x63, 0x6C, 0x65, 0x61, 0x72, 0x2E, 0x64, 0x65, 0x70, 0x74, 0x68, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_STENCIL_NUMBER \"SDL.gpu.texture.create.d3d12.clear.stencil\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_TEXTURE_CREATE_D3D12_CLEAR_STENCIL_NUMBER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x64, 0x33, 0x64, 0x31, 0x32, 0x2E, 0x63, 0x6C, 0x65, 0x61, 0x72, 0x2E, 0x73, 0x74, 0x65, 0x6E, 0x63, 0x69, 0x6C, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_TEXTURE_CREATE_NAME_STRING \"SDL.gpu.texture.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_TEXTURE_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x65, 0x78, 0x74, 0x75, 0x72, 0x65, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_BUFFER_CREATE_NAME_STRING \"SDL.gpu.buffer.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_BUFFER_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define SDL_PROP_GPU_TRANSFERBUFFER_CREATE_NAME_STRING \"SDL.gpu.transferbuffer.create.name\"")]
        public static ReadOnlySpan<byte> SDL_PROP_GPU_TRANSFERBUFFER_CREATE_NAME_STRING => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x67, 0x70, 0x75, 0x2E, 0x74, 0x72, 0x61, 0x6E, 0x73, 0x66, 0x65, 0x72, 0x62, 0x75, 0x66, 0x66, 0x65, 0x72, 0x2E, 0x63, 0x72, 0x65, 0x61, 0x74, 0x65, 0x2E, 0x6E, 0x61, 0x6D, 0x65, 0x00 };
    }
}
