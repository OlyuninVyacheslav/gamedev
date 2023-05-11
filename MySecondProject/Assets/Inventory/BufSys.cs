using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BufSys : MonoBehaviour
{
    private HeroKnight HK;
    private Queue<float> buffsout= new Queue<float>();

    // Start is called before the first frame update
    void Start()
    {
        HK = gameObject.GetComponent<HeroKnight>();
    }

    // Update is called once per frame
    void Update()
    {
        //щрн дкъ реярнб мнбекэмшу дхюкнцнб бшпефхре щрн онрнл й вепръл
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            SceneManager.LoadScene("Novel_dialog");
        }

     
    }
    public void act(buff wh, float value,float duration)
    {
      switch(wh)
        {
            case buff.speed:
                upspd(value,duration);
                break;

        }
    }
    void upspd(float value,float duration)
    {
        buffsout.Enqueue(value);
        HK.m_speed += value;
        Invoke("downspd", duration);
    }
    void downspd()
    {
        HK.m_speed -= buffsout.Peek();
        buffsout.Dequeue();
        
    }
}
