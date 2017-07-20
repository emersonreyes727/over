using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour {
	[SerializeField] private Transform target;

	private NavMeshAgent nav;
	private float speed = 2f;
	private bool targetReached = false;

	// Use this for initialization
	void Start () {
		nav = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!targetReached) {
			nav.SetDestination (target.position);

			if (transform.position.x == target.position.x) {
				nav.enabled = false;
				targetReached = true;	
			}
		} else {
			if (transform.position.y >= 10f) {
				transform.Translate (Vector3.right * (speed * Time.deltaTime));
			} else {
				transform.Translate (Vector3.up * (speed * Time.deltaTime));
			}
		}
	}
}
