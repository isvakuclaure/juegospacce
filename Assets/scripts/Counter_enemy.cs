using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter_enemy : MonoBehaviour
{
    public int enemyCount;
    public int maximoenemy;

    public void EnemyCounter()
    {
        enemyCount++;
        if(enemyCount >= maximoenemy)
        {
            
            SceneManager.LoadScene("Win");
        }
    }
}
