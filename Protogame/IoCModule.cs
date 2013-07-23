using Ninject.Modules;

namespace Protogame
{
    public class IoCModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRenderUtilities>().To<DefaultRenderUtilities>();
            this.Bind<IGameContext>().To<DefaultGameContext>();
            this.Bind<IUpdateContext>().To<DefaultUpdateContext>();
            this.Bind<IRenderContext>().To<DefaultRenderContext>();
        }
    }
}
