using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public GameObject fireballPrefab;
    float castTimer = 0f;
    float movementSpeed = 2.0f;
    Vector3 lastMovement = Vector3.zero;
    private Animator animator;

    public PlayerStats stats;

    public static Wizard player;
    float ManaTimer = 0f;
    public static int Mana = 100;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        stats = new PlayerStats();
        player = this;
    }

    // Update is called once per frame
    void Update()
    {   

        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += Vector3.up;
        }
        if (Input.GetKey("s"))
        {
            movement += Vector3.down;
        }
        if (Input.GetKey("a"))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey("d"))
        {
            movement += Vector3.right;
        }

        if (movement.x > 0 || movement.y > 0 || movement.x < 0 || movement.y < 0)
        {
            lastMovement = movement;
            animator.SetBool("Walking", true);
            transform.localScale = new Vector3(1,1,1);
        }
        else
        {
            animator.SetBool("Walking", false);
        }


        float sprintSpeedFactor = 1.0f;
        if (Input.GetKey(KeyCode.LeftShift)) {
            sprintSpeedFactor = 2.0f;
        }

        transform.position += movement.normalized * Time.deltaTime * movementSpeed * sprintSpeedFactor;


        castTimer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && castTimer <= 0 && Mana > 5) {
            GameObject obj = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            obj.GetComponent<Fireball>().direction = lastMovement;
            castTimer = 1;
            animator.SetBool("Attack", true);
            Mana -= 10;
            
        }
        else
        {
            animator.SetBool("Attack", false);
        }

        
        ManaTimer -= Time.deltaTime;
        if (ManaTimer <= 0)
        {
            Mana += 5;
            ManaTimer += 5;
        }

        if (Mana > 100)
        {
            Mana -= 5;
        }

    }

        public static PlayerStats GetStats()
        {
            return player.stats;
        }

}