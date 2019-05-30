using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Transform dest;
    public float throwforce = 10f;
    private Rigidbody rb;
    private int times;
    public Collider cc;
    // Start is called before the first frame update
    void Start()
    {
        times = 0;
        rb = GetComponent<Rigidbody>();
        dest = GameObject.Find("throwpos").transform;
        cc = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (times >= 6)
        {
            Destroy(gameObject);
        }
    }
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        transform.rotation = dest.rotation;
        this.transform.parent = GameObject.Find("throwpos").transform;
        cc.isTrigger = true;

    }
    private void OnMouseUp()
    {
        cc.isTrigger = false;
        times++;
        transform.Translate(0f, 0f, 5f);
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }
}