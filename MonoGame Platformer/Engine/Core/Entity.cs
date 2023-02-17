using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Engine.core
{
    public class Entity
    {
        private int id;
        private Dictionary<Type, Component> components;

        public int Id { get { return id; } }

        public Entity(int id)
        {
            this.id = id;
            components = new Dictionary<Type, Component>();
        }

        public void AddComponent(Component component)
        {
            components.Add(component.GetType(), component);
        }

        public void RemoveComponent<T>() where T : Component
        {
            components.Remove(typeof(T));
        }

        public T GetComponent<T>() where T : Component
        {
            Component component;
            if (components.TryGetValue(typeof(T), out component))
            {
                return (T)component;
            }
            else
            {
                return null;
            }
        }

        public bool HasComponent<T>() where T : Component
        {
            return components.ContainsKey(typeof(T));
        }
    }
}
