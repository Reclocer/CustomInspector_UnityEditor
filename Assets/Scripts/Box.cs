﻿using UnityEngine;

[System.Serializable]
public class Box 
{
    [SerializeField] private int _amountOfLetters = 500;
    public int AmountOfLetters
    {
        get
        {
            return _amountOfLetters;
        }
        set
        {
            _amountOfLetters = value;
        }
    }


}
