using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text gameOver;
    public Text score;
    public Button quit;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.enabled = false;
        score.enabled = false;
    }

    public void Fail()
    {
        gameOver.enabled = true;
        score.enabled = true;
    }
    
}
