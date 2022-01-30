using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int yPos;




    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

   IEnumerator EnemyDrop()
    {

        while (true)
        {
            xPos = Random.Range(-6, 6);
            zPos = Random.Range(-6, 6);
            yPos = 10;
            Instantiate(enemy, new Vector3(xPos, yPos, zPos), Quaternion.identity, transform);
            yield return new WaitForSeconds(GameManager.Instance.enemyWaitingTime);
        }  
        
    }
}
