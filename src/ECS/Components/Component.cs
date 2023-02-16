using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceEngine
{
    public class Component
    {
        public Component() { }

        public Component(UInt32 _id) {
            id = _id;
        }

        public UInt32 id;
    }
}
