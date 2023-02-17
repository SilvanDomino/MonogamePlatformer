using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Engine.core
{
    

    public class Camera
    {
        public Vector2 Position { get; set; }
        public float Zoom { get; set; }
        public float Rotation { get; set; }
        public int ViewportWidth { get; set; }
        public int ViewportHeight { get; set; }

        public Camera(Vector2 position, float zoom, float rotation, int viewPortWidth, int viewPortHeight)
        {
            this.Position = position;
            this.Zoom = zoom;
            this.Rotation = rotation;
            this.ViewportWidth = viewPortWidth;
            this.ViewportHeight = viewPortHeight;
        }
        public Camera(int viewPortWidth, int viewPortHeight) 
        {
            this.Position = new Vector2(0, 0);
            this.Zoom = 1f;
            this.Rotation = 0f;
            this.ViewportWidth = viewPortWidth;
            this.ViewportHeight = viewPortHeight;
        }

        public Matrix GetViewMatrix()
        {
            return Matrix.CreateTranslation(new Vector3(-Position, 0)) *
                   Matrix.CreateRotationZ(Rotation) *
                   Matrix.CreateScale(Zoom) *
                   Matrix.CreateTranslation(new Vector3(ViewportWidth * 0.5f, ViewportHeight * 0.5f, 0));
        }
    }

}
