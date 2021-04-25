using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats:MonoBehaviour
{

    private int _currentScore;

    public int Score 
    {
        get => _currentScore;
        set 
        { 
            _currentScore = value; 
        }
    }

}
