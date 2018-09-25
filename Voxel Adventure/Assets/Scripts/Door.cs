using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	static public bool opened = false;
	 public Animation anim;
	 public bool locked;
	 Collider m_ObjectCollider;
	// Use this for initialization
	void Start () {
		 DontDestroyOnLoad(gameObject);
		 anim = GetComponent<Animation>();

		 //Fetch the GameObject's Collider (make sure they have a Collider component)
			 m_ObjectCollider = GetComponent<Collider>();
			 //Here the GameObject's Collider is not a trigger
			 m_ObjectCollider.isTrigger = false;
			 //Output whether the Collider is a trigger type Collider or not
			 Debug.Log("Trigger On : " + m_ObjectCollider.isTrigger);
	}

	// Update is called once per frame
	void Update () {
		if(opened){
			//gameObject.SetActive(false);
			Destroy(gameObject);
		}

	}
		private void SetDoorOpen(){
			opened = true;
			Debug.Log("door opened");

		}
		private void SetDoorUnlocked(){
			locked = false;

			//GameObject's Collider is now a trigger Collider when the GameObject is clicked. It now acts as a trigger
        m_ObjectCollider.isTrigger = true;
        //Output to console the GameObject’s trigger state
        Debug.Log("Trigger On : " + m_ObjectCollider.isTrigger);
		}

}
