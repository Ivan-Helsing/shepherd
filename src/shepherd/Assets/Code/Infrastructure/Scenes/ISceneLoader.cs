using System;

namespace Code.Infrastructure.Scenes
{
  public interface ISceneLoader
  {
    void LoadScene(string sceneName, Action onLoaded = null);
  }
}