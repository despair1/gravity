using UnityEngine;
using System.Collections;

public class dest_gui_cont : MonoBehaviour {
    public GameObject dest;
    public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion q = Quaternion.FromToRotation(Vector3.up, dest.transform.position-player.transform.position);
        transform.rotation = q;
	
	}
}
