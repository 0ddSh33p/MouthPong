using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallGush : MonoBehaviour
{
    public Transform[] points;
    public UnityEngine.U2D.SpriteShapeController controller;

    void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            controller.spline.SetPosition(i, (points[i].transform.position));
        }
    }
}
