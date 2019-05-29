using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat : MonoBehaviour
{
    public Transform right;
    public Transform left;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            left.Rotate(0, 90, -90);
        }


        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            right.Rotate(0, 90, -90);
        }
    }

    
}
