using UnityEngine;

public sealed class Defeat : MonoBehaviour
{
    [SerializeField] private GameObject _character;
    [SerializeField] private GameObject _defeatWindow;

    private void Update()
    {
        if (_character == null)
        {
            LooseGame();
        }
    }

    private void LooseGame()
    {
        if (!_defeatWindow.activeInHierarchy)
            _defeatWindow.SetActive(true);
    }
}
