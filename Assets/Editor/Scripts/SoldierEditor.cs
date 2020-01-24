using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(Soldier))]
public class SoldierEditor : Editor
{
    private Soldier _target;

    public void OnEnable()
    {
        _target = (Soldier)base.target;
    }

    public override void OnInspectorGUI()
    {
        _target.Name = EditorGUILayout.TextField("Имя", _target.Name);
        _target.Health = EditorGUILayout.IntSlider("Здоровье", _target.Health, 0, 100);
    }
}
