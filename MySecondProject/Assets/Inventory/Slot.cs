using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public GameObject text;
    public int cnt = 0;
    public Item item;
    public GameObject prefpredmeta;
    public bool isFull;
    public bool isSelected = false;
    public Image itemin;
    public GameObject whatDrop;
    public WinDiscr descrwin;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        isFull = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cnt == 0)
        {
            text.SetActive(false);
        }
        else
        {
            text.SetActive(true);
        }
        //x text.transform.GetComponent<TextMeshPro>().text = cnt.ToString();
    }
    
     public void Add (GameObject it)
    {
        
        item = it.GetComponent<Item>();
        itemin.gameObject.SetActive(true);

       // prefpredmeta = item.pref;
        itemin.sprite = item.img;
        text.SetActive(true);
        isFull = true;
    }
   public void Remove()
    {
        
       
        itemin.gameObject.SetActive(false);
        whatDrop.GetComponent<Item>().cost = item.cost;
        whatDrop.GetComponent<Item>().id = item.id;
        whatDrop.GetComponent<Item>().img = item.img;
        whatDrop.GetComponent<Item>().block = false;
        whatDrop.GetComponent<Item>().desc = item.desc;
        whatDrop.GetComponent<Item>().action = item.action;
        whatDrop.GetComponent<Item>().nazv = item.nazv;
        isFull = false;
        itemin.sprite = null;
        Instantiate(whatDrop, GameObject.FindGameObjectWithTag("Player").transform.position + new Vector3(GameObject.FindGameObjectWithTag("Player").GetComponent<HeroKnight>().m_facingDirection * 1.5f, 0.32f, 0), transform.rotation);
        //Instantiate(prefpredmeta, GameObject.FindGameObjectWithTag("Player").transform.position + new Vector3(GameObject.FindGameObjectWithTag("Player").GetComponent<HeroKnight>().m_facingDirection * 1.5f, 0.32f, 0), transform.rotation);

        if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventorySys>().Invfull)
        {
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventorySys>().Invfull = false;
        }
        item = null;
        descrwin.gameObject.SetActive(false);
    }
    public void Use()
    {
        item.use();
        itemin.gameObject.SetActive(false);
        isFull = false;
        itemin.sprite = null;
        if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventorySys>().Invfull)
        {
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<InventorySys>().Invfull = false;
        }
        item = null;
        descrwin.gameObject.SetActive(false);
    }
    public void ShowDescription()
    {
        GetComponentInParent<InventorySys>().selected = this;
        descrwin.gameObject.SetActive(true);
        isSelected= true;
        descrwin.icon.sprite = itemin.sprite;
        descrwin.desc.text = ("Название: \n"+ item.nazv + "\nСтоимость: "+ item.cost.ToString() + " \nОписание: \n"+  item.desc);
    }
}   
