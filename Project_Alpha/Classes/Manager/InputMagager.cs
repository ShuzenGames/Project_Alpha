using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Project_Alpha
{
    class InputMagager
    {
        //public KeyboardState ks;
        //public KeyboardState oldKS;
        //public MouseState ms;
        //public InputState state;

        //Alle Eingabekonfigurationen


        public void Update(GameTime gameTime)
        {

        }
    }

    /// <summary>
    /// Status zum unterscheiden von Eingabesituationen
    /// </summary>
    public enum InputState
    {
        Text,
        Playing,
        Menu,
        Pause
    }
}
