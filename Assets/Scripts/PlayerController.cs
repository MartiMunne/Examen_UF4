
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _cc;
    public float Speed;
    public Animator _animator;
    private bool canMove = true;
    public GameObject coinObject;
    Vector3 _move;

    void Start()
    {
        _cc = GetComponent<CharacterController>();
    }
    void Update()
    {
        if(canMove)
        {
            _move = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _cc.Move(_move * Time.deltaTime * Speed);
        }

        if(_move != new Vector3(0,0,0))
        {
            _animator.SetBool("Running", true);
        }
        else
        {
            _animator.SetBool("Running", false);
        }

    }
    private void OnTriggerEnter(Collider other) 
    {
        GameManager.gameManager.CoinCollected();
        Destroy(coinObject);
    }
}