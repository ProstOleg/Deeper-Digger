using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public abstract class Block : MonoBehaviour
{
    public int maxHealth;

    [Header("smallCracked")]
    public int smallCrackedValue;
    public Sprite smallCrackedSprite;
    [Header("halfCracked")]
    public int halfCrackedValue;
    public Sprite halfCrackedSprite;
    [Header("fullCracked")]
    public int fullCrackedValue;
    public Sprite fullCrackedSprite;

    protected int currentHealth;
    protected const int DEAD_HEALTH = 0;
    protected SpriteRenderer blockSpriteRenderer;
    protected Sprite blockSprite;

    protected void Awake()
    {
        currentHealth = maxHealth;
        blockSpriteRenderer = GetComponent<SpriteRenderer>();
        blockSprite = blockSpriteRenderer.sprite;
    }

    //currentHeath
    public abstract void Damage(int count);

    public abstract void Heal(int count);

    // maxHealth
    public abstract void Upgrade(int count);
    public abstract void Downgrade(int count);
}
