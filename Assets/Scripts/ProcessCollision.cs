using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessCollision : MonoBehaviour
{
    public int points = 0;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.score += points;
            GameManager.Instance.triggerScoreUpdate();
            Destroy(gameObject);
        }
        
    }
}
