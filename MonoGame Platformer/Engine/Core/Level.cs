using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.core
{
    public class Level
    {
        private List<GameObject> gameObjects = new List<GameObject>();
        //private Player player;
        private Camera camera;

        public Level(ContentManager content, string levelFile)
        {
            LoadLevel(content, levelFile);
        }

        private void LoadLevel(ContentManager content, string levelFile)
        {
            // Load level data from file and create game objects
            // ...

            // Add game objects to level
            //gameObjects.Add(player);
            gameObjects.Add(camera);
            // ...
        }

        public void Update(GameTime gameTime)
        {
            // Update game objects
            foreach (GameObject gameObject in gameObjects)
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
