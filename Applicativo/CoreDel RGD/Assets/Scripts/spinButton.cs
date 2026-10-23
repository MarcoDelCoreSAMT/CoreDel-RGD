using UnityEngine;

public class spinButton : MonoBehaviour
{
    public iconSpinRotate iconSpinRotate;

    [SerializeField] private SpinRullo[] rulli;   // lista dei rulli
    [SerializeField] private float cooldown = 3f;

    private float lastSpinTime = -999f;

    private void OnMouseDown()
    {
        iconSpinRotate = true;

        if (Time.time - lastSpinTime < cooldown) return;

        foreach (var r in rulli)
            if (r.IsSpinning) return;

        lastSpinTime = Time.time;
        foreach (var r in rulli)
            r.StartSpin();
    }
}
