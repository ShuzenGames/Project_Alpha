using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project_Alpha
{
    public abstract class BaseUI
    {
        public Vector2 Pos { get; private set; }
        public Texture2D Texture { get; private set; }
        public bool Hidden { get; private set; }
        public bool Active { get; private set; }

        public BaseUI(Vector2 pos, Texture2D texture)
        {
            this.Pos = pos;
            this.Texture = texture;
            this.Hidden = false;
            this.Active = true;
        }

        public abstract void Init();

        public virtual void Update(GameTime gt)
        {

        }

        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(this.Texture, this.Pos, Color.White);
        }

        public virtual void Unload()
        {
            
        }
    }
}
