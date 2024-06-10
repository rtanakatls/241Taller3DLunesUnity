using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class CheckPositions : MonoBehaviour
{
    [SerializeField] private List<GameObject> checkpointList;

    [SerializeField] private List<ObjectCheckpoint> objectList;

    [SerializeField] private List<GameObject> positionList;

    [SerializeField] private List<string> names;

    private void Awake()
    {
        names.Sort((x,y)=> x.CompareTo(y));

        foreach(ObjectCheckpoint obj in objectList)
        {
            obj.Obj.GetComponent<EnemyMovement>().SetObjectCheckpoint(obj);
        }
    }

    void Update()
    {
        positionList=new List<GameObject>();
        for(int i= checkpointList.Count-1; i>=0;i--)
        {
            GameObject checkpoint = checkpointList[i];
            if(i<checkpointList.Count-1)
            {

                GameObject nextCheckpoint = checkpointList[i+1];
                List<GameObject> list = new List<GameObject>();
                foreach (ObjectCheckpoint obj in objectList)
                {
                    if (obj.CurrentCheckpoint.GetInstanceID() == checkpoint.GetInstanceID())
                    {
                        list.Add(obj.Obj);
                    }
                }
                list.Sort((x,y) => Vector3.Distance(x.transform.position, nextCheckpoint.transform.position).
                CompareTo(Vector3.Distance(y.transform.position, nextCheckpoint.transform.position)));
                foreach(GameObject o in list)
                {
                    positionList.Add(o);
                }
            }
        }
    }
}
