using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject _effect;
    
    private void OnTriggerEnter(Collider other)
    {

        FindObjectOfType<GameManager>().AddCoin();

        Destroy(gameObject);
        Instantiate(_effect, transform.position, Quaternion.identity);
    }
}
