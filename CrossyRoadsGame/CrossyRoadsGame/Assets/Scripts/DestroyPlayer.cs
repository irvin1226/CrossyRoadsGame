using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public Player player;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            player.wasHit = true;
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
