using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
