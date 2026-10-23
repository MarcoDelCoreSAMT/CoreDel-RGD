using UnityEngine;

public class introLightMove : MonoBehaviour
{
    public introLogoMove logoMove;
    private float speed = 0.35f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed;

        if (transform.position.x >= 9f)
        {
            Debug.Log("La luce ha raggiunto X >= 9! Attivo il logo.");
            if (logoMove != null)
            {
                logoMove.spostaLogo();
            }
            else
            {
                Debug.LogError("Errore: script non funzionante");
            }
            enabled = false; // Disabilita questo script dopo aver spostato il logo
        }
    }
}
