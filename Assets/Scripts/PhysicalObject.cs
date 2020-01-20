using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicalObject : MonoBehaviour
{
    [Header("Object parameters")]
    [SerializeField] private Color _ojectColor = Color.blue;
    public Color ObjectColor => _ojectColor;

    [SerializeField] private float _objectMass = 4.5f;
    public float ObjectMass => _objectMass;

    [HideInInspector] public const float AtmospherePressure = 0;

    [Space(20)]
    [SerializeField][Range(0, 360)] private float _rotateSpeed = 20;
    [SerializeField] private float _moveSpeed = 3;

    private Rigidbody _rigidbody;

    [SerializeField] [TextArea(2, 5)] private string Specification = "Sphere";


    void Start()
    {
        StartInitialization();
        _rigidbody.velocity = new Vector3(_moveSpeed, 0, 0);
        _rigidbody.rotation = Quaternion.Euler(_rotateSpeed, 0, 0);
    }

    private void FixedUpdate()
    {
        //_rigidbody.velocity = new Vector3(_moveSpeed, 0, 0);
        //_rigidbody.rotation = Quaternion.Euler(_rotateSpeed, 0, 0);
    }

    private void StartInitialization()
    {
        GetComponent<MeshRenderer>().material.color = _ojectColor;
        _rigidbody = GetComponent<Rigidbody>();        
        _rigidbody.mass = _objectMass;
    }
}
