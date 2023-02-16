using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AceEngine
{
    public class Log
    {
        /// <summary>
        /// Send Vectore2 in Console
        /// </summary>
        /// <param name="message"></param>
        public static void Message(Vector2 vec2)
        {
            IntLog.Message(string.Format("{0},{1}", vec2.x, vec2.y));
        }

        /// <summary>
        /// Send Vectore2 in Console
        /// </summary>
        /// <param name="message"></param>
        public static void Warning(Vector2 vec2)
        {
            IntLog.Warning(string.Format("{0},{1}", vec2.x, vec2.y));
        }

        /// <summary>
        /// Send Vectore2 in Console
        /// </summary>
        /// <param name="message"></param>
        public static void Error(Vector2 vec2)
        {
            IntLog.Error(string.Format("{0},{1}", vec2.x, vec2.y));
        }

        /// <summary>
        /// Send Vectore3 in Console
        /// </summary>
        /// <param name="message"></param>
        public static void Message(Vector3 vec3)
        {
            IntLog.Message(string.Format("{0},{1},{2}", vec3.x, vec3.y, vec3.z));
        }

        /// <summary>
        /// Send Vectore3 in Console
        /// </summary>
        /// <param name="message"></param>
        public static void Warning(Vector3 vec3)
        {
            IntLog.Warning(string.Format("{0},{1},{2}", vec3.x, vec3.y, vec3.z));
        }

        /// <summary>
        /// Send Vectore3 in Console
        /// </summary>
        /// <param name="message"></param>
        public static void Error(Vector3 vec3)
        {
            IntLog.Error(string.Format("{0},{1},{2}", vec3.x, vec3.y, vec3.z));
        }

        /// <summary>
        /// Send Message in Console
        /// </summary>
        /// <param name="message"></param>
        public static void Message(string message)
        {
            IntLog.Message(message);
        }

        /// <summary>
        /// Send Warning in Console
        /// </summary>
        /// <param name="message"></param>
        public static void Warning(string message)
        {
            IntLog.Warning(message);
        }

        /// <summary>
        /// Send Error in Console
        /// </summary>
        /// <param name="message"></param>
        public static void Error(string message)
        {
            IntLog.Error(message);
        }
    }

    internal class IntLog
    {

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void Message(string message);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void Warning(string message);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void Error(string message);
    }
}
