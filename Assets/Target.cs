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

        float x = Random.Range(-3,3);
        float y = Random.Range(-3,3);
        Instantiate(tragetPrefab, new Vector3(x, y, 0), Quaternion.identity);
        Destroy(gameObject);
        Hud.score ++;
        Wizard player = Wizard.player;
        PlayerStats stats = player.stats;
        stats.GainXp(1);

    }




}