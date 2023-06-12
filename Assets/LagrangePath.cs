using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;

public class LagrangePath : MonoBehaviour
{
    private LagrangeCalc calc;

    [SerializeField] public float x;
    [SerializeField] private GameObject prefab;
    [SerializeField] private CoordObjects coordsData;
    private readonly List<GameObject> objects = new List<GameObject>();


    private void Start()
    {
        calc = new(coordsData.Coords, x);
        for (var i = 1; i < coordsData.Coords.Count; i++)
        {
            if (objects[i] == null)
            {
                continue;
            }

            GameObject obj = Instantiate(coordsData.Prefab, coordsData.Coords[i], Quaternion.identity, transform);
            objects.Add(obj);
            
        }

        //UpdatePath();
        //for (var i = 1; i < calc.pointCount; i++)
        //{
        //    CreateCube(calc.pathPoints[i]);
        //}
    }

    private void UpdatePath()
    {
        var controlPoints = new List<Vector3>();
        for (var i = 0; i < objects.Count; i++)
        {
            if (objects[i] == null)
            {
                continue;
            }

            Vector3 position = objects[i].transform.position;
            controlPoints.Add(position);
        }

        calc.DeletePath();
        //calc.CreateCurve(controlPoints);
    }
    
    //public class LagrangeCalc
    //{
    //    public List<Vector2> pathPoints;

    //    public LagrangeCalc(List<Vector2> newCoords, float x)
    //    {
    //        var result = functionCalc(newCoords[0], newCoords[1], newCoords[2], newCoords[3], x);
    //        Debug.Log(result);
    //    }

    //    public void DeletePath()
    //    {
    //        pathPoints.Clear();
    //    }

    //    private float functionCalc(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float x)
    //    {
    //        float x1 = p1.x;
    //float x2 = p2.x;
    //float x3 = p3.x;
    //float x4 = p4.x;
    //float y1 = p1.y;
    //float y2 = p2.y;
    //float y3 = p3.y;
    //float y4 = p4.y;

    //float val1 = (x - x2) * (x - x3) * (x - x4) / (y1 - x2) * (y1 - x3) * (y1 - x4);
    //float val2 = (x - x1) * (x - x3) * (x - x4) / (y2 - x1) * (y2 - x3) * (y2 - x4);
    //float val3 = (x - x1) * (x - x2) * (x - x4) / (y3 - x1) * (y3 - x2) * (y3 - x4);
    //float val4 = (x - x1) * (x - x2) * (x - x3) / (y4 - x1) * (y4 - x2) * (y4 - x3);

    //return y1 * val1 + y2 * val2 + y3 * val3 + y4 * val4;


    //}


    //private void CreateCube(Vector3 end)
    //{
    //    Instantiate(coordsData.Prefab, end, quaternion.identity, transform);
    //}

    //private void UpdatePath()
    //{
    //    var controlPoints = new List<Vector3>();
    //    for (var i = 0; i < objects.Count; i++)
    //    {
    //        if (objects[i] == null)
    //        {
    //            continue;
    //        }

    //        Vector3 position = objects[i].transform.position;
    //        controlPoints.Add(position);
}
       
    //    path.DeletePath();
    //    path.CreateCurve(controlPoints);
    //}