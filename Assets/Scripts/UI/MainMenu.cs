using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ChangeToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ChangeToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ChangeToCreditsScene()
    {
        SceneManager.LoadScene("CreditsScene");
    }
}
