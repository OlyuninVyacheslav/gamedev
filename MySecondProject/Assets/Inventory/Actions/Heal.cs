using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour,IAction
{
    public float value;
     public void use()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().currentHealth += value;
    }
}
