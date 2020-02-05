using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

    
    Vector3 hitDown = Vector3.zero;
    Vector3 hitUp = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 1f, out hit, Mathf.Infinity))
            {
                hitDown = hit.transform.position;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 1f, out hit, Mathf.Infinity))
            {
                hitUp = hit.transform.position;
            }

            if (hitUp != Vector3.zero && hitDown != Vector3.zero)
            {
                var line = new GameObject("line");
                var lineRender = line.AddComponent<LineRenderer>();
                lineRender.SetPosition(0, hitDown);
                lineRender.SetPosition(1, hitUp);

                hitDown = Vector3.zero;
                hitUp = Vector3.zero;
            }
        }


    }
}
