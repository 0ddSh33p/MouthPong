using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroller : MonoBehaviour
{
    public UnityEngine.U2D.SpriteShapeController controller;
    public GameObject[] points;
    public ball[] poses;
    public points scorer;
    public float max, min;
    private bool scoring;

    void Start()
    {
        Debug.Log("start");
        poses = new ball[points.Length];

        for (int i = 0; i < points.Length; i++) { poses[i] = points[i].GetComponent<ball>(); }

    }


    void Update()
    {
        for(int i = 0; i < points.Length -1; i++)
        {
            controller.spline.SetPosition(i, (points[i].transform.position));
        }

        if (transform.position.x > max)
        {
            
            for (int i = 0; i < poses.Length; i++) { poses[i].put = true; }
            if (!scoring) StartCoroutine(scoreA());
        }
        else if (transform.position.x < min)
        {
            for (int i = 0; i < poses.Length; i++) { poses[i].put = true; }
            if (!scoring) StartCoroutine(scoreB());
        }

        if (Input.GetKeyDown("r"))
        {
            for (int i = 0; i < poses.Length; i++) { poses[i].put = true; }
        }

        IEnumerator scoreA()
        {
            scoring = true;
            scorer.pA += 1;
            yield return new WaitForSeconds(0.5f);
            scoring = false;
        }
        IEnumerator scoreB()
        {
            scoring = true;
            scorer.pB += 1;
            yield return new WaitForSeconds(0.5f);
            scoring = false;
        }
    }
}