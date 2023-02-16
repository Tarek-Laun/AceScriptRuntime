using System.Runtime.CompilerServices;

namespace AceEngine
{
    public enum Controller
    {
        Controller1 = 0,
        Controller2 = 1,
        Controller3 = 2,
        Controller4 = 4
    }

    public enum ControllerButton
    {
        Up = 0x0001,
        Down = 0x0002,
        Left = 0x0004,
        Right = 0x0008,
        Sart = 0x0010,
        Back = 0x0020,
        LeftStick = 0x0040,
        RightStick = 0x0080,
        LeftShoulder = 0x0100,
        RightShoulder = 0x0200,
        LeftTrigger = 0x0400,
        RightTrigger = 0x0800,
        A = 0x1000,
        B = 0x2000,
        X = 0x4000,
        Y = 0x8000
    }

    public class Input
    {
        // Keyboard
        public static bool GetKey(KeyCodes keyCode)
        {
            return IntInput.GetKey((int) keyCode);
        }

        public static bool GetKeyDown(KeyCodes keyCode)
        {
            return IntInput.GetKeyDown((int) keyCode);
        }

        // Mouse
        public static float GetMouseWheel()
        {
            return IntInput.GetMouseWheel();
        }

        public static void ShowCursor(bool show)
        {
            IntInput.ShowCursor(show);
        }

        public static void SetMousePosition(int x, int y)
        {
            IntInput.SetMousePosition(x, y);
        }

        public static Vector2 GetMousePosition()
        {
            IntInput.GetMousePosition(out Vector2 mousePos);
            return mousePos;
        }

        public static Vector2 GetScreenSize()
        {
            IntInput.GetScreenSize(out Vector2 screenSize);
            return screenSize;
        }

        // Controller
        public static bool GetControllerButton(Controller ControllerID, ControllerButton Button)
        {
            return IntInput.GetControllerButton((int) ControllerID, (int) Button);
        }

        public static bool GetControllerButtonDown(Controller ControllerID, ControllerButton Button)
        {
            return IntInput.GetControllerButtonDown((int) ControllerID, (int)Button);
        }

        public static Vector2 GetThumbStick(Controller ControllerID, ControllerButton Button)
        {
            IntInput.GetThumbStick((int) ControllerID, (int)Button, out Vector2 stick);
            return stick;
        }

        public static float GetTrigger(Controller ControllerID, ControllerButton trigger)
        {
            return IntInput.GetTrigger((int) ControllerID, (int) trigger);
        }

        public static void SetVibrationEffect(Controller ControllerID, int left, int right)
        {
            IntInput.SetVibrationEffect((int) ControllerID, left, right);
        }
    }
}
