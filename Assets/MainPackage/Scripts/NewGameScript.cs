using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewGameScript : MonoBehaviour
{
    public Button Play_GameBtn;
    public Button ExitBtn;

    private void Awake()
    {
        // Attach button click listeners
        Play_GameBtn.onClick.AddListener(StartGame);
        ExitBtn.onClick.AddListener(QuitGame);
    }

    private void StartGame()
    {
        // Switch to the Level0 scene
        SceneManager.LoadScene("Level0_TEST");
    }

    private void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}


