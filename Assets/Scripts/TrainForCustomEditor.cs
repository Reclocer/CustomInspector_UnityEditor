using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainForCustomEditor : MonoBehaviour
{
    public List<Carriage1> CarriageList;    
}

[System.Serializable]
public class Carriage1
{
    public int ID { get; set;}

    [System.Serializable]
    public class Box 
    {
        public string ID { get; set; }
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

    public Box Box1 = new Box();    
    public Box Box2 = new Box();
}
