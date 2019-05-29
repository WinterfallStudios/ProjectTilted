using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Transform dest;
    public float throwforce = 10f;
    private Rigidbody rb;
    private int times;
    // Start is called before the first frame update
    void Start()
    {
        times = 0;
        rb = GetComponent<Rigidbody>();
        dest = GameObject.Find("throwpos").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (times >= 4)
        {
            Destroy(gameObject);
        }
    }
    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;

        this.transform.parent = GameObject.Find("throwpos").transform;

    }
    private void OnMouseUp()
    {
        times++;
        transform.Translate(0f, 0f, throwforce);
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }
}