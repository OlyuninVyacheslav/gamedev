using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Novel_sys : MonoBehaviour
{
    public GameObject textB;
    public TextMeshProUGUI who;
    public TextMeshProUGUI speech;
    public Image Edric;
    public Image other_Person;
    public Image BG;
    public Act_con[] scenes;
    private List<string> cur_speech;
    private Act_con cur;
    private static int act = 0;
    private static int frase;
    void Start()
    {
        if(act == scenes.Length) { act = 0; }
        cur = scenes[act];
        act++;
        other_Person.sprite = cur.other;
        BG.sprite = cur.BG;
        cur_speech = cur.frases;
        who.text = cur_speech[0].Split(':')[0];
        speech.text = cur_speech[0].Split(':')[1];
        frase = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) )
        {
            if (frase != cur_speech.Count)
            {
                who.text = cur_speech[frase].Split(':')[0];
                speech.text = cur_speech[frase].Split(':')[1];
                frase++;
            }
            else
            {
                SceneManager.LoadScene(cur.name_next_scene);
            }
        }
    }
}
