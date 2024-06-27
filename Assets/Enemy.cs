using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Wizard.player.transform.position;
        Vector3 disanceVector = playerPosition - transform.position;
        disanceVector = disanceVector.normalized;
        transform.position += disanceVector * Time.deltaTime * 2;
    }

    void OnCollisionEnter2DEnter(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            Wizard.player.hp -= 10;
            Destroy(gameObject);
            return;
        }
        if(coll.gameObject.tag == "Fireball")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
            return;
        }


    }

}
