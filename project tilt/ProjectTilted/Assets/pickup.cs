using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Transform dest;
    public float throwforce = 10f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       dest = GameObject.Find("throwpos").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        
        this.transform.parent = GameObject.Find("throwpos").transform;
        
    }
    private void OnMouseUp()
    {
        
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
