using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Display item in the slot, update image, make clickable when there is an item, invisible when there is not
public class ItemSlot : MonoBehaviour
{
    public Item itemInSlot = null;
    public bool isFull = false;
    [SerializeField]
    private int itemCount = 0;

    public int ItemCount
    {
        get
        {
            return itemCount;
        }
        set
        {
            itemCount = value;
        }
    }
    [SerializeField]
    private Image icon;
    [SerializeField]
    private TMPro.TextMeshProUGUI itemCountText;

    void Start()
    {
        icon = GetComponent<Image>();
        RefreshInfo();
        
    }
    private void Update()
    {
        
    }
    public void RefreshInfo()
    {
        if(ItemCount < 1)
        {
            itemInSlot = null;
        }
        if (icon != null)
        {
            if (itemInSlot != null) // If an item is present
            {
                //update image and text
                itemCountText.text = ItemCount.ToString();
                icon.sprite = itemInSlot.icon;                
            }
            else
            {
                // No item
                itemCountText.text = "";                
            }
        }
    }
    public void Toggled()
    {
        Debug.Log(gameObject.name);
    }

    public void CheckItem()
    {
        if(transform.childCount > 1)
        {
            Item i = transform.GetChild(1).GetComponent<Item>();
            isFull = true;
            GetComponent<Image>().sprite = i.icon;
        }
        else
        {
            GetComponent<Image>().sprite = icon.sprite;
            itemCountText.text = "";
        }
    }
}
