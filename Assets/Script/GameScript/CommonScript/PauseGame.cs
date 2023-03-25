using UnityEngine;

public sealed class PauseGame : MonoBehaviour
{
    public void PauseTheGame()
    {
        Time.timeScale = 0;
    }
}
