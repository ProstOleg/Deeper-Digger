using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDrop : MonoBehaviour
{
    [Header("FirstDrop")]
    [SerializeField] private GameObject FirstDropGO;
    public int FirstDropChance;
    [Header("SecondDrop")]
    [SerializeField] private GameObject SecondDropGO;
    public int SecondDropChance;

    public void Roll()
    {
        int r = Random.Range(0, 100);
        if( r <= FirstDropChance)
        {
            // firstDrop
        }
        else if (r <= FirstDropChance)
        {
            // scondDrop
        }
    }
}
