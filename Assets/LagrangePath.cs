using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;

public class LagrangePath : MonoBehaviour
{
    private LagrangeCalc calc;

    [SerializeField] public float x;
    [SerializeField] private GameObject prefab;
    [SerializeField] private CoordObjects coordsData;

    private void Start()
    {
        calc = new(coordsData.Coords,x);
        for (var i = 1; i < coordsData.Coords.Count; i++)
        {
            //if (objects[i] == null)
            //{
            //    continue;
            //}
            //CreateCurve(calc.pathPoints[i]);
        }
        
    }

    //private void CreateCurve(Vector2 end)
    //{
    //    Instantiate(coordsData.Prefab, end, quaternion.identity, transform);
    //}

}