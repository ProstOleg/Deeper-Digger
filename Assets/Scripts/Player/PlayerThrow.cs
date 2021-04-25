using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    [SerializeField] private GameObject prefabDynamite;
    
    private Vector3 offset;
    private Vector2 force;
    private Rigidbody2D rig;
    private PlayerController playerController;
    private bool canThrow = true;
    private float delayTime = 1f;


    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire2") && canThrow)
        {
            if (playerController.PlayerDirection == PlayerController.Direction.left)
            {
                offset = new Vector3(-0.16f, 0f, 0f);
                force = new Vector2(-30f, 15f);
            }
            else if (playerController.PlayerDirection == PlayerController.Direction.right)
            {
                offset = new Vector3(0.16f, 0f, 0f);
                force = new Vector2(30f, 15f);
            }

            Vector3 newpos = this.transform.position + offset;
            GameObject go = Instantiate(prefabDynamite, newpos, Quaternion.identity, this.transform);
            
            go.TryGetComponent<Rigidbody2D>(out rig);
            rig.AddForce(force);
            canThrow = false;
            StartCoroutine("delyayThrow");
        }
    }

    private IEnumerator delyayThrow()
    {
        yield return new WaitForSeconds(delayTime);
        canThrow = true;
        yield break;
    }
}
