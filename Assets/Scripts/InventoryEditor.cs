using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(Inventory))]

public class InventoryEditor : Editor
{
	private bool[] showItemSlots = new bool[Inventory.numItemSlots];
	private SerializedProperty itemImagesProperty;
	private SerializedProperty itemsProperty;
	private const string inventoryPropItemsImagesName = "itemImages";
	private const string inventoryPropItemsName = "items";

	private void OnEnable ()
	{
		itemImagesProperty = serializedObject.FindProperty (inventoryPropItemsImagesName);
		itemsProperty = serializedObject.FindProperty (inventoryPropItemsName);
	}

	public override void OnInspectorGUI ()
	{
		serializedObject.Update ();
		for (int i = 0; i < Inventory.numItemSlots; i++) 
		{
			ItemSlotGUI (i);
		}
		serializedObject.ApplyModifiedProperties ();
	}

	private void ItemSlotGUI (int index)
	{
		EditorGUILayout.BeginVertical (GUI.skin.box);
		EditorGUI.indentLevel++;
	}

}
