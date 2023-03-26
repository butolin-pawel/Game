using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public GameObject text;
    public int cnt = 0;
    public Item item;
    public bool isFull;
    //public Sprite itemin;
    public Image itemin;
    public GameObject whatDrop;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        isFull = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(cnt == 0)
        {
            text.SetActive(false);
        }
        else
        {
            text.SetActive(true);
        }
      //x text.transform.GetComponent<TextMeshPro>().text = cnt.ToString();
    }
    
     public void Add (Item it)
    {
        item = it;
        itemin.gameObject.SetActive(true);
       itemin.sprite = item.img;
        text.SetActive(true);
        isFull = true;
    }
    public void Remove()
    {
        itemin.gameObject.SetActive(false);
        isFull = false;
        itemin.sprite = null;
        whatDrop.GetComponent<Item>().cost = item.cost;
        whatDrop.GetComponent<Item>().id = item.id;
        whatDrop.GetComponent<Item>().img = item.img;
        Instantiate(whatDrop, GameObject.FindGameObjectWithTag("Player").transform.position + new Vector3(3, 1, 0), transform.rotation);
        if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventorySys>().Invfull)
        {
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventorySys>().Invfull = false;
        }
        item = null;
    }
}   
