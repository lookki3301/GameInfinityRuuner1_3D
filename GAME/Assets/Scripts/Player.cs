using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private CharacterController _characterController;
    [SerializeField] private Animator _animator;

    [SerializeField] private GameObject _playbutt;
    [SerializeField] private GameObject _exitbutt;
    [SerializeField] private GameObject _dark;


    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Barrier>()._isDead)
        {
            _animator.SetTrigger("IsDEAD");
            _playbutt.SetActive(true);
            _exitbutt.SetActive(true);
            _dark.SetActive(true);

        }
        else
        {
            _characterController.Move(Vector3.right * _speed * Input.GetAxis("Horizontal") * Time.deltaTime);
        }
        
        
    }
}
