using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//OnCollisionEnterは反応しにくくなる（反応しない訳ではない）　また「物体が動いている間だけ」呼び出しが発生する 
	void OnControllerColliderHit(ControllerColliderHit hit){
		if(hit.gameObject.tag == "DamageObject"){
			print("hit");
			if(this.transform.position.y > hit.point.y) {

				Destroy(hit.gameObject);
			}
			else {
				Destroy(this.gameObject);
			}

		}
		
	}
}
