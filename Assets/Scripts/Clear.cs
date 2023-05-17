using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
  
  public const string GAME_SCENE = "game";
  [UsedImplicitly]
  public void ClearBoard()
  {
    SceneManager.LoadSceneAsync(GAME_SCENE);
  }
    
   
    
}
