using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.Mathematics;

[CreateAssetMenu(fileName = "Coords", menuName = "Gameplay/Coordinates")]

public class CoordObjects : ScriptableObject
{
    [SerializeField] private List<Vector2> coords;
    [SerializeField] private GameObject prefab;


    public List<Vector2> Coords => coords; // делаем объект - readonly
    public GameObject Prefab => prefab; // делаем объект - readonly
}


