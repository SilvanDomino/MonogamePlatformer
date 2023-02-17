using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.core
{
    internal class GameObject : Entity
    {
        public GameObject(int id):base(id) { }

        public void Update(GameTime gameTime)
        {
            // Update game objects
            foreach (GameObject gameObject in ent)
            {
                gameObject.Update(gameTime);
            }

            // Update camera position to follow player
            camera.Position = new Vector2(player.Position.X - camera.ViewportWidth / 2, 0);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // Draw game objects
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Draw(spriteBatch);
            }
        }
    }
}
