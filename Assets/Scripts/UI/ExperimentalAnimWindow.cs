using SanAndreasUnity.Behaviours;
using System.Linq;
using UnityEngine;

namespace SanAndreasUnity.UI
{
    public class ExperimentalAnimWindow : PauseMenuWindow
    {
        private ListingWindow listingWindow;
        private Vector2 windowSize;

        public ExperimentalAnimWindow()
        {
            // set default parameters

            this.windowName = "Experimental animations";
            this.useScrollView = false;
        }

        private void Start()
        {
            windowSize = new Vector2(490, 375);
            listingWindow = new ListingWindow(new Rect(Vector2.zero, windowSize), "Animations") { titles = AnimationList.CurAnims.Keys.Select((x, i) => new ListTitle(i, x.ToString())).ToList() };

            this.RegisterButtonInPauseMenu();

            // adjust rect
            this.windowRect = Utilities.GUIUtils.GetCenteredRect(new Vector2(500, 400));
        }

        protected override void OnWindowGUI()
        {
            listingWindow.InitGUI();

            bool playerExists = Player.Instance != null;

            GUI.BeginGroup(new Rect(new Vector2(5, 20), windowSize));

            listingWindow.OnGUI();

            GUI.EndGroup();
        }

        protected override void OnWindowOpened()
        {
            Player.Instance.shouldPlayAnims = false;
        }

        protected override void OnWindowClosed()
        {
            Player.Instance.shouldPlayAnims = true;
        }
    }
}