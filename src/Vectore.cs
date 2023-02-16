using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceEngine
{
    public struct Vector2
    {
        public Vector2()
        {
            x = 0;
            y = 0;
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        public static bool operator==(Vector2 a, Vector2 b)
        {
            if (a.x == b.x && a.y == b.y)
                return true;
            else
                return false;
        }

        public static bool operator!=(Vector2 a, Vector2 b)
        {
            if (a.x != b.x || a.y != b.y)
                return true;
            else
                return false;
        }

        public string ToString()
        {
            return string.Format("{0},{1}", x, y);
        }

        public float x;
        public float y;
    }

    public struct Vector3
    {
        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static bool operator ==(Vector3 a, Vector3 b)
        {
            if (a.x == b.x && a.y == b.y && a.z == b.z)
                return true;
            else
                return false;
        }

        public static bool operator !=(Vector3 a, Vector3 b)
        {
            if (a.x != b.x || a.y != b.y || a.z != b.z)
                return true;
            else
                return false;
        }

        public string ToString()
        {
            return string.Format("{0},{1},{2}", x, y, z);
        }

        public float x, y, z;
    }

    public struct Vector4
    {
        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static Vector4 operator +(Vector4 a, Vector4 b)
        {
            return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }

        public static Vector4 operator -(Vector4 a, Vector4 b)
        {
            return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }

        public static bool operator ==(Vector4 a, Vector4 b)
        {
            if (a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w)
                return true;
            else
                return false;
        }

        public static bool operator !=(Vector4 a, Vector4 b)
        {
            if (a.x != b.x || a.y != b.y || a.z != b.z || a.w != b.w)
                return true;
            else
                return false;
        }

        public string ToString()
        {
            return string.Format("{0},{1},{2},{3}", x, y, z, w);
        }

        public float x, y, z, w;
    }
}
