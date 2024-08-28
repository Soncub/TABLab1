using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board_Script : MonoBehaviour
{
    #if UNITY_EDITOR
    public void OnDrawGizmos()
    {
        for(int i = 0; i < 9; i++)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(new Vector3(-0.5f, i-0.5f, 0), new Vector3(7.5f, i-0.5f, 0));
            Gizmos.DrawLine(new Vector3(i-0.5f, -0.5f, 0), new Vector3(i-0.5f, 7.5f, 0));
        }
    }
    #endif
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
