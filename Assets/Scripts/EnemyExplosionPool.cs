using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExplosionPool : MonoBehaviour {

    public static EnemyExplosionPool current;
    private List<GameObject> explosionPool;

    public int poolSize;
    public GameObject explosion;

    private void Awake()
    {
        current = this;
    }

    // Use this for initialization
    void Start()
    {
        explosionPool = new List<GameObject>(poolSize);
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(explosion);
            obj.SetActive(false);
            explosionPool.Add(obj);
        }
    }

    public GameObject getExplosion()
    {
        for (int i = 0; i < explosionPool.Count; i++)
        {
            if (!explosionPool[i].activeInHierarchy)
            {
                return (explosionPool[i]);
            }
        }

        GameObject obj = Instantiate(explosion);
        obj.SetActive(false);
        explosionPool.Add(obj);
        return obj;
    }
}
