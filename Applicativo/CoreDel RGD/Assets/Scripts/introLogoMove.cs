using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introLogoMove : MonoBehaviour
{
    private float speed = 0.05f;
    private bool logoMoving = false;

    public void spostaLogo()
    {
        logoMoving = true;
    }

    public void toMainMenu() 
    {
        transform.position = new Vector3(transform.position.x, 6.87f, transform.position.z);
        Debug.Log("Logo fermo, carico la scena MainMenu");
        SceneManager.LoadScene("MainMenu");
    }

    void Update()
    {
        if (logoMoving)
        {
            transform.position += Vector3.up * speed;

            if (transform.position.y >= 6.87f)
            {
                logoMoving = false;
                toMainMenu();
            }
        } 
    }

}

