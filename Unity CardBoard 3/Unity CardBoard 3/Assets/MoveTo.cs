using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public Transform camera;
    public GameObject ground;

    void Start()
    {
    }

    void Update()
    {
        Ray ray;
        RaycastHit hit;
        GameObject hitObject;

        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 10.0f);
        ray = new Ray(camera.position, camera.rotation * Vector3.forward);

        if (Physics.Raycast(ray, out hit))
        {
            hitObject = hit.collider.gameObject;
            if (hitObject == ground)
            {
                //Debug.Log("Hit (x,y,z): " + hit.point.ToString("F2"));
                float dist = Vector3.Distance(hit.point, transform.position);
                if (dist < 50)
                {
                    transform.position = new Vector3(hit.point.x, 2.0f, hit.point.z);
                }
                else
                {
                    transform.position = new Vector3(camera.position.x, 2.0f, camera.position.z);
                }

            }
            else
            {
                transform.position = new Vector3(camera.position.x, 2.0f, camera.position.z);
            }
        }
    }
}
