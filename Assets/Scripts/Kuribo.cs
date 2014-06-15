using UnityEngine;
using System.Collections;

public class Kuribo : MonoBehaviour {

	private Transform target;
	private Vector3 vec;
	private float speed = 0.07f;
	
	private void Start()
	{
		target = GameObject.Find("Mario").transform;
	}
	
	private void Update()
	{

		if(target != null) {
			float dis = this.transform.localPosition.x - target.localPosition.x;
			if(dis < 5f) {
				if(this.transform.localPosition.x - target.localPosition.x > 0) {
					transform.Translate(-Vector3.right * speed); // Vector3.right = Vector3(1, 0, 0)
				}
				else {
					transform.Translate(Vector3.right * speed); // Vector3.right = Vector3(1, 0, 0)
				}
			}
		}
	}


}
