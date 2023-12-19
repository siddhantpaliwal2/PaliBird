using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1;
        Canvas.SetActive(false);
    }

    // Update is called once per frame
    public void GameOver()
    {
        Canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay(){
        SceneManager.LoadScene(0);

    }
}
