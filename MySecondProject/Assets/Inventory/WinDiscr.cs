using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinDiscr : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI desc;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void close()
    {
        icon.sprite = null;
        desc.text = "";
        gameObject.SetActive(false);
    }
}
