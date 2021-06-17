using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_collisions : MonoBehaviour
{
    public GameObject gameBrain, explosion, soundManager;

    private void OnTriggerEnter(Collider colObj)
    {
        if(colObj.gameObject.tag=="Bullet")
        {
            GameObject newExplosion = Instantiate(explosion, transform.position, Quaternion.identity);
            soundManager.SendMessage("playExplosionSound");
            gameBrain.SendMessage("EnemyCounter");
            Destroy(gameObject);
            Destroy(newExplosion, 2);
            
            Destroy(colObj.gameObject);


        }
        if(colObj.gameObject.tag=="Player")
        {
            Destroy(colObj.gameObject);
            SceneManager.LoadScene("game over");
        }
    }
}
