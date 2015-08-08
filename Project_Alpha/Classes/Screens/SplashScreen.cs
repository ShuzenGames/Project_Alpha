using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Project_Alpha
{
    public class SplashScreen : GameScreen
    {

        private int counter = 0, timer = 60 * 4;
        private Texture2D splash;

        public override void UnloadContent()
        {
            base.UnloadContent();
            content.Unload();
        }

        public override void LoadContent(ContentManager content)
        {
            splash = content.Load<Texture2D>("ShuzenGames");
            base.LoadContent(content);       
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            spriteBatch.Draw(splash, new Rectangle(0, 0, 200, 200), Color.White);
        }

        public override void Update(GameTime gameTime)
        {
            if (counter > timer)
            {
                ScreenManager.Instance.ChangeScreen(1);
            }
            counter++;
        }
    }
}
