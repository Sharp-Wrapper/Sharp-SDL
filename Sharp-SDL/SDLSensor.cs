using System.Runtime.InteropServices;

namespace Sharp_SDL
{
    public partial struct SDL_Sensor
    {
    }

    public enum SDL_SensorType
    {
        SDL_SENSOR_INVALID = -1,
        SDL_SENSOR_UNKNOWN,
        SDL_SENSOR_ACCEL,
        SDL_SENSOR_GYRO,
        SDL_SENSOR_ACCEL_L,
        SDL_SENSOR_GYRO_L,
        SDL_SENSOR_ACCEL_R,
        SDL_SENSOR_GYRO_R,
        SDL_SENSOR_COUNT,
    }

    public static unsafe partial class SDLSensor
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_SensorID *")]
        public static extern uint* SDL_GetSensors(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetSensorNameForID([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_SensorType SDL_GetSensorTypeForID([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSensorNonPortableTypeForID([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Sensor* SDL_OpenSensor([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Sensor* SDL_GetSensorFromID([NativeTypeName("SDL_SensorID")] uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_PropertiesID")]
        public static extern uint SDL_GetSensorProperties(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* SDL_GetSensorName(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_SensorType SDL_GetSensorType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSensorNonPortableType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("SDL_SensorID")]
        public static extern uint SDL_GetSensorID(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SDL_GetSensorData(SDL_Sensor* sensor, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseSensor(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UpdateSensors();

        [NativeTypeName("#define SDL_STANDARD_GRAVITY 9.80665f")]
        public const float SDL_STANDARD_GRAVITY = 9.80665f;
    }
}
