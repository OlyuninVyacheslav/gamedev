using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject buttons;
    public GameObject sett;
    float timer_anim;
    private void Update()
    {
        
    }
    public  void Quit()
    {
        Application.Quit();
    }
    public void StartGame()
    {

        buttons.GetComponent<Animator>().Play("Out menu");
        Invoke("loadsc",0.55f);
    }
    void loadsc()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ShowSettings()
    {
        buttons.GetComponent<Animator>().Play("Out menu");
        Invoke("settr", 0.55f);
    }
    void settr() 
    {
        sett.SetActive(true);
    }

    public  void OutSettings()
    {

        sett.SetActive(false);
    buttons.GetComponent<Animator>().Play("In menu");
    }
}
