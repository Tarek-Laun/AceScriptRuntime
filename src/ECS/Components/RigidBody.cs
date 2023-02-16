using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AceEngine
{
    public class Rigidbody : Component
    {
        public Rigidbody() { 
        
        }

        public Rigidbody(UInt32 _id) : base(_id)
        {
        }

        public void AddForce(Vector2 force)
        {
            IntComponent.AddForce(id, ref force);
        }

        public void AddLinearImpulse(Vector2 inpulse)
        {
            IntComponent.AddLinearImpulse(id, ref inpulse);
        }

        public void SetLinearVelocity(Vector2 velocity)
        {
            IntComponent.SetLinearVelocity(id, ref velocity);
        }

        public Vector2 GetLinearVelocity()
        {
            IntComponent.GetLinearVelocity(id, out Vector2 velocity);
            return velocity;
        }
    }
}
