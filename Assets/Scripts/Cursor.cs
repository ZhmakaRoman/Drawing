using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    
    private void Update()
    {
        transform.position = new Vector3(Input.mousePosition.x - 10f,Input.mousePosition.y,0f);
    }
}
