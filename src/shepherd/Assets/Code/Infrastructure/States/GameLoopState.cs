namespace Code.Infrastructure.States
{
  public class GameLoopState : IState
  {
    private readonly IGameStateMachine _stateMachine;

    // private PlayingFeature _playingFeature;
    
    public GameLoopState(IGameStateMachine stateMachine) => 
      _stateMachine = stateMachine;

    public void Enter()
    {
      //Create PlayingFeature
    }
  }
}