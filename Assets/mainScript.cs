using UnityEngine;
using System.Collections;

public class mainScript : MonoBehaviour {
    ressourceManager RM;

	// Use this for initialization
	void Start () {
        RM = GetComponent<ressourceManager>();

        RM.createRobot(0).transform.position = new Vector3(0, 3, 0);
        RM.createRobot(1).transform.position = new Vector3(0, -3, 0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
