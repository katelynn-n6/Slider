using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public Transform itemsParent;

    PlayerInventory inventory;

    InventorySlot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        inventory = PlayerInventory.instance;

        slots = itemsParent.GetComponentInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void UpdateUI() {
        Debug.Log("Updating");
        for (int i = 0; i < slots.length; i++) {
            if (i < inventory.collectibles.Count) {
                slots[i].AddCollectible(inventory.collectibles[i]);
            } else {
                slots[i].ClearSlot();
            }
        }
    }
}
