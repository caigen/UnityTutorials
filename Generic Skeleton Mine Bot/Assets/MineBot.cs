using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBot : MonoBehaviour {

    private Animator animator;
    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (animator)
        {
            bool j = Input.GetButton("Fire1");
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            animator.SetFloat("Speed", h * h + v * v);
            animator.SetFloat("Direction", Mathf.Atan2(h, v) * 180.0f / Mathf.PI);
            animator.SetBool("Jump", j);

            if (rigidbody)
            {
                Vector3 speed = rigidbody.velocity;
                speed.x = 4 * h;
                speed.z = 4 * v;
                rigidbody.velocity = speed;
                if (j)
                {
                    rigidbody.AddForce(Vector3.up * 20);
                }
            }
        }		
	}
}
