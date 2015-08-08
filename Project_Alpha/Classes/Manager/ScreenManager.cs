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
    public class ScreenManager
    {
        public GameScreen CurrendScreen { get; private set; }
        private GameScreen[] gameScreens;
        private ContentManager _content;
        public static ScreenManager Instance { get; private set; }

        public void ChangeScreen(int screenID)
        {
            this.CurrendScreen.UnloadContent();
            this.CurrendScreen = gameScreens[screenID];
            this.CurrendScreen.LoadContent(_content);            
        }

        public ScreenManager(GameScreen[] gameScreens)
        {
            this.gameScreens = gameScreens;
            this.CurrendScreen = gameScreens[0];
            Instance = this;
        }

        public void UnloadContent()
        {
            this._content.Unload();
        }

        public void LoadContent(Game game)
        {
            this._content = game.Content;
            CurrendScreen.LoadContent(game.Content);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.CurrendScreen.Draw(spriteBatch);
        }

        public void Update(GameTime gameTime)
        {
            this.CurrendScreen.Update(gameTime);
        }
    }
}
