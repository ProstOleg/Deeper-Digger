using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamiteDamage : MonoBehaviour
{
    public int DamageValue;

    private AudioSource source;
    private AudioClip audioClip;
    private int blockLayerNum = 8;
    private Block block;
    private float timeToExplose = 1f;
    private bool isExplose = false;

    void OnEnable()
    {
        source = GetComponent<AudioSource>();
        audioClip = source.clip;
        //starttimer
        StartCoroutine("Explose");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isExplose)
        {
            if (collision.gameObject.layer == blockLayerNum)
            {
                // Explosion        
                collision.gameObject.TryGetComponent<Block>(out block);
                block.Damage(DamageValue);
                source.PlayOneShot(audioClip);
            }
            StartCoroutine("Dest");
        }
    }

    private IEnumerator Dest()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(this.gameObject);
        yield return null;
    }

    private IEnumerator Explose()
    {
        yield return new WaitForSeconds(timeToExplose);
        isExplose = true;
        yield return null;
    }
}
