using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

  public void RestartButton()
  {
        SceneManager.LoadScene("Levels/Level1");
  }
}
