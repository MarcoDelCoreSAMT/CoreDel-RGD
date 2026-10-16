using UnityEngine;

public class spinButton : MonoBehaviour
{
    [SerializeField] private SpinRullo[] rulli;   // lista dei rulli
    [SerializeField] private float cooldown = 3f;

    private float lastSpinTime = -999f;

    private void OnMouseDown()
    {
        if (Time.time - lastSpinTime < cooldown) return;

        foreach (var r in rulli)
            if (r.IsSpinning) return;

        lastSpinTime = Time.time;
        foreach (var r in rulli)
            r.StartSpin();
    }
}
