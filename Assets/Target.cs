using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject tragetPrefab;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {

        float x = Random.Range(-9,9);
        float y = Random.value * 10 -5;
        Instantiate(tragetPrefab, new Vector3(0, -3, 0), Quaternion.identity);
        Destroy(gameObject);

    }
    

    

}