using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dest_txt_cont : MonoBehaviour {
    protected Text txt;
    protected dest_gui_cont dest_img;
    
	// Use this for initialization
	virtual protected void Awake () {
        dest_img = GameObject.Find("dest_img").GetComponent<dest_gui_cont>();
        txt = gameObject.GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
        set_range();
	
	}

    protected virtual void set_range()
    {
        txt.text = "Destinatio1n\n" + ((int)(dest_img.dest.transform.position -
            dest_img.player.transform.position).magnitude).ToString();
    }
}
