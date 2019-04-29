using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_Control : MonoBehaviour {

    // Use this for initialization

    public int length;
    public int width;

    //Room name
    public string room_type;
    // Items the user wants in the room
    public Boolean AutomaticFurniture;

    [TextArea(3, 10)]
    public string FurnitureItems = "";
    private List<string> item_list = new List<string>() { };

    private GameObject FurnitureObject;
    private Database database;
    private Object_Controller object_Controller;

	public void Awake()
	{
        FurnitureObject = GameObject.FindWithTag("FurnitureObjects");
        database = FurnitureObject.GetComponent<Database>();
	}


	public void Start () {
        if(!AutomaticFurniture)
        {
            string[] modelsToPlace = FurnitureItems.Split(new string[] { "\n" }, StringSplitOptions.None);
            foreach (string s in modelsToPlace)
                item_list.Add(s);
            Debug.Log("You have added " + item_list.Count + " furniture objects to be placed in the room.");
        }
        GameObject obj = database.furniture_d[item_list[0]];
        Debug.Log( obj.GetComponent<Object_Controller>().length);

        foreach (string s in item_list)
        {

          
            //Debug.Log(obj.ToString());
           // GetComponent<Object_Controller>();;
        }

		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
}
