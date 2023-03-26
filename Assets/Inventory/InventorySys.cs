using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySys : MonoBehaviour
{
    public List<Slot> slots = new List<Slot>();
    public bool Invfull = false;
    
    // Start is called before the first frame update
    void Start()
    {
       for(int  i = 0; i < transform.childCount; i++)
        {
            slots.Add(transform.GetChild(i).GetComponent<Slot>());
        }
       gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void show()
    {
        if (gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
    public void pickup(Item item)
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (!slots[i].isFull)
            {
                if(i == slots.Count - 1)
                {
                    Invfull = true;
                }
                slots[i].Add(item);
                break;
            }

        }
    }
}
