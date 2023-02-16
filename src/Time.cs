using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AceEngine
{
    public class Time
    {
        /// <summary>
        /// Get the Time of the last Frame.
        /// </summary>
        /// <returns></returns>
        public static float DeltaTime()
        {
            return IntTime.DeltaTime();
        }

        /// <summary>
        /// Get the Curent Unix Time Stemp.
        /// </summary>
        /// <returns>Unix Time Stemp</returns>
        public static int GetTime()
        {
            return IntTime.GetTime();
        }
    }

    internal class IntTime
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static float DeltaTime();

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static int GetTime();
    }
}
