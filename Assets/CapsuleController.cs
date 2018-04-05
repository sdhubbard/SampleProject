using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour {

    public Transform capsuleTransform;
    public CapsuleCollider capsuleCollider;
    int rotateAmount = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {        
        bool mousePressed = Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Mouse Button Pressed.");
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right Mouse Button Pressed.");
        }


        capsuleTransform.Rotate(Vector3.forward, rotateAmount);

        if (!mousePressed)
        {
            return;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (!capsuleCollider.Raycast(ray, out hit, 1000F))
            return;

        if (rotateAmount == -1)
        {
            rotateAmount = 1;
        }
        else
        {
            rotateAmount = -1;
        }
    }
}
