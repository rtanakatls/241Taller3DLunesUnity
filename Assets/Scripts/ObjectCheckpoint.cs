using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ObjectCheckpoint 
{
    [SerializeField] private GameObject currentCheckpoint;
    [SerializeField] private GameObject obj;

    public GameObject CurrentCheckpoint { get {  return currentCheckpoint; } set { currentCheckpoint = value; } }
    public GameObject Obj { get {  return obj; } }

}
