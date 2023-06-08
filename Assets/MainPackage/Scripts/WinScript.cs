using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public GameObject character;
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("collision ...");
        SceneManager.LoadScene("win_2");
        if (collision.gameObject == character)
        {
            Debug.Log("collision ...");

        }
    }
}