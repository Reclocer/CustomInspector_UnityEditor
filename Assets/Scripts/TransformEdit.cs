using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TransformEdit : MonoBehaviour
{
    [SerializeField] private Transform _target;
        
    void Update()
    {
        if(_target)
        {
            transform.LookAt(_target);
        }
    }
}
