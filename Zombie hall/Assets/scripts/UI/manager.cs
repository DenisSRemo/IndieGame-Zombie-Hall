using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{

    //this class dealts with the in-game UI

    public GameObject Object;
    private bool index;
    // Start is called before the first frame update
    void Start()
    {
        Object.SetActive(false);
        index = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&index==false)
        {
            index = true;
            Object.SetActive(index);
            Time.timeScale = 0;

        }
        else
             if (Input.GetKeyDown(KeyCode.Escape) && index == true)
        {
            index = false;
            Object.SetActive(index);
            Time.timeScale = 1;
        }
    }

    public void LoadScene(int index)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(index);

    }



    public void QuitGame()
    {
        Application.Quit();
    }




   
}
