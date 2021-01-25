using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedeGeneration : MonoBehaviour
{
    public float XSize = 6.6f;
    public float ZSize = 6.6f;
    public GameObject MonedePrefab;
    public GameObject curMonede;
    public Vector3 curPos;

    
    void AddNewMonede()
    {
     RandomPos();
     curMonede = GameObject.Instantiate(MonedePrefab,curPos,Quaternion.identity) as GameObject;
        
    }
    void RandomPos()
    {
     curPos = new Vector3(Random.Range(XSize*-1,XSize),1f,Random.Range(ZSize*-1,ZSize));
    }
    
    void Update()
    {
        if(!curMonede)
        {
            AddNewMonede();
        }
        else
        {
            return;
        }
    }
}
