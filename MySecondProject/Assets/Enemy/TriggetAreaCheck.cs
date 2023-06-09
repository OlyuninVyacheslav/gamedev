using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggetAreaCheck : MonoBehaviour
{
    private Enemy_behaviour enemyParent;

    private void Awake()
    {
        enemyParent = GetComponentInParent<Enemy_behaviour>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
    
            enemyParent.target = collider.transform;
            enemyParent.inRange = true;
            enemyParent.hotZone.SetActive(true);
        }
    }
}
