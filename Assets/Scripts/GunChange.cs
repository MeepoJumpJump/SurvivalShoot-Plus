using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunChange : MonoBehaviour {

    GameObject gun_1;
    GameObject gun_2;

    // Use this for initialization
    void Start () {
        gun_1 = GameObject.Find("Gun_1");
        gun_2 = GameObject.Find("Gun_2");
        gun_2.SetActive(false);
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            gun_1.SetActive(true);
            gun_2.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            gun_1.SetActive(false);
            gun_2.SetActive(true);
        }
    }
}
