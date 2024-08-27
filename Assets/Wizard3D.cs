using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class Wizard3D : MonoBehaviour
{
    private Vector3 lastDirection;
    public GameObject fireball3DPrefab;
    float Fireballtimer = 10f;
    public static GameObject player;
    float sprintSpeedFactor = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Fireballtimer += Time.deltaTime;

        if (Input.GetMouseButtonUp(0) && Fireballtimer > 0)
        {
            GameObject obj = Instantiate(fireball3DPrefab, transform.position + lastDirection + Vector3.up, Quaternion.identity);
            obj.GetComponent<Fireball3D>().direction = lastDirection;
            Fireballtimer -= 5;
        }
    }

    public void Movement()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += Vector3.forward;
        }
        if (Input.GetKey("s"))
        {
            movement += Vector3.back;
        }
        if (Input.GetKey("a"))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey("d"))
        {
            movement += Vector3.right;
        }

        if(movement.magnitude > 0)
        {
            lastDirection = movement;
        }

        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintSpeedFactor = 8.0f;
        }

        transform.position += movement.normalized * Time.deltaTime * 3;

        /*public void Rotate()
        {
            float angle= Vector3.Angle(lastDirektion, Vector3.forward);
            if(lastDirektion)
        }*/

        

    }



}
