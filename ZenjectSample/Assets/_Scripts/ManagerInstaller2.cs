using Zenject;

namespace Sample2Scripts
{
    public class ManagerInstaller2 : MonoInstaller
    {
        public override void InstallBindings()
        {
            //Container.Bind<IGameManagerDont>().To<GameManagerZenjectDont1>().FromComponentInHierarchy().AsSingle().NonLazy();
            
            Container.Bind<IGameManagerDont>().To<GameManagerZenjectDont2>().AsSingle().NonLazy();
        }
    }
}