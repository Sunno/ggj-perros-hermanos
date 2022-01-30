using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(DeleteObject());
    }

    IEnumerator DeleteObject()
    {
        yield return new WaitForSeconds(GameManager.Instance.enemyWaitingTime * 2);
        Destroy(gameObject);
    }
}
