using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInventory : MonoBehaviour
{
    public ItemSlot[,] slots;
    public Item item;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A))
        {
            GetItem(item);
        }
    }
    void GetItem(Item item)
    {
        slots[0, 0].itemInSlot = item;
        slots[0, 0].ItemCount = 10;
        slots[0, 0].isFull = true;
        slots[0, 0].RefreshInfo();
    }
}
