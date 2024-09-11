using BananaOS;
using BananaOS.Pages;
using System.Text;
using UnityEngine;

namespace QuickDisconnectBananaOS
{
    internal class WatchMenu:WatchPage
    {
        public override string Title => "<color=blue>small</color> <color=purple>arms</color>";
        public override bool DisplayOnMainMenu => true;
        public bool IsEnabled;
        
        public override string OnGetScreenContent()
        {
            var BuildMenuOptions = new StringBuilder();
            BuildMenuOptions.AppendLine("<color=blue>small</color> <color=purple>arms</color>");
            BuildMenuOptions.AppendLine("By <color=green>kinda</color> <color=black>monke</color>");
            BuildMenuOptions.AppendLine("By <color=blue>description:</color>");
            BuildMenuOptions.AppendLine("By <color=blue>this mod halfs your arms to make them small</color>");
            BuildMenuOptions.AppendLine(selectionHandler.GetOriginalBananaOSSelectionText(0, "Enabled = " + IsEnabled));
            return BuildMenuOptions.ToString();
        }

        public override void OnButtonPressed(WatchButtonType buttonType)
        {
            switch (buttonType)
            {
                case WatchButtonType.Down:
                    selectionHandler.MoveSelectionDown();
                    break;

                case WatchButtonType.Up:
                    selectionHandler.MoveSelectionUp();
                    break;

                    case WatchButtonType.Enter:
                    if (selectionHandler.currentIndex == 0)
                    {
                        IsEnabled = !IsEnabled;
                        {
                            GameObject.Find("Player VR Controller/GorillaPlayer").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                        }
                    }
                    break;

                case WatchButtonType.Back:
                    ReturnToMainMenu();
                    break;
            }
        }
    }
}
