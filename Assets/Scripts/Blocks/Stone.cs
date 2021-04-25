using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : Block
{
    // not use Awake

    private void CheckHealth()
    {
        if (currentHealth <= smallCrackedValue && currentHealth > halfCrackedValue)
        {
            blockSpriteRenderer.sprite = smallCrackedSprite;
            
        }
        else if (currentHealth <= halfCrackedValue && currentHealth > fullCrackedValue)
        {
            blockSpriteRenderer.sprite = halfCrackedSprite;
        }
        else if (currentHealth <= fullCrackedValue && currentHealth > DEAD_HEALTH)
        {
            blockSpriteRenderer.sprite = halfCrackedSprite;
        }
        else if(currentHealth <= DEAD_HEALTH)
        {
            Destroy(this.gameObject);
        }
    }


    public override void Damage(int count)
    {
        currentHealth -= count;
        CheckHealth();
    }

    #region not use
    public override void Downgrade(int count)
    {
        throw new System.NotImplementedException();
    }

    public override void Heal(int count)
    {
        throw new System.NotImplementedException();
    }

    public override void Upgrade(int count)
    {
        throw new System.NotImplementedException();
    }
    #endregion
}
