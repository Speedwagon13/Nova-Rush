using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletPooler : MonoBehaviour {

    public static EnemyBulletPooler current;
    private List<GameObject> enemyBulletPool;
    private int poolSize;

    public GameObject enemyBullet;

    private void Awake()
    {
        current = this;
    }

    // Use this for initialization
    void Start () {
        poolSize = 70;
        enemyBulletPool = new List<GameObject>(poolSize);
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(enemyBullet);
            obj.SetActive(false);
            enemyBulletPool.Add(obj);
        }
	}
	
    public GameObject getEnemyBullet()
    {
        for (int i = 0; i < enemyBulletPool.Count; i++)
        {
            if (!enemyBulletPool[i].activeInHierarchy)
            {
                return (enemyBulletPool[i]);
            }
        }

        GameObject obj = Instantiate(enemyBullet);
        obj.SetActive(false);
        enemyBulletPool.Add(obj);
        return obj;
    }
}
