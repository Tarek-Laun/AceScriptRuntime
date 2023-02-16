using System;
using System.Runtime.CompilerServices;

namespace AceEngine
{
    public struct RayOut
    {
        public SceneObject Object;
        public bool hit;
    }

    internal struct IntRayOut
    {
        public UInt32 entity;
        public bool hit;
        public Vector2 normal;
    }

    public class Physics
    {
        /// <summary>
        /// Shuts a ray out.
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Direction"></param>
        /// <param name="Length"></param>
        /// <param name="Layer"></param>
        /// <returns></returns>
        public static RayOut Raycast(Vector2 Position, Vector2 Direction, float Length, string Layer)
        {
            IntPhysics.Raycast(ref Position, ref Direction, Length, Layer, out IntRayOut output);
            RayOut rayOut;
            rayOut.hit = output.hit;
            rayOut.Object = new SceneObject();
            rayOut.Object.OnCreate(output.entity);

            return rayOut;
        }
    }

    internal class IntPhysics
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void Raycast(ref Vector2 Position, ref Vector2 Direction, float Length, string Layer, out IntRayOut output);
    }
}
