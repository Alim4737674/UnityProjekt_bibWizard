using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public string state = "Start";

    public static Gamemanager Instance;

    private float Counter;


    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            //Destroy(gameObject);
            //Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(state == "Game")
        {
            Counter += Time.deltaTime;
            if(Counter >= 30) 
            {
                Returntotitle();
                Counter = 0;
            }
        }
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("Game");
        state = "Game";
    }

    public void Returntotitle()
    {
        SceneManager.LoadScene("StartScreen");
        state = "Start";
    }


    public void Secondstart() 
    {
        
    }


    

    

}
