﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TYPE_RESOURCES
{
	PEOPLE,
	CASH,
	GOLD,
	HAPPINESS,
	CLEANNESS,

	COUNT
}

public class Airport : MonoBehaviour {
	
	static Airport instance;
	public static Airport Instance
	{
		get{ 
			if(instance == null)
			{
				GameObject obj = new GameObject();
				obj.name = "Airport";
				instance = obj.AddComponent<Airport>();
				instance.InitAirport();
			}
			return instance;
		}
	}

	PackResources userResources;
	List<Building> _buildings =  new List<Building>();
	Dictionary<int,BuildingData> _buildingData = new Dictionary<int, BuildingData>();

	public PackResources UserResources
	{
		set{ userResources = value;} get { return userResources;}
	}

	public List<Building> Buildings
	{
		set{ _buildings = value;} get{ return _buildings;}
	}

	public BuildingData GetBuildingData(int ID)
	{
		if (_buildingData.ContainsKey (ID)) 
		{
			return _buildingData[ID];
		}
		return null;
	}

	public void InitAirport ()
	{
		//Get Player Resources
		userResources.resources = new Dictionary<TYPE_RESOURCES, float> ();
		//Get Player Buildings

	
	}

	public void Save()
	{

	}

	public void RetrieveInfoResources(float dt)
	{
		foreach (Building b in _buildings) 
		{
			userResources = userResources + b.UpdateBuildingResources(dt);
		}

		Save ();
	}

	void Update()
	{
		RetrieveInfoResources (Time.deltaTime);
	}
}
