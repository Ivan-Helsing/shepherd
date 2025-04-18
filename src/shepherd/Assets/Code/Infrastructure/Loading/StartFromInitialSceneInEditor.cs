using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Code.Infrastructure.Loading
{
  public class StartFromInitialSceneInEditor : MonoBehaviour
  {
#if UNITY_EDITOR
    public bool WillStartFromInitialScene = true;
    
    private const int InitialSceneIndex = 0;

    private void Awake()
    {
      if(!WillStartFromInitialScene || ProjectContext.HasInstance || IsInitialScene())
        return;

      foreach (GameObject root in gameObject.scene.GetRootGameObjects()) 
        root.SetActive(false);
      
      SceneManager.LoadScene(InitialSceneIndex);
    }

    private static bool IsInitialScene() => 
      SceneManager.GetActiveScene().buildIndex == InitialSceneIndex;
#endif
  }
}