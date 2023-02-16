using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AceEngine
{
    internal class IntComponent
    {

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static void AddComponent(UInt32 id, Type type);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool HasComponent(UInt32 id, Type type);

        // Object
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetName(UInt32 entity, out String name);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool SetName(UInt32 entity, String name);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetTag(UInt32 entity, out String name);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool SetTag(UInt32 entity, String name);

        // Transform Component
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetTransformPosition(UInt32 entity, out Vector2 position);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool SetTransformPosition(UInt32 entity, ref Vector2 position);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetTransformScale(UInt32 entity, out Vector2 position);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool SetTransformScale(UInt32 entity, ref Vector2 position);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetTransformRotation(UInt32 entity, out Vector3 position);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool SetTransformRotation(UInt32 entity, ref Vector3 position);

        // Rigid Body Component
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool AddForce(UInt32 entity, ref Vector2 force);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool AddLinearImpulse(UInt32 entity, ref Vector2 force);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool SetLinearVelocity(UInt32 entity, ref Vector2 force);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        public extern static bool GetLinearVelocity(UInt32 entity, out Vector2 force);
    }
}
