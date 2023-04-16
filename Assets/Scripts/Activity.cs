using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace StaRPG
{
	[CreateAssetMenu(fileName = "Activity", menuName = "Game")]
	public class Activity : ScriptableObject
	{
		public AttributeStorage Threshold;
		public AttributeStorage RewardAdjustment;

		public Activity(AttributeStorage threshold, AttributeStorage reward)
		{
			Threshold = threshold;
			RewardAdjustment = reward;
		}
	}
}
