using UnityEngine;

public class SpinRullo : MonoBehaviour
{
    public float velocitaRotazione = 200;

    void Update()
    {
        // Fa girare il quadrato sullo schermo (asse Y)
        transform.Rotate(Vector3.up * velocitaRotazione * Time.deltaTime);
    }
}