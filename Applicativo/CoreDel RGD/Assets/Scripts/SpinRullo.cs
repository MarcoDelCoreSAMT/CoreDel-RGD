using UnityEngine;

public class SpinRullo : MonoBehaviour
{
    [SerializeField] public Vector3 direzione = new Vector3(0, 5.5f, 0);
    [SerializeField] public float speed = 22f;
    public float durata = 2f;

    public bool IsSpinning { get; private set; }
    private float timer;

    public void StartSpin()
    {
        timer = durata;
        IsSpinning = true;
    }

    private void Update()
    {
        if (!IsSpinning) return;

        transform.Rotate(direzione * Time.deltaTime * speed, Space.Self);

        timer -= Time.deltaTime;
        if (timer <= 0f) IsSpinning = false;
    }
}