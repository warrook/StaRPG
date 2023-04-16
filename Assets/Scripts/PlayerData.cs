using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StaRPG
{
	public static class PlayerData
	{
		public static List<Attribute> Attributes => new List<Attribute>();

		static PlayerData()
		{
			Attributes.Add(new("Athletics", 1f));
			Attributes.Add(new("Knowledge", 1f));
			Attributes.Add(new("Charisma", 1f));
		}
	}
}