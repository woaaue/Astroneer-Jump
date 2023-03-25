using UnityEngine.SceneManagement;
using UnityEngine;

public sealed class GameButtonPanel : MonoBehaviour
{
    public void ExitMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
