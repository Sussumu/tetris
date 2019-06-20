using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Tetris.Props;

namespace Tetris.Loaders
{
    public class TextureLoader
    {
        private readonly List<Texture2D> _loadedTextures;
        public IReadOnlyCollection<Texture2D> LoadedTextures => _loadedTextures.AsReadOnly();

        public TextureLoader(ContentManager content)
        {
            _loadedTextures = new List<Texture2D>
            {
                content.Load<Texture2D>(StraightTetromino.Texture)
            };
        }
    }
}
