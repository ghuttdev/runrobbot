using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PoolingObject : MonoBehaviour {

    public GameObject pooledObj;
    public int pooledAmount;

    List<GameObject> pooledObjs;


    // Use this for initialization
    void Start() {

        pooledObjs = new List<GameObject>();

        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObj);
            obj.SetActive(false);
            pooledObjs.Add(obj);
        }

    }



    public GameObject GetPooledObj()
    {
        for (int i = 0; i < pooledObjs.Count; i++)
        {
            if (!pooledObjs[i].activeInHierarchy)
            {
                return pooledObjs[i];
            }
            
        }
        GameObject obj = (GameObject)Instantiate(pooledObj);
        obj.SetActive(false);
        pooledObjs.Add(obj);
        return obj;

    }

}
