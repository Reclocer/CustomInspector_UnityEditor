using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(Soldier))]
public class SoldierEditor : Editor
{
    private Soldier Target;
    public void OnEnable()
    {
        Target = (Soldier)base.target;
    }

    public override void OnInspectorGUI()
    {
        Target.Name = EditorGUILayout.TextField("Имя", Target.Name);
        Target.Health = EditorGUILayout.IntSlider("Здоровье", Target.Health, 0, 100);
    }
}
