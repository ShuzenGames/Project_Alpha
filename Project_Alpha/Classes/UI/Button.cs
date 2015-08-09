using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project_Alpha
{
    public class Button : BaseButton, ButtonInterface
    {

        public Button(Vector2 pos, Texture2D texture) 
            : base(pos, texture)
        {

        }

        public void PerformClick()
        {

        }

        public void NotifyDefault(bool isDefault)
        {

        }
    }
}
