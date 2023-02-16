using System;

namespace AceEngine
{
    public class SceneObject
    {
        public string Name { get { IntComponent.GetName(id, out String name); return name; } set { IntComponent.SetName(id, value); } }
        public string Tag { get { IntComponent.GetTag(id, out String name); return name; } set { IntComponent.SetTag(id, value); } }
        public UInt32 id;

        public virtual void OnCreate(UInt32 _id)
        {
            transform = new Transform(_id);
            id = _id;
        }

        public void AddComponent<T>()
        {
            if (!HasComponent<T>())
                return;

            Type componentType = typeof(T);
            IntComponent.AddComponent(id, componentType);
        }

        public bool HasComponent<T>()
        {
            Type componentType = typeof(T);
            return IntComponent.HasComponent(id, componentType);
        }
        
        public T GetComponent<T>() where T : Component, new() 
        {
            if (!HasComponent<T>())
                return null;

            return new T() { id = id };
        }

        public Transform transform;
    }
}