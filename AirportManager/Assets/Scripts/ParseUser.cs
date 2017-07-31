using UnityEngine;
using System.Collections;
using System.Xml;

public class ParseUser {

	public static void Save()
	{

	}

	public static void Load()
	{
		XmlTextReader xmlReader = new XmlTextReader("UserState.xml");

		while (xmlReader.Read()) 
		{
			//if(xmlReader.
		}
	}
}
