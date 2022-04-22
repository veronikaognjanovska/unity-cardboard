using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public Transform camera;
    public GameObject ground;

    // Start is called before the first frame update
    void Start()
    {
        //camera = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray;
        RaycastHit hit;
        GameObject hitObject;

        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 10.0f);
        ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        Debug.Log("camera " + camera.position + camera.rotation);
        if (Physics.Raycast(ray, out hit))
        {
            hitObject = hit.collider.gameObject;
            if (hitObject == ground)
            {
                Debug.Log("Hit (x,y,z): " + hit.point.ToString("F2"));
                //  transform.position.x = hit.point.x;
                //   transform.position.z = hit.point.z;
                float dist = Vector3.Distance(hit.point, transform.position);
                if(dist < 50)
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
