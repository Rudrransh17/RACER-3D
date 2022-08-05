using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Splashscreen : MonoBehaviour
{
    public Image logo;
    Color logoColor;
    public float lerpMultiplier = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        logoColor = new Color(1, 1, 1, 0);
        logo.color = logoColor;
        StartCoroutine(GotoMainMenu());
    }
    IEnumerator GotoMainMenu()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("MainMenu");
    }
    // Update is called once per frame
    void Update()
    {
        logoColor = Color.Lerp(logoColor, new Color(1, 1, 1, 1), Time.time * lerpMultiplier);
        logo.color = logoColor;
    }
}
