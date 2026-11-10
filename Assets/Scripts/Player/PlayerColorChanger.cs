using UnityEngine;

public class PlayerColorChanger : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += TargetDestroyedHandler;
    }

    void TargetDestroyedHandler(GameItem gameItem)
    {
        if (gameItem == GameItem.Gem && spriteRenderer != null)
        {
            spriteRenderer.color = Color.red;
        }
        else if (gameItem == GameItem.Key && spriteRenderer != null)
        {
            spriteRenderer.color = Color.blue;
        }
    }
}
