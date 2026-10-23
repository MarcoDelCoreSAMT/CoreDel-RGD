using UnityEngine;

public class muteUnmute : MonoBehaviour
{
    public Sprite unmuted;
    public Sprite muted;

    private SpriteRenderer spriteRenderer;
    private bool isMuted = false;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        isMuted = !isMuted;

        if (isMuted)
        {
            spriteRenderer.sprite = muted;
            Debug.Log("Muto");
        }
        else
        {
            spriteRenderer.sprite = unmuted;
            Debug.Log("Volume attivo");
        }
    }
}
