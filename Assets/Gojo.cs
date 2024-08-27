using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gojo : MonoBehaviour
{
    private Animator animator;
    Vector3 movement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.magnitude > 0)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }
    }
}
