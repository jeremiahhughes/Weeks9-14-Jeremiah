using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedBattler : MonoBehaviour
{
    public float Rotations = 3.5f;
    public Transform sprite;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GrowSprite());
    }
    
    IEnumerator GrowSprite()
    {
        while (t < Rotations)
        {
            t += Time.deltaTime;
            sprite.Rotate(0, 0, 1 * t);
            yield return null;
        }
    }
}
