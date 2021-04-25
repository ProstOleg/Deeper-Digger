using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Sprite rightSprite;
    public Sprite leftSprite;
    public float speed;

    public enum Direction { 
        right, left
    }

    private SpriteRenderer spr;
    private float _moveX;
    private float _moveY = 0;
    private Rigidbody2D _rb2D;
    private Vector2 moveInput;
    private Direction direction = Direction.right;
    public Direction PlayerDirection { get => direction; }

    private void Awake()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _moveX = Input.GetAxis("Horizontal");
        if (_moveX > 0 && direction == Direction.left)
        {
            spr.sprite = rightSprite;
            direction = Direction.right;
        }
        else if(_moveX < 0 && direction == Direction.right)
        {
            spr.sprite = leftSprite;
            direction = Direction.left;
        }

        moveInput = new Vector2(_moveX,_moveY);
        _rb2D.velocity = moveInput * (speed * Time.fixedDeltaTime);
    }

    

}
