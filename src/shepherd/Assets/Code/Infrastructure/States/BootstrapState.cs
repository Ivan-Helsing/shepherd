using Code.Infrastructure.Scenes;

namespace Code.Infrastructure.States
{
  public class BootstrapState : IState
  {
    private const string Main = "Main";
    
    private readonly IGameStateMachine _stateMachine;
    private readonly ISceneLoader _sceneLoader;

    public BootstrapState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
    {
      _stateMachine = stateMachine;
      _sceneLoader = sceneLoader;
    }

    public void Enter() => 
      _sceneLoader.LoadScene(Main, MoveToLoadLevelState);

    private void MoveToLoadLevelState() => 
      _stateMachine.Enter<LoadLevelState>();
  }
}