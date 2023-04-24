using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool isPause = false;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPause)
            {
                isPause = !isPause;
                pauseMenu.SetActive(true);
            }
            else
            {
                isPause = !isPause;
                pauseMenu.SetActive(false);
            }
         }
      
    }
}
