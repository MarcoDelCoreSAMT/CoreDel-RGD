using System;
using UnityEngine;

public class SpinRullo : MonoBehaviour
{
    public float velocitaRotazione = 50f;

    void Update()
    {
        // Gira l'oggetto attorno all'asse Y locale
        transform.Rotate(Vector3.up * velocitaRotazione * Time.deltaTime);
    }
}
