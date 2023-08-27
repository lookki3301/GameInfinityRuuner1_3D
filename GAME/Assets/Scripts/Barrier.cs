using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public bool _isDead = false;
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<Barrier>()._isDead = true;
        
    }
}
