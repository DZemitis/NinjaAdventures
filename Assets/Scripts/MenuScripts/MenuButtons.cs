using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Menu()
    {
        Application.LoadLevel(0);
    }
}
