using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrumpedScript : MonoBehaviour
{
    public float jumpBoost = 3.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpBoost;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpBoost;
    }
}