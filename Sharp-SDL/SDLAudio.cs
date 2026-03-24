using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    [NativeTypeName("int")]
    public enum SDL_AudioFormat : uint
    {
        SDL_AUDIO_UNKNOWN = 0x0000U,
        SDL_AUDIO_U8 = 0x0008U,
        SDL_AUDIO_S8 = 0x8008U,
        SDL_AUDIO_S16LE = 0x8010U,
        SDL_AUDIO_S16BE = 0x9010U,
        SDL_AUDIO_S32LE = 0x8020U,
        SDL_AUDIO_S32BE = 0x9020U,
        SDL_AUDIO_F32LE = 0x8120U,
        SDL_AUDIO_F32BE = 0x9120U,
        SDL_AUDIO_S16 = SDL_AUDIO_S16LE,
        SDL_AUDIO_S32 = SDL_AUDIO_S32LE,
        SDL_AUDIO_F32 = SDL_AUDIO_F32LE,
    }

    public partial struct SDL_AudioSpec
    {
        public SDL_AudioFormat format;

        public int channels;

        public int freq;
    }

    public partial struct SDL_AudioStream
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_AudioStreamDataCompleteCallback(void* userdata, [NativeTypeName("const void *")] void* buf, int buflen);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_AudioStreamCallback(void* userdata, SDL_AudioStream* stream, int additional_amount, int total_amount);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_AudioPostmixCallback(void* userdata, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec, float* buffer, int buflen);

    public static unsafe partial class SDLAudio
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumAudioDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetAudioDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetCurrentAudioDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID *")]
        public static extern uint* SDL_GetAudioPlaybackDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID *")]
        public static extern uint* SDL_GetAudioRecordingDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetAudioDeviceName([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetAudioDeviceFormat([NativeTypeName("SDL_AudioDeviceID")] uint devid, SDL_AudioSpec* spec, int* sample_frames);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* SDL_GetAudioDeviceChannelMap([NativeTypeName("SDL_AudioDeviceID")] uint devid, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID")]
        public static extern uint SDL_OpenAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_IsAudioDevicePhysical([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_IsAudioDevicePlayback([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ResumeAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_AudioDevicePaused([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid, float gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_BindAudioStreams([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("SDL_AudioStream *const *")] SDL_AudioStream** streams, int num_streams);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_BindAudioStream([NativeTypeName("SDL_AudioDeviceID")] uint devid, SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnbindAudioStreams([NativeTypeName("SDL_AudioStream *const *")] SDL_AudioStream** streams, int num_streams);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnbindAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_AudioDeviceID")]
        public static extern uint SDL_GetAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioStream* SDL_CreateAudioStream([NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetAudioStreamProperties(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* src_spec, SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAudioStreamFormat(SDL_AudioStream* stream, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetAudioStreamFrequencyRatio(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetAudioStreamGain(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAudioStreamGain(SDL_AudioStream* stream, float gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* SDL_GetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* SDL_GetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAudioStreamInputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAudioStreamOutputChannelMap(SDL_AudioStream* stream, [NativeTypeName("const int *")] int* chmap, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_PutAudioStreamData(SDL_AudioStream* stream, [NativeTypeName("const void *")] void* buf, int len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_PutAudioStreamDataNoCopy(SDL_AudioStream* stream, [NativeTypeName("const void *")] void* buf, int len, [NativeTypeName("SDL_AudioStreamDataCompleteCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_PutAudioStreamPlanarData(SDL_AudioStream* stream, [NativeTypeName("const void *const *")] void** channel_buffers, int num_channels, int num_samples);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetAudioStreamData(SDL_AudioStream* stream, void* buf, int len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetAudioStreamAvailable(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetAudioStreamQueued(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_FlushAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ClearAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_PauseAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ResumeAudioStreamDevice(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_AudioStreamDevicePaused(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_LockAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_UnlockAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAudioStreamGetCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAudioStreamPutCallback(SDL_AudioStream* stream, [NativeTypeName("SDL_AudioStreamCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyAudioStream(SDL_AudioStream* stream);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioStream* SDL_OpenAudioDeviceStream([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* spec, [NativeTypeName("SDL_AudioStreamCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_SetAudioPostmixCallback([NativeTypeName("SDL_AudioDeviceID")] uint devid, [NativeTypeName("SDL_AudioPostmixCallback")] IntPtr callback, void* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_LoadWAV_IO(SDL_IOStream* src, [NativeTypeName("bool")] byte closeio, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_LoadWAV([NativeTypeName("const char *")] sbyte* path, SDL_AudioSpec* spec, [NativeTypeName("Uint8 **")] byte** audio_buf, [NativeTypeName("Uint32 *")] uint* audio_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_MixAudio([NativeTypeName("Uint8 *")] byte* dst, [NativeTypeName("const Uint8 *")] byte* src, SDL_AudioFormat format, [NativeTypeName("Uint32")] uint len, float volume);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_ConvertAudioSamples([NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* src_spec, [NativeTypeName("const Uint8 *")] byte* src_data, int src_len, [NativeTypeName("const SDL_AudioSpec *")] SDL_AudioSpec* dst_spec, [NativeTypeName("Uint8 **")] byte** dst_data, int* dst_len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetAudioFormatName(SDL_AudioFormat format);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSilenceValueForFormat(SDL_AudioFormat format);

        [NativeTypeName("#define SDL_AUDIO_MASK_BITSIZE (0xFFu)")]
        public const uint SDL_AUDIO_MASK_BITSIZE = (0xFFU);

        [NativeTypeName("#define SDL_AUDIO_MASK_FLOAT (1u<<8)")]
        public const uint SDL_AUDIO_MASK_FLOAT = (1U << 8);

        [NativeTypeName("#define SDL_AUDIO_MASK_BIG_ENDIAN (1u<<12)")]
        public const uint SDL_AUDIO_MASK_BIG_ENDIAN = (1U << 12);

        [NativeTypeName("#define SDL_AUDIO_MASK_SIGNED (1u<<15)")]
        public const uint SDL_AUDIO_MASK_SIGNED = (1U << 15);

        [NativeTypeName("#define SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK ((SDL_AudioDeviceID) 0xFFFFFFFFu)")]
        public const uint SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK = ((uint)(0xFFFFFFFFU));

        [NativeTypeName("#define SDL_AUDIO_DEVICE_DEFAULT_RECORDING ((SDL_AudioDeviceID) 0xFFFFFFFEu)")]
        public const uint SDL_AUDIO_DEVICE_DEFAULT_RECORDING = ((uint)(0xFFFFFFFEU));

        [NativeTypeName("#define SDL_PROP_AUDIOSTREAM_AUTO_CLEANUP_BOOLEAN \"SDL.audiostream.auto_cleanup\"")]
        public static ReadOnlySpan<byte> SDL_PROP_AUDIOSTREAM_AUTO_CLEANUP_BOOLEAN => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x61, 0x75, 0x64, 0x69, 0x6F, 0x73, 0x74, 0x72, 0x65, 0x61, 0x6D, 0x2E, 0x61, 0x75, 0x74, 0x6F, 0x5F, 0x63, 0x6C, 0x65, 0x61, 0x6E, 0x75, 0x70, 0x00 };
    }
}
