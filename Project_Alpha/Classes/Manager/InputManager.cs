using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Project_Alpha
{
    class InputManager
    {
        private KeyboardState ks = Keyboard.GetState();
        private KeyboardState oldKS;
        private MouseState ms;
        private static InputManager instance;
        public InputState state;
        public static InputManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new InputManager();
                return instance;
            }
        }


        private InputManager()
        {

        }


        public void Update(GameTime gameTime)
        {
            if (state == InputState.Menu)
            {

            }
            else if (state == InputState.Pause)
            {

            }
            else if(state == InputState.Playing)
            {

            }
            else if (state == InputState.Text)
            {

            }
            oldKS = ks;
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
