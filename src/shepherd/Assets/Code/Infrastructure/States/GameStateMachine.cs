using System;
using System.Collections.Generic;
using Code.Infrastructure.States.Factory;

namespace Code.Infrastructure.States
{
  public class GameStateMachine : IGameStateMachine
  {
    private readonly Dictionary<Type, IState> _states;

    public GameStateMachine(IStateFactory states)
    {
      _states = new Dictionary<Type, IState>
      {
        [typeof(BootstrapState)] = states.Create<BootstrapState>(this),
        [typeof(LoadLevelState)] = states.Create<LoadLevelState>(this),
      };
    }

    public void Enter<TState>() where TState : IState
    {
      IState state = _states[typeof(TState)];
      state.Enter();
    }
  }
}