using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame()
  {
	  //You can change '1' with scene name; ("Level 1")
	  SceneManager.LoadSceneAsync("LEVEL 1");
  }

  public void QuitGame()
  {
	  Application.Quit();
  }
}
