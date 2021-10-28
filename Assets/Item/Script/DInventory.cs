using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DInventory : MonoBehaviour
{
    public GameObject iventoryObject;
    public ItemSlot[] slots;

    public void AddItem(Item item, Item startItem = null)
    {
        foreach(ItemSlot i in slots)
        {
            if(!i.isFull)
            {
                
            }
        }
    }
}
