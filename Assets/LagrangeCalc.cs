using System.Collections.Generic;
using UnityEngine;


public class LagrangeCalc
{
    public List<Vector2> pathPoints;
    
    public LagrangeCalc(List<Vector2> newCoords, float x)
    {
        var result = functionCalc(newCoords[0], newCoords[1], newCoords[2], newCoords[3], x);
        Debug.Log(result);
    }

    public void DeletePath()
    {
        pathPoints.Clear();
    }

    private float functionCalc(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float x)
    {
        float x1 = p1.x;
        float x2 = p2.x;
        float x3 = p3.x;
        float x4 = p4.x;
        float y1 = p1.y;
        float y2 = p2.y;
        float y3 = p3.y;
        float y4 = p4.y;

        float val1 = (x - x2) * (x - x3) * (x - x4) / (y1 - x2) * (y1 - x3) * (y1 - x4);
        float val2 = (x - x1) * (x - x3) * (x - x4) / (y2 - x1) * (y2 - x3) * (y2 - x4);
        float val3 = (x - x1) * (x - x2) * (x - x4) / (y3 - x1) * (y3 - x2) * (y3 - x4);
        float val4 = (x - x1) * (x - x2) * (x - x3) / (y4 - x1) * (y4 - x2) * (y4 - x3);

        return y1 * val1 + y2 * val2 + y3 * val3 + y4 * val4;
    }

}