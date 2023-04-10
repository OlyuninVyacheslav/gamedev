using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int id;
    public GameObject pref;
    public string nazv;
    public string desc;
    public float cost;
    public Sprite img;
    public bool block = false;
    public IAction action;
    public bool coss;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = img;
        if(coss)
        {
            action = GetComponent<IAction>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void use()
    {
        action.use();
    }
}
