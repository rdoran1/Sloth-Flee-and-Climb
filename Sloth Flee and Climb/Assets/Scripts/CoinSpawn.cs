using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public Transform one;
    public Transform two;
    public Transform three;
    public Transform four;
    public Transform five;
    public Transform targetSpawn;

    private Vector3[] randomArray;
    private int spawnNumber;

    private void OnCollisionEnter(Collision col)
    {
        spawnNumber = Random.Range(1, 5);
        targetSpawn.transform.position = NewPos(spawnNumber);

        if (col.gameObject.tag == "Player")
        {
            Instantiate(gameObject, targetSpawn.transform.position, targetSpawn.transform.rotation);
            Destroy(gameObject);
        }
    }

    Vector3 NewPos(int ranNum)
    {
        randomArray = new Vector3[5];
        randomArray[0] = one.position;
        randomArray[1] = two.position;
        randomArray[2] = three.position;
        randomArray[3] = four.position;
        randomArray[4] = five.position;

        Vector3 newPos = randomArray[ranNum];

        return newPos;
    }
}

