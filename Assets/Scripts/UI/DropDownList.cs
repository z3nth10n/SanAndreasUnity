/* Usage:
 * Add script to an object in the game.
 * root = the transform of 
 * dropSkin = the GUISkin used to set the look of your list.
 *    The GUISkin must contain 3 Custom Styles for each level of the Hierarchy
 *      Element 0 = the settings for element with children
 *      Element 1 = the settings for element with no children
 *      Element 3 = the settings for selected element with children
*//////////////////////////////////////////////////////////////////////////
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class DropDownList
{
    private Rect DropDownRect;          // Size and Location for drop down
    private Transform currentRoot;      // selected object transform
    private Vector2 ListScrollPos;      // scroll list position
    public string selectedItemCaption;  // name of selected item
    private string lastCaption;         // last selected item
    private int guiWidth;               // width of drop list
    private int guiHight;               // hight of drop list
    private bool textChanged;           // if text in text box has changed look for item
    private bool clearDropList;         // clear text box
    public bool DropdownVisible;        // show drop down list
    public bool updateInfo;             // update info window

    //public Transform root;              // top of the Hierarchy
    public GUISkin dropSkin;            // GUISkin for drop down list
    public int itemtSelected;           // index of selected item
    public bool targetChange;           // text in text box was changed, update list

    public class GuiListItem        //The class that contains our list items 
    {
        public string Name;         // name of the item
        public int GuiStyle;        // current style to use
        public int UnSelectedStyle; // unselected GUI style
        public int SelectedStyle;   // selected GUI style
        public int Depth;           // depth in the Hierarchy
        public bool Selected;       // if the item is selected
        public bool ToggleChildren; // show child objects in list

        // constructors 
        public GuiListItem(bool mSelected, string mName, int iGuiStyle, bool childrenOn, int depth)
        {
            Selected = mSelected;
            Name = mName;
            GuiStyle = iGuiStyle;
            ToggleChildren = childrenOn;
            Depth = depth;
            UnSelectedStyle = 0;
            SelectedStyle = 0;

        }
        public GuiListItem(bool mSelected, string mName)
        {
            Selected = mSelected;
            Name = mName;
            GuiStyle = 0;
            ToggleChildren = true;
            Depth = 0;
            UnSelectedStyle = 0;
            SelectedStyle = 0;
        }
        public GuiListItem(string mName)
        {
            Selected = false;
            Name = mName;
            GuiStyle = 0;
            ToggleChildren = true;
            Depth = 0;
            UnSelectedStyle = 0;
            SelectedStyle = 0;
        }

        // Accessors
        public void enable()// don't show in list
        {
            Selected = true;
        }
        public void disable()// show in list
        {
            Selected = false;
        }
        public void setStlye(int stlye)
        {
            GuiStyle = stlye;
        }
        public void setToggleChildren(bool childrenOn)
        {
            ToggleChildren = childrenOn;
        }
        public void setDepth(int depth)
        {
            Depth = depth;
        }
        public void SetStyles(int unSelected, int selected)
        {
            UnSelectedStyle = unSelected;
            SelectedStyle = selected;
        }
    }

    //Declare our list of stuff 
    public List<GuiListItem> MyListOfStuff;

    // Initialization
    public DropDownList()
    {
        guiWidth = 400;
        guiHight = 28;
        // Manually position our list, because the dropdown will appear over other controls 
        DropDownRect = new Rect(10, 10, guiWidth, guiHight);
        DropdownVisible = false;
        itemtSelected = -1;
        targetChange = false;
        lastCaption = selectedItemCaption = "Select a Part...";

        //if (!root)
        //    root = gameObject.transform;

        MyListOfStuff = new List<GuiListItem>(); //Initialize our list of stuff 
        // fill the list
        BuildList(root);
        // set GUI for each item in list
        SetupGUISetting();
        // fill the list
        FillList(root);
    }

    void OnGUI()
    {
        //Show the dropdown list if required (make sure any controls that should appear behind the list are before this block) 
        if (DropdownVisible)
        {
            GUI.SetNextControlName("ScrollView");
            GUILayout.BeginArea(new Rect(DropDownRect.xMin, DropDownRect.yMin + DropDownRect.height, guiWidth, Screen.height * .25f), "", "box");
            ListScrollPos = GUILayout.BeginScrollView(ListScrollPos, dropSkin.scrollView);
            GUILayout.BeginVertical(GUILayout.Width(120));

            for (int i = 0; i < MyListOfStuff.Count; i++)
            {
                if (MyListOfStuff[i].Selected && GUILayout.Button(MyListOfStuff[i].Name, dropSkin.customStyles[MyListOfStuff[i].GuiStyle]))
                {
                    HandleSelectedButton(i);
                }
            }
            GUILayout.EndVertical();
            GUILayout.EndScrollView();
            GUILayout.EndArea();
        }
        //Draw the dropdown control 
        GUILayout.BeginArea(DropDownRect, "", "box");
        GUILayout.BeginHorizontal();
        string ButtonText = (DropdownVisible) ? "<<" : ">>";
        DropdownVisible = GUILayout.Toggle(DropdownVisible, ButtonText, "button", GUILayout.Width(32), GUILayout.Height(20));
        GUI.SetNextControlName("PartSelect");
        selectedItemCaption = GUILayout.TextField(selectedItemCaption);
        clearDropList = GUILayout.Toggle(clearDropList, "Clear", "button", GUILayout.Width(40), GUILayout.Height(20));
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }

    void Update()
    {
        //check if text box info changed
        if (selectedItemCaption != lastCaption)
        {
            textChanged = true;
        }

        // if text box info changed look for part matching text
        if (textChanged)
        {
            lastCaption = selectedItemCaption;
            textChanged = false;
            // go though list to find item
            for (int i = 0; i < MyListOfStuff.Count; ++i)
            {
                if (MyListOfStuff[i].Name.StartsWith(selectedItemCaption, System.StringComparison.CurrentCultureIgnoreCase))
                {

                    MyListOfStuff[i].enable();
                    MyListOfStuff[i].ToggleChildren = false;
                    MyListOfStuff[i].GuiStyle = MyListOfStuff[i].UnSelectedStyle;
                }
                else
                {
                    MyListOfStuff[i].disable();
                    MyListOfStuff[i].ToggleChildren = false;
                    MyListOfStuff[i].GuiStyle = MyListOfStuff[i].UnSelectedStyle;
                }
            }


            for (int i = 0; i < MyListOfStuff.Count; ++i)
            {
                // check list for item
                int test = string.Compare(selectedItemCaption, MyListOfStuff[i].Name, true);
                if (test == 0)
                {
                    itemtSelected = i;
                    targetChange = true;
                    break; // stop looking when found
                }
            }
        }

        // reset message if list closed and text box is empty
        if (selectedItemCaption == "" && !DropdownVisible)
        {
            lastCaption = selectedItemCaption = "Select a Part...";
            ClearList(root);
            FillList(root);
        }

        // if Clear button pushed
        if (clearDropList)
        {
            clearDropList = false;
            selectedItemCaption = "";
        }
    }


    public void HandleSelectedButton(int selection)
    {
        // do the stuff, camera etc
        itemtSelected = selection;//Set the index for our currently selected item 
        updateInfo = true;
        selectedItemCaption = MyListOfStuff[selection].Name;
        currentRoot = GameObject.Find(MyListOfStuff[itemtSelected].Name).transform;

        // toggle item show child
        MyListOfStuff[selection].ToggleChildren = !MyListOfStuff[selection].ToggleChildren;

        lastCaption = selectedItemCaption;
        // fill my drop down list with the children of the current selected object
        if (!MyListOfStuff[selection].ToggleChildren)
        {
            if (currentRoot.childCount > 0)
            {
                MyListOfStuff[selection].GuiStyle = MyListOfStuff[selection].SelectedStyle;
            }
            FillList(currentRoot);
        }
        else
        {
            if (currentRoot.childCount > 0)
            {
                MyListOfStuff[selection].GuiStyle = MyListOfStuff[selection].UnSelectedStyle;
            }
            ClearList(currentRoot);
        }
        targetChange = true;


    }

    // show only items that are the root and its children
    public void FillList(Transform root)
    {
        foreach (Transform child in root)
        {
            for (int i = 0; i < MyListOfStuff.Count; ++i)
            {
                if (MyListOfStuff[i].Name == child.name)
                {
                    MyListOfStuff[i].enable();
                    MyListOfStuff[i].ToggleChildren = false;
                    MyListOfStuff[i].GuiStyle = MyListOfStuff[i].UnSelectedStyle;
                }
            }
        }
    }
    // turn off children objects
    public void ClearList(Transform root)
    {
        //Debug.Log(root.name);
        Transform[] childs = root.GetComponentsInChildren<Transform>();
        foreach (Transform child in childs)
        {
            for (int i = 0; i < MyListOfStuff.Count; ++i)
            {
                if (MyListOfStuff[i].Name == child.name && MyListOfStuff[i].Name != root.name)
                {
                    MyListOfStuff[i].disable();
                    MyListOfStuff[i].ToggleChildren = false;
                    MyListOfStuff[i].GuiStyle = MyListOfStuff[i].UnSelectedStyle;
                }
            }
        }
    }

    // recursively build the list so the hierarchy is in tact
    void BuildList(Transform root)
    {
        // for every object in the thing we are viewing
        foreach (Transform child in root)
        {
            // add the item
            MyListOfStuff.Add(new GuiListItem(false, child.name));
            // if it has children add the children
            if (child.childCount > 0)
            {
                BuildList(child);
            }
        }
    }

    public void ResetDropDownList()
    {
        selectedItemCaption = "";
        ClearList(root);
        FillList(root);
    }

    public string RemoveNumbers(string key)
    {
        return Regex.Replace(key, @"\d", "");
    }

    // sets the drop list elements to use the correct GUI skin custom style
    private void SetupGUISetting()
    {
        // set drop down list gui
        int depth = 0;
        // check all the parts for hierarchy depth
        for (int i = 0; i < MyListOfStuff.Count; ++i)
        {
            GameObject currentObject = GameObject.Find(MyListOfStuff[i].Name);
            Transform currentTransform = currentObject.transform;
            depth = 0;

            if (currentObject.transform.parent == root) // if under root
            {
                if (currentObject.transform.childCount > 0)
                {
                    MyListOfStuff[i].GuiStyle = depth;
                    MyListOfStuff[i].UnSelectedStyle = depth;
                    MyListOfStuff[i].SelectedStyle = depth + 2;
                }
                else
                {
                    MyListOfStuff[i].GuiStyle = depth + 1;
                    MyListOfStuff[i].UnSelectedStyle = depth + 1;
                    MyListOfStuff[i].SelectedStyle = depth + 1;
                }

                MyListOfStuff[i].Depth = depth;

            }
            else // if not under root find depth
            {
                while (currentTransform.parent != root)
                {
                    ++depth;
                    currentTransform = currentTransform.parent;
                }
                MyListOfStuff[i].Depth = depth;
                // set gui basied on depth
                if (currentObject.transform.childCount > 0)
                {
                    MyListOfStuff[i].GuiStyle = depth * 3;
                    MyListOfStuff[i].UnSelectedStyle = depth * 3;
                    MyListOfStuff[i].SelectedStyle = (depth * 3) + 2;
                }
                else
                {
                    MyListOfStuff[i].GuiStyle = depth * 3 + 1;
                    MyListOfStuff[i].UnSelectedStyle = depth * 3 + 1;
                    MyListOfStuff[i].SelectedStyle = depth * 3 + 1;
                }
            }
        }
    }
}