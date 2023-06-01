using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    [SerializeField] private Text scoreCard;

    public int pA, pB;

    void Update()
    {
        scoreCard.text = "Points:\n" + (pA) + " - " + (pB);
    }
}
