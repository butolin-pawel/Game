using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InvUse4 : MonoBehaviour
{
    public InventorySys bag;
    public Item hil;
    private bool isPick = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Inventory Open
        if (Input.GetKeyDown("e"))
        {
            bag.show();

            GetComponent<HeroKnight>().isOpenINV = GetComponent<HeroKnight>().isOpenINV?false:true;

        }
        if (Input.GetKeyDown("l"))
        {
            Instantiate(hil,transform.position + new Vector3 (3,1,0),transform.rotation);
        }

    }
   

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("PickableIt") && !isPick)
            {
                isPick = true;
                if (!(bag.Invfull))
                {
                Destroy(collision.gameObject);
                bag.pickup(collision.gameObject.GetComponent<Item>());
                isPick= false;
                }
                else
                {
                    //ToDo: Instantiate текст с уведой что инв фулл видос maxsters topdownshoter #2
                }
            }
        }
    
}
