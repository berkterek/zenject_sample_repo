using Zenject;

namespace Sample2Scripts
{
    public class ManagerInstaller1 : MonoInstaller
    {
        public override void InstallBindings()
        {
             //Container.Bind<IGameManager>().To<GameManagerZenject1>().FromComponentInHierarchy().AsSingle().NonLazy();
            
            Container.Bind<IGameManager>().To<GameManagerZenject2>().AsSingle().NonLazy();
        }
    }
}