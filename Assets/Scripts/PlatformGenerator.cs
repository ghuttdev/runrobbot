using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {


    public GameObject platform;
    public Transform generationPoint;
    public float distBetween;

    private float platWidth;

    public float distBetweenMin;
    public float distBetweenMax;

    
    private int platformRand;
    private float[] platformWidths;

    
   

    public PoolingObject[] ObjPool;


    private float minHeight;
    public Transform maxHeightPoint;
    private float maxHeight;
    public float maxHeightJump;
    private float heightJump;

    // Use this for initialization
    void Start () {
        

        platformWidths = new float[ObjPool.Length];

        for (int i = 0; i < ObjPool.Length; i++)
        {
            platformWidths[i] = ObjPool[i].pooledObj.GetComponent<BoxCollider2D>().size.x;
        }

        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;
	}
	
	// Update is called once per frame
	void Update () {
	
        if(transform.position.x < generationPoint.position.x)
        {
            distBetween = Random.Range(distBetweenMin, distBetweenMax);


            platformRand = Random.Range(0, ObjPool.Length);

            heightJump = transform.position.y + Random.Range(maxHeightJump, -maxHeightJump);

            if(heightJump > maxHeight )
            {
                heightJump = maxHeight;
            }else if (heightJump < minHeight)
            {
                heightJump = minHeight;
            }
            transform.position = new Vector3(transform.position.x + (platformWidths[platformRand] / 2) + distBetween, heightJump, transform.position.z);

           
            GameObject newPlatform = ObjPool[platformRand].GetPooledObj();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;

            newPlatform.SetActive(true);


            transform.position = new Vector3(transform.position.x + (platformWidths[platformRand] / 2) + distBetween, transform.position.y, transform.position.z);
        }
	}
}
