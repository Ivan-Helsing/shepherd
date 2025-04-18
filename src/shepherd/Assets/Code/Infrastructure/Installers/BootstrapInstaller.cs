using Code.Infrastructure.States;
using Code.Infrastructure.States.Factory;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller, IInitializable
  {
    public void Initialize()
    {
      Container.Resolve<GameStateMachine>().Enter<BootstrapState>();
    }

    public override void InstallBindings()
    {
      Container.Bind<IStateFactory>().To<StateFactory>().AsSingle();
      Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
    }
  }
}