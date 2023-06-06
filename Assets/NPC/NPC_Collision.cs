using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC_Collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Main Camera")
        {
            SceneManager.LoadScene("NewGame");
        }
    }
}

