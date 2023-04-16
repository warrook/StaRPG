using UnityEditor;
using UnityEngine;

namespace StaRPG
{
	//public class AttributeStorageEditor : ScriptableObject
	//{
	//	[MenuItem("Tools/MyTool/Do It in C#")]
	//	static void DoIt()
	//	{
	//		EditorUtility.DisplayDialog("MyTool", "Do It in C# !", "OK", "");
	//	}
	//}

	[CustomEditor(typeof(AttributeStorage))]
	public class AttributeStorageEditor : Editor
	{
		AttributeStorage storage;
		SerializedProperty testProperty;

		int length = 1;

		private void OnEnable()
		{
			storage = (AttributeStorage)target;
		}

		public override void OnInspectorGUI()
		{
			EditorGUILayout.BeginVertical();
			for (int i = 0; i < length; i++)
			{
				//EditorGUILayout.TextField("Attribute:")
			}
			EditorGUILayout.EndVertical();
			EditorGUILayout.BeginHorizontal();
			length = EditorGUILayout.DelayedIntField("Number of attributes:", length);
			if (GUILayout.Button("+"))
			{
				length++;
			}
			if (GUILayout.Button("-"))
			{
				length--;
				if (length < 0)
					length = 0;
			}
			EditorGUILayout.EndHorizontal();

			EditorUtility.SetDirty(storage);
		}
	}
}