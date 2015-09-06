using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project_Alpha.Classes.Manager;

namespace Project_Alpha
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        ScreenManager screenManager;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            GameScreen[] screens = new GameScreen[3];
            screens[0] = new SplashScreen();
            screens[1] = new MenuScreen();
            screens[2] = new PlayScreen();
            screenManager = new ScreenManager(screens);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            screenManager.LoadContent(this);
        }

        protected override void UnloadContent()
        {
            screenManager.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            screenManager.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
            spriteBatch.Begin();
            screenManager.Draw(spriteBatch);
            spriteBatch.End();
        }
    }
}
