using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TrainForCustomEditor))]
public class TrainEditor : Editor
{
    private TrainForCustomEditor _target;

    public void OnEnable()
    {
        _target = (TrainForCustomEditor)base.target;
    }

    public override void OnInspectorGUI()
    {
        //_target.AmountOfLettersInTrain = EditorGUILayout.IntField("Всего писем", _target.AmountOfLettersInTrain);
        List<Carriage1> carriageList = _target.CarriageList;
        
        if(carriageList.Count > 0)
        {
            foreach(Carriage1 carriage1 in carriageList)
            {
                Carriage1.Box box1 = carriage1.Box1;
                box1.ID = "1";
                Carriage1.Box box2 = carriage1.Box2;
                box2.ID = "2";                

                EditorGUILayout.BeginVertical("box", GUILayout.Height(40));
                carriage1.ID = EditorGUILayout.IntField("Номер вагона", carriage1.ID);

                EditorGUILayout.BeginVertical("box", GUILayout.MinWidth(5));                
                box1.ID = EditorGUILayout.TextField("Номер коробки", box1.ID);                               
                box1.AmountOfLetters = EditorGUILayout.IntField("Писем,шт", box1.AmountOfLetters);               
                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();
                EditorGUILayout.BeginVertical("box");
                box2.ID = EditorGUILayout.TextField("Номер коробки", box2.ID);
                box2.AmountOfLetters = EditorGUILayout.IntField("Писем,шт", box2.AmountOfLetters);
                EditorGUILayout.EndVertical();                

                EditorGUILayout.EndVertical();
                EditorGUILayout.Space();
            }
        }

        if(GUILayout.Button("Создать вагон", GUILayout.Width(100)))
        {
            carriageList.Add(new Carriage1());           
        }        
    }
}
