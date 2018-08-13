using UnityEngine;
using System;

// example:
// SimpleDialog.MessageBox("error", "Do you want to quit?", () => { Application.Quit() });

public class SimpleDialog : MonoBehaviour
{

    Rect m_windowRect;
    Action m_action;
    string m_title;
    string m_msg;

    public static void MessageBox(string title, string msg, Action action)
    {
        GameObject go = new GameObject("SimpleDialog");
        SimpleDialog dlg = go.AddComponent<SimpleDialog>();
        dlg.Init(title, msg, action);
    }

    void Init(string title, string msg, Action action)
    {
        m_title = title;
        m_msg = msg;
        m_action = action;
    }

    void OnGUI()
    {
        const int maxWidth = 320;
        const int maxHeight = 125;

        int width = Mathf.Min(maxWidth, Screen.width - 20);
        int height = Mathf.Min(maxHeight, Screen.height - 20);

        m_windowRect = new Rect(
            (Screen.width - width) / 2,
            (Screen.height - height) / 2,
            width,
            height);

        m_windowRect = GUI.Window(0, m_windowRect, WindowFunc, m_title);
    }

    void WindowFunc(int windowID)
    {
        GUILayout.BeginArea(new Rect(5, 25, m_windowRect.width - 10, m_windowRect.height - 30));

        GUILayout.Label(m_msg);

        GUILayout.Space(10);

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Yes"))
        {
            Destroy(gameObject);
            m_action();
        }

        GUILayout.Space(10);

        if (GUILayout.Button("No"))
            Destroy(gameObject);

        GUILayout.EndHorizontal();

        GUILayout.EndArea();

    }
}