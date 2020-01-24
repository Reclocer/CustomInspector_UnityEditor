using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{    
    [SerializeField] protected Carriage[] _carriages;
    public Carriage[] Carriages => _carriages;

    [SerializeField] protected int _amountOfLettersInTrain = 0;
    public int AmountOfLettersInTrain
    {
        get
        {
            return _amountOfLettersInTrain;
        }
        set
        {
            _amountOfLettersInTrain = value;
        }
    }

    [ContextMenu("CountAmountOfLettersInTrain")]
    public void CountAmountOfLettersInTrain()
    {
        _amountOfLettersInTrain = 0;

        if (_carriages.Length > 0)
        {
            foreach (Carriage carriage in _carriages)
            {
                _amountOfLettersInTrain += carriage.CountAmountOfLettersInCarriage();
            }
        }
    }
}
