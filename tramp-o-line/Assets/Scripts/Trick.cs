using UnityEngine;
using System.Collections;

public class Trick : MonoBehaviour {
    //void EndTrick();

    protected bool trickFinished;

    void Start()
    {
        trickFinished = false;
    }

    void Update()
    {
    }

    public bool IsTrickFinished()
    {
        return trickFinished;
    }
}
