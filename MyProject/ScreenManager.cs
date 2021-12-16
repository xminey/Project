using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MyProject
{
    class ScreenManager
    {
        public ScreenManager ()
        {

        }
    }

    public interface IScreen
    {
        bool DrawLower { get; }

        bool UpdateLower { get; }

        public void Draw(SpriteBatch sprite) { }

        public void Update() { }
    }
}
