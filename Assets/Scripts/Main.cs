using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject prefabsGameObject;
    private long num = 0;
    private Vector3 LocalPostion;
    public Vector3 VungRandom = new Vector3(2, 2, 0);
    void Start()
    {
        LocalPostion = transform.position;
        num = myCharz.currentTimeMillis();
    }
    void Update()
    {
        if(myCharz.currentTimeMillis() - num > 10000)
        {
            num = myCharz.currentTimeMillis();
            
            Instantiate(prefabsGameObject, RandomVecto(), Quaternion.identity);
        }
    }
    private Vector3 RandomVecto()
    {
        float xMax = LocalPostion.x + VungRandom.x;
        float xMin = LocalPostion.x - VungRandom.x;
        float yMax = LocalPostion.y + VungRandom.y;
        float yMin = LocalPostion.y - VungRandom.y;
        return new Vector3(Random.Range(xMax, xMin), Random.Range(yMax, yMin), 0);

    }
}
