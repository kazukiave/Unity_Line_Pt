using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPlotter : MonoBehaviour
{
    public GameObject point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            GameObject.Instantiate(point, pos, Quaternion.identity);
        }
    }
}
