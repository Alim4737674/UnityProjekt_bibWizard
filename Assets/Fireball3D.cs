using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball3D : MonoBehaviour
{
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {


        float angle = Vector3.Angle(direction, Vector3.right);


        if (direction.y < 0)
        {
            angle = angle * -1;
        }

        transform.Rotate(new Vector3(0, 0, 45));

        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction * 4 * Time.deltaTime;
    }
}
