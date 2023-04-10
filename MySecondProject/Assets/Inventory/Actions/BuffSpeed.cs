using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpeed : MonoBehaviour, IAction
{
    public float value;
    public float duration = 5f;
    public void use()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<BufSys>().act(buff.speed,value,duration);
    }
}
