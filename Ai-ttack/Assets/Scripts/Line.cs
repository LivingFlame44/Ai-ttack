using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class Line : MonoBehaviour
{
    public LineRenderer linerenderer;

    List<Vector2> points;
    // Start is called before the first frame update
    public void UpdateLine(Vector2 pos)
    {
        if(points == null)
        {
            points = new List<Vector2>();
            SetPoint(pos);
            return;
        }

        if (Vector2.Distance(points.Last(), pos) > .1f)
        {
            SetPoint(pos);
        }
    }

    void SetPoint(Vector2 point)
    {
        points.Add(point);
        linerenderer.positionCount = points.Count;
        linerenderer.SetPosition(points.Count - 1, point);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
