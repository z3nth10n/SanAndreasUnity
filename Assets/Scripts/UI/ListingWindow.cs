using SanAndreasUnity.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListingWindow
{
    public string title;
    public List<ListTitle> titles = new List<ListTitle>();
    public Rect rect;

    private Vector2 scroll = Vector2.zero;
    private ListTitle curTitle, selectedTitle, lastSelectedTitle;
    private Texture2D whitePixel, focusTexture;

    private float captionHeight = 0;
    private bool isInit, isCaptionHeightGet, m_backSelected;

    private Action<ListContent> contentCallback;

    public ListingWindow(Rect rect, string title, Action<ListContent> cc)
    {
        this.rect = rect;
        this.title = title;
        contentCallback = cc;

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

        float height = captionHeight * (curTitle == null ? titles.Count : curTitle.categories.Count + curTitle.contents.Count + captionHeight) + 30;
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
            Display(titles, e, ListingType.Title);
        }
        else
        {
            if (curTitle.contents != null)
                Display(curTitle, e);
        }

        GUILayout.EndArea();

        GUI.EndScrollView();
    }

    private void Display(ListTitle onlyTile, Event e)
    {
        if (onlyTile.contents != null && onlyTile.contents.Count > 0) // Display any content without category
            Display(onlyTile.contents, e, ListingType.Content);

        if(onlyTile.categories != null && onlyTile.contents.Count > 0) // Display any category and its content
            Display(onlyTile.categories, e, ListingType.Category);
    }

    private void Display(IEnumerable<ListTitle> poly_contents, Event e, ListingType type, bool resursive = false)
    {
        bool isTitle = type == ListingType.Title;

        GUIStyle style = new GUIStyle("label");
        Rect r = Rect.zero, curRect = Rect.zero;

        if (!isTitle)
        {
            Rect rr = new Rect(0, 0, rect.width, captionHeight - 6);

            if (m_backSelected)
            {
                GUI.DrawTexture(rr, focusTexture);
                style.normal = new GUIStyleState() { textColor = Color.black };
            }

            if (IsHovering(rr, e) && e.type == EventType.MouseDown && e.clickCount == 2)
                curTitle = null;

            if (GUILayout.Button("...", style))
            {
                selectedTitle = null;
                m_backSelected = true;
            }

            style.normal = new GUIStyleState() { textColor = Color.white };

            r = GUILayoutUtility.GetLastRect();
        }

        curRect = new Rect(r.x, r.y, rect.width, 20);

        foreach (ListTitle title in poly_contents)
        {
            bool isSelected = title == selectedTitle,
                 isFirst = titles.First() == title;

            curRect.y = r.y + (isFirst ? 0 : captionHeight);

            style.normal = new GUIStyleState() { textColor = isSelected ? Color.black : Color.white };

            if (isSelected)
                GUI.DrawTexture(curRect, focusTexture);

            // (isTitle && !isCategory ? " + " : (!isTitle && isCategory ? "" : "     " ))

            if (IsHovering(curRect, e) && e.type == EventType.MouseDown && e.clickCount == 2)
            {
                if (type == ListingType.Title)
                    curTitle = title;
                else
                    contentCallback((ListContent)title);

                Debug.LogFormat("Selected title {0}", curTitle.text);
            }

            if (isTitle)
            {
                if (GUILayout.Button(" + " + title.text, style))
                    selectedTitle = title;
            }
            else
            {
                // Display only first level of titles (without recursivity)
                ListCategory category = type == ListingType.Category ? (ListCategory)title : null;
                ListContent content = type == ListingType.Content ? (ListContent)title : null;

                switch(type)
                {
                    case ListingType.Content:
                        if (GUILayout.Button((resursive ? new string(' ', 5) : "") + content.ToString(), style))
                            selectedTitle = title;
                        break;

                    case ListingType.Category:
                        if (GUILayout.Button(category.text, style))
                            selectedTitle = title;

                        Display(category.contents, e, ListingType.Content, true);
                        break;
                }
            }

            r = GUILayoutUtility.GetLastRect();
        }

        if (selectedTitle != lastSelectedTitle && selectedTitle != null)
            m_backSelected = false;

        lastSelectedTitle = selectedTitle;
    }

    private bool IsHovering(Rect curRect, Event e)
    {
        return curRect.Contains(e.mousePosition);
    }
}

public enum ListingType { Title, Category, Content }

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

        categories = new List<ListCategory>();
        contents = new List<ListContent>();
    }
}

public class ListCategory : ListTitle
{
    public ListCategory(int i, string t)
        : base(i, t) { }
}

public class ListContent : ListTitle
{
    public bool flag1;
    public Func<string> toString;

    public ListContent(int i, string t, Func<string> toString)
        : base(i, t)
    {
        this.toString = toString;
    }

    public override string ToString()
    {
        return toString != null ? toString() : text;
    }
}