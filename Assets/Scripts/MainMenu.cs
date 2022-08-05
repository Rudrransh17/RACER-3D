using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;
    
    // Start is called before the first frame update
    void Start()
    {
        mainMenuUI.SetActive(true);
        
    }

    public void StartGamePressed()
    {
        mainMenuUI.SetActive(false);
        //Application.LoadLevel("GameScene");
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGamePressed()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
