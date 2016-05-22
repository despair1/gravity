using UnityEngine;
using System.Collections;

public class ship : MonoBehaviour {
    public Camera cam;
    float speed = 100;
	// Use this for initialization
	void Start () {
        cam = Camera.main;
        Quaternion q = Quaternion.LookRotation(new Vector3(0,1,0), new Vector3(0, 0, 1));
        //transform.rotation = q;
        Vector3 lookAt = transform.forward;
        Debug.Log("forward " + lookAt.x + "_" + lookAt.y + "_" + lookAt.z);
        lookAt = transform.right;
        Debug.Log("forward " + lookAt.x + "_" + lookAt.y + "_" + lookAt.z);

    }

    // Update is called once per frame
    void Update () {
        Debug.DrawLine(transform.position, cam.ScreenToWorldPoint(Input.mousePosition), Color.green);
        Debug.DrawLine(transform.position, transform.right*10, Color.blue);
        Vector3 lookAt = cam.ScreenToWorldPoint(Input.mousePosition);
        
        
        lookAt = lookAt - transform.position;
        lookAt.z = 0;
        Quaternion q=Quaternion.FromToRotation(Vector3.up,lookAt.normalized);
        //q.SetFromToRotation(transform.up, lookAt);
        //Quaternion q = Quaternion.LookRotation(lookAt,new Vector3(0,0,1));
        //transform.rotation = q;
        lookAt = transform.forward;
        lookAt = transform.up;
        Debug.Log("screen2world" + lookAt.x + "_" + lookAt.y + "_" + lookAt.z);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, speed * Time.deltaTime);

    }
}
