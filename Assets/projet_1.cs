using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projet_1 : MonoBehaviour
{
    public int nbrObjets = 5;
    public int radius = 2;
    public GameObject prefab1;
    private GameObject[] a;
    float x;

    void Start()
    {
       
        Instantiate(prefab1, new Vector3 (0,0,0), Quaternion.identity);
        
    }

    void Update()
    {
        DeleteCube();
        x += Time.deltaTime * 50;
        for(var i = 0; i<nbrObjets; i++)
        {
            var angle = i * Mathf.PI * 2 / nbrObjets;
            var pos = new Vector3 (Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
            Instantiate(prefab1, pos, Quaternion.Euler(x,x,x));
        }
    }

    void DeleteCube()
    {
        a = GameObject.FindGameObjectsWithTag("Cube");
        foreach(GameObject o in a)
        {
            Destroy(o);
        }
    }
}
