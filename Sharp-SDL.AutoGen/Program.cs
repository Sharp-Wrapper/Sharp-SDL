namespace Sharp_SDL.AutoGen
{
    internal unsafe class Program
    {
        static void Main(string[] args)
        {
            int a = SDLInit.SDL_Init(0x00000010U);
            Console.WriteLine(a);

            int count = 0;
            var deviceId = SDLAudio.SDL_GetAudioPlaybackDevices(&count);
            Console.WriteLine(count);
            var audioSpec = new SDL_AudioSpec
            {
                freq = 48000,
                channels = 2,
                format = SDL_AudioFormat.SDL_AUDIO_S16LE
            };
            var c = SDLAudio.SDL_OpenAudioDevice(deviceId[0], &audioSpec);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }

  
}
