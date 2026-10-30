using UnityEngine;
using UnityEngine.SceneManagement;

public class startHome : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
