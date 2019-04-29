using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour {

    // Use this for initialization

    public GameObject[] database = new GameObject[2];

    // Maintaining a Dictionary
   public Dictionary<string, GameObject> furniture_d = new Dictionary<string, GameObject>();
	void Start () {
        furniture_d.Add("armchair", database[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
