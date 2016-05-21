using UnityEngine;
using System.Collections;

public class ship : MonoBehaviour {
    public Camera cam;
	// Use this for initialization
	void Start () {
        cam = Camera.main;
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawLine(transform.position, cam.ScreenToWorldPoint(Input.mousePosition), Color.green);
        Vector3 lookAt = cam.ScreenToWorldPoint(Input.mousePosition);
        
        //lookAt.z = 0;
        lookAt = lookAt - transform.position;
        Debug.Log("screen2world" + lookAt.x + "_" + lookAt.y + "_" + lookAt.z);
        Quaternion q = Quaternion.LookRotation(lookAt,new Vector3(0,0,1));
        transform.rotation = q;
	
	}
}
