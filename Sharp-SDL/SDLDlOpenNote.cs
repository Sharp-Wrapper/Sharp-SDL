using System;

namespace Sharp_SDL
{
    public static partial class SDLDlOpenNote
    {
        [NativeTypeName("#define SDL_ELF_NOTE_DLOPEN_PRIORITY_SUGGESTED \"suggested\"")]
        public static ReadOnlySpan<byte> SDL_ELF_NOTE_DLOPEN_PRIORITY_SUGGESTED => new byte[] { 0x73, 0x75, 0x67, 0x67, 0x65, 0x73, 0x74, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_ELF_NOTE_DLOPEN_PRIORITY_RECOMMENDED \"recommended\"")]
        public static ReadOnlySpan<byte> SDL_ELF_NOTE_DLOPEN_PRIORITY_RECOMMENDED => new byte[] { 0x72, 0x65, 0x63, 0x6F, 0x6D, 0x6D, 0x65, 0x6E, 0x64, 0x65, 0x64, 0x00 };

        [NativeTypeName("#define SDL_ELF_NOTE_DLOPEN_PRIORITY_REQUIRED \"required\"")]
        public static ReadOnlySpan<byte> SDL_ELF_NOTE_DLOPEN_PRIORITY_REQUIRED => new byte[] { 0x72, 0x65, 0x71, 0x75, 0x69, 0x72, 0x65, 0x64, 0x00 };
    }
}
