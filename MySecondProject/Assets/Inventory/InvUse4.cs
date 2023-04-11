using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InvUse4 : MonoBehaviour
{
    public InventorySys bag;
    public Item hil;
    public GameObject mes;
    public float whenst;
    private Animator anim;
    void Start()
    {
        whenst = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Inventory Open
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            bag.show();

            GetComponent<HeroKnight>().isOpenINV = GetComponent<HeroKnight>().isOpenINV?false:true;

        }
        if (Input.GetKeyDown("l"))
        {
            Instantiate(hil,transform.position + new Vector3 (2,0.3f,0),transform.rotation);
        }

    }
   

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("PickableIt") && ! collision.gameObject.GetComponent<Item>().block)
            {
            collision.gameObject.GetComponent<Item>().block = true;
                if (bag.pickup(collision.gameObject))
                {
                Destroy(collision.gameObject);
                }
                else
                {
                if (Time.time - whenst > 2)
                {
                    whenst = Time.time;
                    Instantiate(mes, collision.transform.position, transform.rotation);
                }

                collision.gameObject.GetComponent<Item>().block = false;
            }
            }
        }
    
}
