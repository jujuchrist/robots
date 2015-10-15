using UnityEngine;
using System.Collections;
using System;

public class ressourceManager : MonoBehaviour
{
    public GameObject[] corpsRobot;
    public GameObject[] partsRobot;

    // Use this for initialization
    void Start () {
	    
	}

    public GameObject createRobot(int corpsId)
    {
        GameObject corps = (GameObject)GameObject.Instantiate(corpsRobot[corpsId]);

        for(int i = 0; i < corps.transform.childCount; i++)
        {
            GameObject part = (GameObject)GameObject.Instantiate(partsRobot[0]);
            Transform child = corps.transform.GetChild(i);
            partScript pScr = part.GetComponent<partScript>();

            part.transform.parent = child;
            part.transform.localPosition = Vector3.zero;
            part.transform.localRotation = new Quaternion();

            pScr.connectJoint(corps, child.localPosition);
        }

        return corps;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
