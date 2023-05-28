using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;



public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;

    public float PlayerSpeed = 2f;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    
}
