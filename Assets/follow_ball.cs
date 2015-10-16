using UnityEngine;
using System.Collections;

public class follow_ball : MonoBehaviour {
    public GameObject ball;
    public Vector3 posicion;

	// Use this for initialization
	void Start () {
        posicion = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 aux = new Vector3(posicion.x + ball.transform.position.x, posicion.y, posicion.z + ball.transform.position.z);
        transform.position = aux;
	}
}
