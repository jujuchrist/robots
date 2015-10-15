using UnityEngine;
using System.Collections;
using System;

public class ressourceManager : MonoBehaviour
{
    public GameObject robotGO;
    public GameObject[] corpsRobot;
    public GameObject[] partsRobot;

    // Use this for initialization
    void Start () {
	    
	}

    public GameObject createRobot(int corpsId)
    {
        GameObject robot = (GameObject)GameObject.Instantiate(robotGO);
        GameObject corps = (GameObject)GameObject.Instantiate(corpsRobot[corpsId]);

        for(int i = 0; i < corps.transform.childCount; i++)
        {
            GameObject part = (GameObject)GameObject.Instantiate(partsRobot[0]);

            part.transform.parent = robot.transform;
            part.transform.position = corps.transform.GetChild(i).position;
            part.transform.rotation = corps.transform.GetChild(i).rotation;
        }

        corps.transform.parent = robot.transform;

        return robot;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
