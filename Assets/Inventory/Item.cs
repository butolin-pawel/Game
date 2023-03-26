using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int id;
    public float cost;
    public Sprite img;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = img;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
