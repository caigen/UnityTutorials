using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ComponentContextMenu : MonoBehaviour {

    [ContextMenuItem("Randomize Name", "Randomize")]
    public string Name;

    [MenuItem("CONTEXT/ComponentContextMenu/Reset Name")]
    private static void NewOpenForRigidBody(MenuCommand menuCommand)
    {
        var component = menuCommand.context as ComponentContextMenu;

        component.Name = string.Empty;
    }

    private void Randomize()
    {
        Name = "Some Random Name";
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
