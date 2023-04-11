using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private void Start()
    {
        gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform);
    }
    void kill()
    {
        Destroy(gameObject);
    }
}
