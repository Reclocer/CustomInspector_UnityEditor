﻿using UnityEngine;

[System.Serializable]
public class Carriage
{
    [SerializeField] private Box[] _boxes;
    public Box[] Boxes => _boxes;

    public int CountAmountOfLettersInCarriage()
    {
        int amountOfLetters = 0;
        if (_boxes.Length > 0)
        {
            foreach (Box box in _boxes)
            {
                amountOfLetters += box.AmountOfLetters;
            }
        }
        return amountOfLetters;
    }
}
