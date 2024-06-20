using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public string state = "Start";

    public static Gamemanager Instance;

    private float Counter;

    public int score;


    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            score = 0;
        }else
        {
            Destroy(gameObject);
            //Application.Quit();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(state == "Game")
        {
            Counter += Time.deltaTime;
            if(Counter >= 10) 
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


    public void OnNewGame()
    {
        score = 0;
        Wizard.stats = new PlayerStats();
        SceneManager.LoadScene("Game");
        state = "Game";
    }


    public void Es()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //Pause.SetActive(true);
        }


    }
}
