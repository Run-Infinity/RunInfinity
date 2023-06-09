using UnityEngine;
using UnityEngine.SceneManagement;

public class NPC_Collision : MonoBehaviour
{
    public GameObject character;
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("collision ...");
        SceneManager.LoadScene("Main_Menu");
        if (collision.gameObject == character)
        {
            Debug.Log("collision ...");
            
        }
    }
}

