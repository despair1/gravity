using UnityEngine;
using System.Collections;

public class back_run : MonoBehaviour {
    Vector2 text_offset;
    public Rigidbody2D rb;
    public float c_vel=1;// constant to convert rigidbody to background velocity
    private Material m;

	// Use this for initialization
	void Start () {
        m = GetComponent<Renderer>().material;
        text_offset = m.mainTextureOffset;
	}
	
	// Update is called once per frame
	void Update () {
        text_offset.x += Time.deltaTime * rb.velocity.x * c_vel;
        text_offset.x = Mathf.Repeat(text_offset.x, 1);
        text_offset.y += Time.deltaTime * rb.velocity.y * c_vel;
        text_offset.y = Mathf.Repeat(text_offset.y, 1);
        m.SetTextureOffset("_MainTex", text_offset);
        transform.position = rb.position;

    }
}
