using System;
using CefSharp;
using System.Windows.Forms;

namespace TribalWars
{
    class CefCustomMenuMain : IContextMenuHandler
    {
        public delegate void NewTab(string url);
        public event NewTab NewTabRequest;
        public void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            model.Clear();
            if(parameters.LinkUrl != string.Empty)
            {
                model.AddItem((CefMenuCommand)26501, "Open in new tab");
            }
            model.AddItem((CefMenuCommand)26502, "Show DevTools");
            model.AddItem((CefMenuCommand)26503, "Close DevTools");
            model.AddSeparator();
            model.AddItem((CefMenuCommand)26504, "Display alert message");
        }

        public bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            // React to the first ID (show dev tools method)
            if (commandId == (CefMenuCommand)26501)
            {
                NewTabRequest?.Invoke(parameters.LinkUrl);
                return true;
            }
            if (commandId == (CefMenuCommand)26502)
            {
                browser.GetHost().ShowDevTools();
                return true;
            }
            // React to the second ID (show dev tools method)
            if (commandId == (CefMenuCommand)26503)
            {
                browser.GetHost().CloseDevTools();
                return true;
            }
            // React to the third ID (Display alert message)
            if (commandId == (CefMenuCommand)26504)
            {
                MessageBox.Show("An example alert message ?");
                return true;
            }
            // Any new item should be handled through a new if statement

            // Return false should ignore the selected option of the user !
            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
        {
            
        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
