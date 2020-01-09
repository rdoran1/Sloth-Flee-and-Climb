using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 50.0f;
    public EnergyDecay energy;
    public GameOver fail;

    public ScoreSystem score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-1,0,0) * speed;
            PlayerMovement();
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(1,0,0) * speed;
            PlayerMovement();
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 1, 0) * speed;
            PlayerMovement();
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, -1, 0) * speed;
            PlayerMovement();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }

    private void PlayerMovement()
    {
            energy.EnergyLoss();
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            GameFail();
        }
        if(collision.gameObject.tag == "Coin")
        {
            speed += 1.0f;
            score.AddScore();
            energy.EnergyGain();

        }
    }

    private void GameFail()
    {
        fail.Fail();
    }
    

}
