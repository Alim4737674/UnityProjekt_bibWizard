using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CN : MonoBehaviour
{
    public GameObject gamecanvas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            gamecanvas.SetActive(true);
        }
        else
        {
            gamecanvas.SetActive(false);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Pause.SetActive(false);
        }

    }
}
