﻿namespace Code.Infrastructure.States.Factory
{
  public interface IStateFactory
  {
    TState Create<TState>() where TState : IState;
    TState Create<TState>(params object[] args) where TState : IState;
  }
}