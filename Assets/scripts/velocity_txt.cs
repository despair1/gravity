using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class velocity_txt : dest_txt_cont
{
    private float speed = 0;
    private Rigidbody2D  player_rb;

    protected override void Awake()
    {
        base.Awake();
        player_rb = dest_img.player.GetComponent<Rigidbody2D>();
    }

    protected override void set_range()
    {
        txt.text = "speed\n" + ((int)(speed)).ToString() +
            "\n"+(int)player_rb.velocity.magnitude+"\n";
    }
}
