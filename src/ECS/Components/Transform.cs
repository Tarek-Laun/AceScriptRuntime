using AceEngine;
using System;

namespace AceEngine
{
    public class Transform : Component
    {
        public Vector2 Position { 
            get {
                IntComponent.GetTransformPosition(id, out Vector2 pos);
                return pos;
            } set
            {
                IntComponent.SetTransformPosition(id, ref value);
            }
        }

        public Vector2 Scale
        {
            get
            {
                IntComponent.GetTransformScale(id, out Vector2 scale);
                return scale;
            }set
            {
                IntComponent.SetTransformScale(id, ref value);
            }
        }

        public Vector3 Rotation
        {
            get
            {
                IntComponent.GetTransformRotation(id, out Vector3 rotation);
                return rotation;
            }set
            {
                IntComponent.SetTransformRotation(id, ref value);
            }
        }
        
        public Transform(UInt32 _id) : base(_id)
        {

        }
    }
}
