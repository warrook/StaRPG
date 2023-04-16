using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace StaRPG
{
	[Serializable]
	public class AttributeStorage : ScriptableObject
	{
		protected List<Attribute> attributes = new List<Attribute>();

		public AttributeStorage()
		{
			attributes.Add(new(Utils.Labels.AttributeAthletics, 0f));
			attributes.Add(new(Utils.Labels.AttributeKnowledge, 0f));
			attributes.Add(new(Utils.Labels.AttributeCharisma, 0f));
		}

		public AttributeStorage(float[] values)
		{
			attributes.Add(new Attribute(Utils.Labels.AttributeAthletics, (values.Length > 0 ? values[0] : 0f)));
			attributes.Add(new Attribute(Utils.Labels.AttributeKnowledge, (values.Length > 1 ? values[1] : 0f)));
			attributes.Add(new Attribute(Utils.Labels.AttributeCharisma, (values.Length > 2 ? values[2] : 0f)));
		}

		public AttributeStorage(Attribute[] values)
		{
			attributes.AddRange(values);
		}

		public AttributeStorage Increase(AttributeStorage by)
		{
			foreach (var entry in by.attributes)
			{
				attributes.Find(x => x.Name == entry.Name).Increase(entry);
			}
			return this;
		}

		public Attribute Get(string name) => attributes.Find(x => x.Name == name);
		public Attribute GetValue(string name) => attributes.Find(x => x.Name == name);

		public override string ToString()
		{
			return $"[ {string.Join(", ", attributes)} ]";
		}
	}

	public struct Attribute
	{
		string name;
		float value;

		public string Name => name;
		public float Value => value;

		public Attribute(string name, float value)
		{
			this.name = name;
			this.value = value;
		}

		public float Increase(float val)
		{
			value += val;
			if (value < 0)
				value = 0;
			return value;
		}

		public float Increase(Attribute by)
		{
			if (name == by.Name)
			{
				Increase(by.Value);
			}
			else
				Debug.LogWarning($"Tried to add {this} to {by}");

			return value;
		}

		public override string ToString()
		{
			return $"{name} ({value})";
		}
	}
}
