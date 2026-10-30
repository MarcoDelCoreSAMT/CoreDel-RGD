using UnityEngine;
using UnityEngine.SceneManagement;

public class startSettings : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Settings");
    }
}
