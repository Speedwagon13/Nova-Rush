using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletPooler : MonoBehaviour {

    public static PlayerBulletPooler current;
    private List<GameObject> playerBulletPool;
    private int poolSize;

    public GameObject playerBullet;

    private void Awake()
    {
        current = this;
    }

    // Use this for initialization
    void Start () {
        poolSize = 15;
        playerBulletPool = new List<GameObject>(poolSize);
		for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(playerBullet);
            obj.SetActive(false);
            playerBulletPool.Add(obj);
        }
	}
	
	public GameObject getPlayerBullet()
    {
        for (int i = 0; i < playerBulletPool.Count; i++)
        {
            if (!playerBulletPool[i].activeInHierarchy)
            {
                return (playerBulletPool[i]);
            }
        }
        return null;
    }
}
