using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Tetris.Base
{
    public class Renderable2D : GameObject
    {
        public string TextureName { get; }
        private Texture2D _texture2D;

        public Renderable2D(string textureName)
        {
            if (string.IsNullOrWhiteSpace(textureName))
                throw new ArgumentNullException(nameof(textureName));

            TextureName = textureName;
        }

        public void Load(ContentManager content)
        {
            _texture2D = content.Load<Texture2D>(TextureName);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture2D, new Vector2(), Color.AliceBlue);
        }
    }
}
