using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneEnd : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Credits");
        }
    }
}
