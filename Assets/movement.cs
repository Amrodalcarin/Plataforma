using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
    private static int CONSTANTE_DE_SALTO = 2;
    private Rigidbody rigidBody;
    public int velocidad;

    // Use this for initialization
    void Start () {
        setRigidBody(GetComponent<Rigidbody>());
    }

    void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");
        Vector3 movimiento;
        if (transform.position.y >= 1.676)
            movimiento = new Vector3(horizontal, 0, vertical);
        else
            movimiento = new Vector3(horizontal, jump * CONSTANTE_DE_SALTO, vertical);
        getRigidBody().AddForce(movimiento * velocidad * Time.deltaTime); //deltaTime is a value to level the speed with fps.
    }
	
    private void setRigidBody(Rigidbody rigidBody)
    {
        this.rigidBody = rigidBody;
    }

    // Get method for rigidBody
    private Rigidbody getRigidBody()
    {
        return rigidBody;
    }

    
}
