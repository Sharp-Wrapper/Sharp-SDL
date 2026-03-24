using System;
using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_hid_device
    {
    }

    public enum SDL_hid_bus_type
    {
        SDL_HID_API_BUS_UNKNOWN = 0x00,
        SDL_HID_API_BUS_USB = 0x01,
        SDL_HID_API_BUS_BLUETOOTH = 0x02,
        SDL_HID_API_BUS_I2C = 0x03,
        SDL_HID_API_BUS_SPI = 0x04,
    }

    public unsafe partial struct SDL_hid_device_info
    {
        [NativeTypeName("char *")]
        public sbyte* path;

        [NativeTypeName("unsigned short")]
        public ushort vendor_id;

        [NativeTypeName("unsigned short")]
        public ushort product_id;

        [NativeTypeName("wchar_t *")]
        public ushort* serial_number;

        [NativeTypeName("unsigned short")]
        public ushort release_number;

        [NativeTypeName("wchar_t *")]
        public ushort* manufacturer_string;

        [NativeTypeName("wchar_t *")]
        public ushort* product_string;

        [NativeTypeName("unsigned short")]
        public ushort usage_page;

        [NativeTypeName("unsigned short")]
        public ushort usage;

        public int interface_number;

        public int interface_class;

        public int interface_subclass;

        public int interface_protocol;

        public SDL_hid_bus_type bus_type;

        [NativeTypeName("struct SDL_hid_device_info *")]
        public SDL_hid_device_info* next;
    }

    public static unsafe partial class SDLHidApi
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_init();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_exit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Uint32")]
        public static extern uint SDL_hid_device_change_count();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_hid_device_info* SDL_hid_enumerate([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_hid_free_enumeration(SDL_hid_device_info* devs);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_hid_device* SDL_hid_open([NativeTypeName("unsigned short")] ushort vendor_id, [NativeTypeName("unsigned short")] ushort product_id, [NativeTypeName("const wchar_t *")] ushort* serial_number);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_hid_device* SDL_hid_open_path([NativeTypeName("const char *")] sbyte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_hid_get_properties(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_write(SDL_hid_device* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] UIntPtr length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_read_timeout(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] UIntPtr length, int milliseconds);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_read(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] UIntPtr length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_set_nonblocking(SDL_hid_device* dev, int nonblock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_send_feature_report(SDL_hid_device* dev, [NativeTypeName("const unsigned char *")] byte* data, [NativeTypeName("size_t")] UIntPtr length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_feature_report(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] UIntPtr length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_input_report(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* data, [NativeTypeName("size_t")] UIntPtr length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_close(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_manufacturer_string(SDL_hid_device* dev, [NativeTypeName("wchar_t *")] ushort* @string, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_product_string(SDL_hid_device* dev, [NativeTypeName("wchar_t *")] ushort* @string, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_serial_number_string(SDL_hid_device* dev, [NativeTypeName("wchar_t *")] ushort* @string, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_indexed_string(SDL_hid_device* dev, int string_index, [NativeTypeName("wchar_t *")] ushort* @string, [NativeTypeName("size_t")] UIntPtr maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_hid_device_info* SDL_hid_get_device_info(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_hid_get_report_descriptor(SDL_hid_device* dev, [NativeTypeName("unsigned char *")] byte* buf, [NativeTypeName("size_t")] UIntPtr buf_size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_hid_ble_scan([NativeTypeName("bool")] byte active);

        [NativeTypeName("#define SDL_PROP_HIDAPI_LIBUSB_DEVICE_HANDLE_POINTER \"SDL.hidapi.libusb.device.handle\"")]
        public static ReadOnlySpan<byte> SDL_PROP_HIDAPI_LIBUSB_DEVICE_HANDLE_POINTER => new byte[] { 0x53, 0x44, 0x4C, 0x2E, 0x68, 0x69, 0x64, 0x61, 0x70, 0x69, 0x2E, 0x6C, 0x69, 0x62, 0x75, 0x73, 0x62, 0x2E, 0x64, 0x65, 0x76, 0x69, 0x63, 0x65, 0x2E, 0x68, 0x61, 0x6E, 0x64, 0x6C, 0x65, 0x00 };
    }
}
