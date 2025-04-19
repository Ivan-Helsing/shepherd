using System.Collections;
using UnityEngine;

namespace Code.Infrastructure.Scenes
{
  public interface ICoroutineRunner
  {
    Coroutine StartCoroutine(IEnumerator routine);
  }
}