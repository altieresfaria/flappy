﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float forcaDoPulo = 10f;
    private  Animator anim;
    private Rigidbody rb;
    private bool pulando = false;

	void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        if (Input.GetMouseButton(0))
        {
            anim.Play("pulando");
            rb.useGravity = true;
            pulando = true;
        }
		
	}

    void FixedUpdate()
    {
        if (pulando) {
            pulando = false;
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector3.up * forcaDoPulo, ForceMode.Impulse);
        }

    }

}
