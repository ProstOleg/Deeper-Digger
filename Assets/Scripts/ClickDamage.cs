using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDamage : MonoBehaviour
{
    public int Damage;
    public Texture2D PickAxeCursor;

    private CursorMode cursorMode = CursorMode.Auto;
    private Block block;

    private void Awake()
    {
        block = GetComponent<Block>();
    }

    private void OnMouseDown()
    {
        block.Damage(Damage);
    }

    private void OnMouseEnter()
    {
        Cursor.SetCursor(PickAxeCursor, Vector2.zero, cursorMode);
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
