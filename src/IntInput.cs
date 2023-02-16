using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AceEngine
{
    internal class IntInput
    {
        // Keyboard
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetKey(int keyCode);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetKeyDown(int keyCode);

        // Mouse
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static float GetMouseWheel();

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void ShowCursor(bool show);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void SetMousePosition(int x, int y);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void GetScreenSize(out Vector2 screenSize);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void GetMousePosition(out Vector2 output);

        // Controller

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetControllerButton(int conID, int button);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetControllerButtonDown(int conID, int button);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void GetThumbStick(int conID, int stick, out Vector2 output);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static float GetTrigger(int conID, int trigger);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void SetVibrationEffect(int conID, int left, int right);
    }
}
