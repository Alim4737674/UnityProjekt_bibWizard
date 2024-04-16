using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public float movmentSpeed = 2.0f;

    public GameObject fireballPrefab;

    public float cooldownTime = 3.0f;

    private float nextFireTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movement = Vector3.zero;
        if (Input.GetKey("d"))
        {
            //movement += new Vector3(0.01f, 0,0);
            movement += Vector3.right;
        }
        if (Input.GetKey("a"))
        {
            //movement += new Vector3(-0.01f, 0, 0);
            movement += Vector3.left;
        }
        if (Input.GetKey("w"))
        {
            //movement += new Vector3(0, 0.01f, 0);
            movement += Vector3.up;
        }
        if (Input.GetKey("s"))
        {
            //movement += new Vector3(0, -0.01f, 0);
            movement += Vector3.down;
        }

        transform.position += movement.normalized * Time.deltaTime * movmentSpeed;

        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFireTime)
        {
            nextFireTime = Time.time + cooldownTime;
            Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            


        }

        
    }
}
