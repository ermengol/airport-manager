﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public enum BUILDING_TYPE
{
	FLOOR,
	GATE,
	RESTAURANT,
	POLICE,
	RELAX,
	SHOP,
	COUNT
}

public class BuildingData
{
	BUILDING_TYPE _type;
	PackResources _amountResourcesXMin;
	int _price;
	string _prefabName;

	public BUILDING_TYPE Type{
		get{return _type;}
	}

	public PackResources AmountResourcesXMin
	{
		get{return _amountResourcesXMin;}
	}

	public int Price
	{
		get{return _price;}
	}

	public string PrefabName
	{
		get{return _prefabName;}
	}


	public void ParseBuildingData(string xmlText)
	{

	}
}

//Buildings can give resources happiness, cleanness, security.
//This will translate with flights on increase of people in the airport.
public class Building : MonoBehaviour {

	int buildingID;
	
	public PackResources UpdateBuildingResources(float dt)
	{
		return Airport.Instance.GetBuildingData(buildingID).AmountResourcesXMin * (dt / 60f);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
