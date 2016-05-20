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
	
	}
}
