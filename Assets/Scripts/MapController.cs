using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField] private List<IconReference> iconReferences;

    void Update()
    {
        foreach (IconReference iconReference in iconReferences) 
        {
            Vector2 position = new Vector2(iconReference.OriginalObject.position.x, iconReference.OriginalObject.position.z);
            iconReference.IconObject.localPosition=position/2;
        }
    }
}
