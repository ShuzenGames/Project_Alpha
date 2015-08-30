using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Project_Alpha.Classes
{
    class Tile
    {
        public Vector2 pos;
        private Texture2D texture;        
        private Movable movable; //gibt an ob der Tile passierbar ist. Gibt ggf. die richtung an
        private bool isOverlaying; //noch nicht eingebunden
        private Rectangle rect; //Größe des Tilefeldes

        public Tile(Vector2 pos, Texture2D texture, Movable movable, Rectangle rect)
        {
            this.pos = pos;
            this.texture = texture;
            this.movable = movable;
            this.rect = rect;
        }

        public void Update(GameTime gt)
        {

        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(this.texture, this.pos, Color.White);
        }
    }

    public enum Movable
    {
        All_sides,
        Vertical,
        Horizontal,
        Underneath,
        Not
    }
}
