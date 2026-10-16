using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introLightMove : MonoBehaviour
{
    
    private float speed = 0.35f;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed);

        if (transform.position.x > 12f)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
