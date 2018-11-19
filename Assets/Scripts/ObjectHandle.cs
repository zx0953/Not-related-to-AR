using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 vec3 = this.transform.eulerAngles;
        vec3.y += 20 * Time.deltaTime;
        vec3.y %= 360;
     /*   vec3.x += 20 * Time.deltaTime;
        vec3.x %= 90;
        vec3.z += 20 * Time.deltaTime;
        vec3.z %= 360; */
        this.transform.eulerAngles = vec3;
	}
}
