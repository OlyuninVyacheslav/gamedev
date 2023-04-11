using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySys : MonoBehaviour
{
    public List<Slot> slots = new List<Slot>();
    public Slot selected;
    public bool Invfull = false;
    public WinDiscr descrwin;
    // Start is called before the first frame update
    void Start()
    {
       for(int  i = 0; i < transform.childCount; i++)
        {
            if(transform.GetChild(i).tag == "InvSlot")
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
            descrwin.close();
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
    public void buttonRemove()
    {
        selected.Remove();
    }
    public void buttonUse()
    {
        selected.Use();
    }
    public bool pickup(GameObject item)
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
                return true;
            }
        }
        return false;
    }
}
