using UnityEngine;
using System.Collections;

public class Animaciones : MonoBehaviour {

	private Animator anim;							// a reference to the animator on the character
	private AnimatorStateInfo currentBaseState;			// a reference to the current state of the animator, used for base layer
	private AnimatorStateInfo layer2CurrentState;	// a reference to the current state of the animator, used for layer 2

	static int idleState = Animator.StringToHash("Base Layer.Dead");	

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		anim.SetBool("Muerto", true); 						// set our animator's float parameter 'Direction' equal to the horizontal input axis		

	}
}
