using SanAndreasUnity.Utilities;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListingWindow
{
    public string title;
    public List<ListTitle> titles = new List<ListTitle>();
    public Rect rect;

    private Vector2 scroll = Vector2.zero;
    private ListTitle curTitle, selectedTitle;
    private Texture2D whitePixel, focusTexture;

    private float captionHeight = 0;
    private bool isInit, isCaptionHeightGet;

    public ListingWindow(Rect rect, string title)
    {
        this.rect = rect;
        this.title = title;

        whitePixel = Color.white.ToTexture();
        focusTexture = new Color32(155, 210, 255, 255).ToTexture();
        captionHeight = 25;
    }

    public ListingWindow(string t)
    {
        title = t;
    }

    public void InitGUI()
    {
        if (!isInit)
        {
            //captionHeight = new GUIStyle("label").CalcHeight(new GUIContent("Hello world"), 100);
            //Debug.Log("Caption height: " + captionHeight);

            isInit = true;
        }
    }

    public void OnGUI()
    {
        Event e = Event.current;

        float height = captionHeight * titles.Count + 30;
        Vector2 vector = GUI.BeginScrollView(rect, curTitle == null ? scroll : curTitle.scroll, new Rect(0, 0, rect.width, height));

        if (curTitle == null)
            scroll = vector;
        else
            curTitle.scroll = vector;

        GUI.Box(new Rect(0, 0, rect.width - 5, height - 5), "");
        GUI.Label(new Rect(5, 5, rect.width - 10, rect.height), title, new GUIStyle("label") { fontSize = 10 });
        GUI.DrawTexture(new Rect(5, 5 + 15 + 5, rect.width - 10, 1), whitePixel);

        //int i = 0;

        GUILayout.BeginArea(new Rect(5, 30, rect.width, height));

        if (curTitle == null)
        {
            Display(titles, e, true);
        }
        else
        {
            if (curTitle.contents != null)
                Display(curTitle.contents.Cast<ListTitle>(), e, false);
        }

        GUILayout.EndArea();

        GUI.EndScrollView();
    }

    private void Display(IEnumerable<ListTitle> poly_contents, Event e, bool isTitle)
    {
        GUIStyle style = new GUIStyle("label");
        Rect r = Rect.zero, curRect = Rect.zero;

        if (!isTitle)
        {
            if (GUILayout.Button("..", style))
            {
                style.normal = new GUIStyleState() { textColor = Color.black };
                selectedTitle = null;
            }

            if (selectedTitle != null && style.normal.textColor == Color.black)
                style.normal = new GUIStyleState() { textColor = Color.white };

            r = GUILayoutUtility.GetLastRect();
        }

        curRect = new Rect(r.x, r.y, rect.width, 20);
        bool hover = IsHovering(curRect, e);

        if (!isTitle && hover && Event.current.type == EventType.MouseUp && Event.current.clickCount == 2)
            curTitle = null;

        foreach (ListTitle title in poly_contents)
        { // new Rect(5, 10 + (i + 1) * captionHeight, rect.width - 10, captionHeight)
            bool isSelected = title == selectedTitle,
                 isFirst = titles.First() == title;

            curRect.y = r.y + (isFirst ? 0 : captionHeight);
            hover = IsHovering(curRect, e); // Update current hover bool

            style.normal = new GUIStyleState() { textColor = isSelected ? Color.black : Color.white };

            if (isSelected)
                GUI.DrawTexture(curRect, focusTexture);

            bool isCategory = title is ListCategory;

            // (isTitle && !isCategory ? " + " : (!isTitle && isCategory ? "" : "     " ))

            if (isTitle)
            {
                if (GUILayout.Button(" + " + title.text, style))
                    selectedTitle = title;
            }

            //if (isSelected)
            //    Debug.Log(hover);

            if (hover && Event.current.type == EventType.MouseUp && Event.current.clickCount == 2)
            {
                curTitle = title;
                Debug.LogFormat("Selected title {0}", curTitle.text);
            }

            r = GUILayoutUtility.GetLastRect();
        }
    }

    private bool IsHovering(Rect curRect, Event e)
    {
        return curRect.Contains(e.mousePosition);
    }
}

public class ListTitle
{
    public int index;
    public string text;

    public List<ListCategory> categories;
    public List<ListContent> contents;

    public Vector2 scroll;

    public ListTitle(int i, string t)
    {
        index = i;
        text = t;
    }
}

public class ListCategory : ListTitle
{
    public ListCategory(int i, string t)
        : base(i, t) { }
}

public class ListContent : ListTitle
{
    public ListContent(int i, string t)
        : base(i, t) { }
}