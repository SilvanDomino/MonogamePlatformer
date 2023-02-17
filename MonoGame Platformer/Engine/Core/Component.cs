using System;
using Engine.core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Engine.core
{
    public abstract class Component
    {
        private bool enabled = true;
        private Entity entity;

        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        public Entity Entity
        {
            get { return entity; }
        }

        public virtual void Start()
        {
            // This method is called when the component is added to a game object
        }

        public virtual void Update(TimeSpan deltaTime)
        {
            // This method is called every frame to update the component
        }

        public virtual void Draw(TimeSpan deltaTime)
        {
            // This method is called every frame to render the component
        }

        public virtual void OnEnable()
        {
            // This method is called when the component is enabled
        }

        public virtual void OnDisable()
        {
            // This method is called when the component is disabled
        }

        protected internal virtual void SetGameObject(Entity gameObject)
        {
            this.entity = gameObject;
        }
    }
}
