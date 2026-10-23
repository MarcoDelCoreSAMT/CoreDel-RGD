using UnityEngine;

public class iconSpinRotate : MonoBehaviour
{
    private Vector3 direction = new Vector3(0, 0, 50f);
    private float speed = -5;
    private Vector3 movement;

    void Update()
    {
        movement = direction * Time.deltaTime * speed;
        transform.Rotate(movement);
    }
}
