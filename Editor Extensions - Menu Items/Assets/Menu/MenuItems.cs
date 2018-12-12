using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class MenuItems : MonoBehaviour {

    // add a new menu and a new menu item
    [MenuItem("Tools/Clear PlayerPrefs")]
    private static void ToolsClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    // add a new menu item under an existing menu
    [MenuItem("Window/New Option")]
    private static void WindowNewOption()
    {

    }

    // add a menu item with multiple levels of nesting
    [MenuItem("Tools/SubMenu/Option")]
    private static void ToolsSubMenuOption()
    {

    }

    // add a new menu item with hotkey CTRL-SHIFT-G
    [MenuItem("Tools/New Option %#g")]
    private static void ToolsNewOption()
    {
        Debug.Log("CTRL-SHIFT-G");
    }

    [MenuItem("Tools/Item %g")]
    private static void ToolsItem()
    {
        Debug.Log("CTRL-G");
    }

    [MenuItem("Tools/Item2 _g")]
    private static void ToolsItem2()
    {
        Debug.Log("G");
    }

    [MenuItem("Assets/Load Additive Scene")]
    private static void LoadAdditiveScene()
    {
        var selected = Selection.activeObject;
        EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(selected),
            OpenSceneMode.Additive);
    }

    [MenuItem("Assets/Create/Add Configuration")]
    private static void AddConfig()
    {
        // Create and add a new ScriptableObject for storing configuration
    }

    [MenuItem("CONTEXT/Rigidbody/New Option")]
    private static void NewOpenForRigidBody(MenuCommand menuCommand)
    {
        // The RigidBody component can be extracted from the menu command using the context field.
        var rigid = menuCommand.context as Rigidbody;
    }

    [MenuItem("Assets/ProcessTexture")]
    private static void DoSomethingWithTexture()
    {

    }

    // Note that we pass the same path, and also pass "true" to the second argument.
    [MenuItem("Assets/ProcessTexture", true)]
    private static bool NewMenuOptionValidation()
    {
        // This returns true when the selected object is a Texture2D (the menu item will be disabled otherwise).
        return Selection.activeObject.GetType() == typeof(Texture2D);
    }

    // Grouped by 50
    [MenuItem("NewMenu/Option1", false, 1)]
    private static void NewMenuOption1()
    {

    }

    [MenuItem("NewMenu/Option2", false, 2)]
    private static void NewMenuOption2()
    {

    }

    [MenuItem("NewMenu/Option3", false, 3)]
    private static void NewMenuOption3()
    {

    }

    [MenuItem("NewMenu/Option4", false, 51)]
    private static void NewMenuOption4()
    {

    }

    [MenuItem("NewMenu/Option5", false, 52)]
    private static void NewMenuOption5()
    {

    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
