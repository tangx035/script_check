
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using System;


public class Call_GameObject : MonoBehaviour 
{
//  public this GameObject in the inspector, for later on putting the object which holding the script need to access on it
//	public GameObject wall_1;
	public GameObject wall_2;
//	public GameObject wall_3;
//	public GameObject wall_4;

	// "getTime" need to be the script's excauate name that need to access.
	// "SecondScriptToAccess" is the variable for holding the component/code accessed from other script.
	private GetTime SecondScriptToAccess; 

	private int wall_1_timeBeLooked;
	private int wall_2_timeBeLooked;
	private int wall_3_timeBeLooked;
	private int wall_4_timeBeLooked;
	private int ball_1_timeBeLooked;
	private int ball_2_timeBeLooked;
	private int ball_3_timeBeLooked;
	private int ball_4_timeBeLooked;

	List<DetectedItems> itemsAttribute = new List<DetectedItems> ();
//	List<char> nameAppend = new List<char> ();

	string[] nameAppend = new string[8];
//	private int i;


	void Start () 
	{
		//data getting
		SecondScriptToAccess = wall_2.GetComponent<GetTime> ();
		IntoInt ();
		ItemsList ();
	}

	void IntoInt()
	{
		wall_1_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.wall_1_timeLooked); 
		wall_2_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.wall_2_timeLooked); 
		wall_3_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.wall_3_timeLooked); 
		wall_4_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.wall_4_timeLooked); 
		ball_1_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.ball_1_timeLooked); 
		ball_2_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.ball_2_timeLooked); 
		ball_3_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.ball_3_timeLooked); 
		ball_4_timeBeLooked= Mathf.RoundToInt(SecondScriptToAccess.ball_4_timeLooked); 
	}

	void ItemsList()
	{
		itemsAttribute.Add ( new DetectedItems("wall_1",wall_1_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("wall_2",wall_2_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("wall_3",wall_3_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("wall_4",wall_4_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("ball_1",ball_1_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("ball_2",ball_2_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("ball_3",ball_3_timeBeLooked));
		itemsAttribute.Add ( new DetectedItems("ball_4",ball_4_timeBeLooked));
	}

	void PrintItemsTime()
	{
		foreach (DetectedItems eachItems in itemsAttribute) 
		{
		//	Console.WriteLine(eachItems);
			print (eachItems.name + ": " + eachItems.time);
		}
		//itemsAttribute.Clear();
	}

	void GetSortedObjectName()
	{
		foreach (DetectedItems eachItemsName in itemsAttribute) 
		{
		//	eachItemsName.name.ToList();
		//	eachItemsName.name.ToString();

			nameAppend [0] = eachItemsName.name [0].ToString();
			nameAppend [1] = eachItemsName.name [1].ToString();
			nameAppend [2] = eachItemsName.name [2].ToString();
			nameAppend [3] = eachItemsName.name [3].ToString();
			nameAppend [4] = eachItemsName.name [4].ToString();
			nameAppend [5] = eachItemsName.name [5].ToString();
   // 		nameAppend [6] = eachItemsName.name [6].ToString();
	//		nameAppend [7] = eachItemsName.name [7].ToString();
		//	printOutAppend ();
		}
		//itemsAttribute.Clear();
	}

	void NameAppendList()
	{

	}

	void printOutAppend()
	{
		
		for (int i = 0; i < 8; i++) {
			Debug.Log (nameAppend[i]);	
		}
	
	}


	void Update ()
	{
		//call IntoInt function to change all float numbers into integer
		IntoInt ();
		// add items into list with name and int time number init
		ItemsList ();
		//sort list "items" according to comparer which called from "DetectedItems.cs"
		itemsAttribute.Sort ();
//		Console.WriteLine("\nAfter sort by part number:");
//		PrintItemsTime (); //print out wateched int times in concole
		GetSortedObjectName(); 
		printOutAppend();

	}

}me [1];
			nameAppend [2] = eachItemsName.name [2];
			nameAppend [3] = eachItemsName.name [3];
			nameAppend [4] = eachItemsName.name [4];
			nameAppend [5] = eachItemsName.name [5];
			nameAppend [6] = eachItemsName.name [6];
			nameAppend [7] = eachItemsName.name [7];
			printOutAppend ();
		}
		//itemsAttribute.Clear();
	}

	void NameAppendList()
	{

	}

	void printOutAppend()
	{
		
		for (int i = 0; i < 8; i++) {
			Debug.Log (nameAppend[i]);	
		}
	
	}


	void Update ()
	{
		//call IntoInt function to change all float numbers into integer
		IntoInt ();
		// add items into list with name and int time number init
		ItemsList ();
		//sort list "items" according to comparer which called from "DetectedItems.cs"
		itemsAttribute.Sort ();
		Console.WriteLine("\nAfter sort by part number:");
//		PrintItemsTime (); //print out wateched int times in concole
		GetSortedObjectName(); 

	}

}