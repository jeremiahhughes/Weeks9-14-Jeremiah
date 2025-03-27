using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer sr;
    public float speed = 2;
    public AudioClip footsteps;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");

        sr.flipX = (direction < 0);
        animator.SetFloat("Isrunning", Mathf.Abs(direction));
    }

    public void Footstep()
    {
        AudioSource.PlayClipAtPoint(footsteps, transform.position);
    }
}
