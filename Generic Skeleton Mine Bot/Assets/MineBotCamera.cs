using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBotCamera : MonoBehaviour {
    public float distanceAway;
    public float distanceUp;
    public float smooth;

    private Transform follow;
    private Vector3 targetPosition;
    
	// Use this for initialization
	void Start () {
        follow = GameObject.FindWithTag("Player").transform;	
	}
	
	// Update is called once per frame
	void Update () {
        targetPosition = follow.position + Vector3.up * distanceUp + follow.up * distanceAway;

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);

        transform.LookAt(follow);
	}
}
