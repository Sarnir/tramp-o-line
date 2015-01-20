using UnityEngine;
using System.Collections;

public class Trick : MonoBehaviour {
    //void EndTrick();

    protected GameObject player;
    protected bool trickFinished;

    public virtual void SetPlayer(GameObject pl)
    {
        player = pl;
        trickFinished = false;
    }

    void Update()
    {
       // print("Updating trick\n");
    }

    public virtual bool IsTrickFinished()
    {
        return trickFinished;
    }
}
