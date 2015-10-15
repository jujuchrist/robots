using UnityEngine;
using System.Collections;
using System;

public class partScript : MonoBehaviour {
    public string nom = "";
    private AnchoredJoint2D joint;

	// Use this for initialization
	void Start () {

	}

    private AnchoredJoint2D getJoint()
    {
        if (joint == null) { 
            if (GetComponent<DistanceJoint2D>() != null)
            {
                joint = GetComponent<DistanceJoint2D>();
            }
            if (GetComponent<HingeJoint2D>() != null)
            {
                joint = GetComponent<HingeJoint2D>();
            }
            if (GetComponent<SliderJoint2D>() != null)
            {
                joint = GetComponent<SliderJoint2D>();
            }
            if (GetComponent<SpringJoint2D>() != null)
            {
                joint = GetComponent<SpringJoint2D>();
            }
            if (GetComponent<WheelJoint2D>() != null)
            {
                joint = GetComponent<WheelJoint2D>();
            }
        }

        return joint;
    }

    internal void connectJoint(GameObject pConnectedGO, Vector2 pConnectedAnchor)
    {
        if(getJoint() != null)
        {
            joint.connectedBody = pConnectedGO.GetComponent<Rigidbody2D>();
            joint.connectedAnchor = pConnectedAnchor;
        }

    }

    // Update is called once per frame
    void Update () {
	
	}
}
