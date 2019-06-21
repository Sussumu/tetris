using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris.Base
{
    public interface IScene
    {
        void Draw(SpriteBatch spriteBatch);
        void LoadContent(ContentManager content);
    }
}