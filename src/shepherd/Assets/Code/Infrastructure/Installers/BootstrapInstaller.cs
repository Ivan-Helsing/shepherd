using Code.Infrastructure.Scenes;
using Code.Infrastructure.States;
using Code.Infrastructure.States.Factory;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner
  {
    public void Initialize()
    {
      Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
    }

    public override void InstallBindings()
    {
      BindInstaller();
      BindInfrastructureServices();
    }

    private void BindInstaller()
    {
      Container.BindInterfacesAndSelfTo<BootstrapInstaller>().FromInstance(this).AsSingle();
    }

    private void BindInfrastructureServices()
    {
      Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
      Container.Bind<IStateFactory>().To<StateFactory>().AsSingle();
      Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
    }
  }
}