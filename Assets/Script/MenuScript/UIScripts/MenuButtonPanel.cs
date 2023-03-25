using UnityEngine.SceneManagement;
using UnityEngine;

public sealed class MenuButtonPanel : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
