using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Instantiates prefabs to fill a grid
[RequireComponent(typeof(GridLayout))]
public class ItemSlotGridDimensioner : MonoBehaviour
{
    public bool isBag = true;
    public int boxNum;
    [SerializeField]
    GameObject itemSlotPrefab;
    public Inventory inv = null;
    public BoxInventory bInv = null;
    ItemSlot[,,] slots;
    [SerializeField]
    Vector2Int GridDimensions = new Vector2Int(6, 6);

    void Start()
    {
        int numCells = GridDimensions.x * GridDimensions.y;
        
        while (transform.childCount < numCells)
        {
            GameObject newObject = Instantiate(itemSlotPrefab, this.transform);
            newObject.gameObject.name = name = transform.childCount.ToString();


        }
        if(isBag)
        {
            int a = 0;
            inv.slots = new ItemSlot[GridDimensions.x, GridDimensions.y];
            
            foreach (Transform child in transform)
            {
                if (child.GetComponent<ItemSlot>())
                {
                    inv.slots[(a / GridDimensions.y), a % 5] = child.GetComponent<ItemSlot>();                    
                    //Debug.Log(child.name);
                }               
                ++a;
            }
        }
        else
        {
            int a = 0;
            bInv.slots = new ItemSlot[GridDimensions.x, GridDimensions.y];
            
            foreach (Transform child in transform)
            {
                if (child.GetComponent<ItemSlot>())
                {
                    bInv.slots[(a / GridDimensions.y), a % 5] = child.GetComponent<ItemSlot>();
                    //Debug.Log(child.name);
                }
                ++a;
            }
        }
    }
}
