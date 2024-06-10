using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class IconReference 
{
    [SerializeField] private Transform originalObject;
    [SerializeField] private Transform iconObject;

    public Transform OriginalObject { get {  return originalObject; } }
    public Transform IconObject { get {  return iconObject; } }

}
