using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Tetris.Base;
using Tetris.Props;

namespace Tetris.Scenes
{
    public class MainScene : IScene
    {
        public List<Renderable2D> RenderableGameObjects { get; }

        public MainScene()
        {
            RenderableGameObjects = new List<Renderable2D>
            {
                new StraightTetromino("assets/straight")
            };
        }

        public void LoadContent(ContentManager content)
        {
            foreach (var gameObject in RenderableGameObjects)
                gameObject.Load(content);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var gameObject in RenderableGameObjects)
                gameObject.Draw(spriteBatch);
        }
    }
}
