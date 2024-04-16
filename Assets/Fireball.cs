using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {

         
        transform.position = transform.position + new Vector3(4, 0 , 0 ) * Time.deltaTime;

        if ( timer > 0)
        {
            Destroy (gameObject, timer );
        }

        //Destroy(gameObject);
    }
}
