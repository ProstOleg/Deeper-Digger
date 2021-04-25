using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    private int LayerDefault = 0;
    private int LayerBlock = 8;
    
    private Rigidbody2D rig;

    private void Awake()
    {
         rig = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerBlock || collision.gameObject.layer == LayerDefault)
        {
            rig.gravityScale = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerBlock || collision.gameObject.layer == LayerDefault)
        {
            rig.gravityScale = 1;
        }
    }
}
