using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public GameObject SpawnPoint;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.gameObject.tag == "Player")
            {
                StartCoroutine(Respawn());
            }
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(0.5f);
        player.transform.position = SpawnPoint.transform.position;
    }
}
