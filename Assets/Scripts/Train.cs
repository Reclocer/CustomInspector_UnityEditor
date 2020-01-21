using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    
    [SerializeField] private Carriage[] _carriages;

    [SerializeField] private int _amountOfLettersInTrain = 0;
    public int AmountOfLettersInTrain => _amountOfLettersInTrain;

    [ContextMenu("CountAmountOfLettersInTrain")]
    public void CountAmountOfLettersInTrain()
    {
        _amountOfLettersInTrain = 0;

        foreach(Carriage carriage in _carriages)
        {
            _amountOfLettersInTrain += carriage.CountAmountOfLettersInCarriage();
        }
    }
}
