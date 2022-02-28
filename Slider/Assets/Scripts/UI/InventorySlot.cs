using UnityEngine.UI;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public Image icon;

    Collectible collectible;
    
    public void AddCollectible(Collectible newCollectible) {
        collectible = newCollectible;
        icon.sprite = collectible.icon;
        icon.enabled = true;
    }

    public void ClearSlot() {
        collectible = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}
