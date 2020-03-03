using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKeyy : MonoBehaviour
{
    public MouseClick DoorScript;

    public void OnMouseDown()
    {
        DoorScript.HasKey = true;
        Destroy(gameObject);
    }
}
