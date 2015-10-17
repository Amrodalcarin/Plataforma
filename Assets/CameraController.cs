using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public float distance;
    private float currentAnglex = 0;
    private float currentAngley = 35;

    void LateUpdate()
    {
        currentAnglex += Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        currentAngley += Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        Quaternion q = Quaternion.Euler(currentAngley, currentAnglex, 0);
        Vector3 direction = q * Vector3.forward;
        transform.position = target.transform.position - direction * distance;
        transform.LookAt(target.transform.position);
    }
}
