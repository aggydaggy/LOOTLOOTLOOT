using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace LootLootLoot
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class LootLootLoot : Core
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public LootLootLoot() : base( width: 1280, height: 768, isFullScreen: false, enableEntitySystems: false )
        { }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            base.Initialize();
            Window.AllowUserResizing = true;

            // create our Scene with the DefaultRenderer and a clear color of CornflowerBlue
            var myScene = Scene.createWithDefaultRenderer(Color.CornflowerBlue);

            // set the scene so Nez can take over
            scene = myScene;
        }
    }
}
