using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Tetris.Loaders;

namespace Tetris
{
    public class MainGame : Game
    {
        GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;

        private TextureLoader _textureLoader;

        public MainGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _textureLoader = new TextureLoader(Content);
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            foreach (var texture in _textureLoader.LoadedTextures)
                _spriteBatch.Draw(texture, new Vector2(), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
