using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveViveWithKinect : MonoBehaviour
{

    public Transform HeadTransform;
    //public Transform Controller;

	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(HeadTransform.position.x, HeadTransform.position.y, HeadTransform.position.z);

        //Controller.Translate(transform.position - Controller.position);
        
	    //transform.eulerAngles = new Vector3(transform.eulerAngles.x, HeadTransform.eulerAngles.y, transform.eulerAngles.z);
	}
}
