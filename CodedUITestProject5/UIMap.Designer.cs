﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject5
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Landscape1 - Use 'Landscape1Params' to pass parameters into this method.
        /// </summary>
        public void Landscape1()
        {
            #region Variable Declarations
            WinButton uICustomersButton = this.UICILandscapeWindow.UIItemButton.UICustomersButton;
            WinButton uISearchButton = this.UICILandscapeWindow.UICustomersButton.UISearchButton;
            WinEdit uITxtQuoteNoEdit = this.UICILandscapeWindow.UIFrmClientWindow.UITxtQuoteNoWindow.UITxtQuoteNoEdit;
            WinButton uISearchButton1 = this.UICILandscapeWindow.UIFrmClientWindow.UISearchWindow.UISearchButton;
            WinTabPage uIQuotes1TabPage = this.UICustomerMrAaaaaTpahdWindow.UITabCustomerWindow.UIQuotes1TabPage;
            WinListItem uIPrivateCarListItem = this.UICustomerMrAaaaaTpahdWindow.UILvwQuotesWindow.UIPrivateCarListItem;
            WinMenuItem uIDocumentStoreMenuItem = this.UIPrivateCarPolicyS218Window.UIPolicyMenuBar.UIDocumentsMenuItem.UIDocumentStoreMenuItem;
            WinButton uICloseButton = this.UIDocumentStoreWindow.UIDocumentStoreTitleBar.UICloseButton;
            WinButton uICloseButton1 = this.UIPrivateCarPolicyS218Window.UIPrivateCarPolicyS218TitleBar.UICloseButton;
            WinButton uICloseButton2 = this.UICustomerMrAaaaaTpahdWindow.UICustomerMrAaaaaTpahdTitleBar.UICloseButton;
            WinButton uICloseButton3 = this.UICILandscapeWindow.UICILandscapeTitleBar.UICloseButton;
            WinButton uIYesButton = this.UICILandscapeWindow1.UIYesWindow.UIYesButton;
            #endregion

            // Launch '\\itliv-nas03\development team\BuildTC\Landscape-Direct-Develop\20180921.707\Release\_GeneratedClient\Landscape.Client\sit\uiMain.exe'
            ApplicationUnderTest uICILandscapeWindow = ApplicationUnderTest.Launch(this.Landscape1Params.UICILandscapeWindowExePath, this.Landscape1Params.UICILandscapeWindowAlternateExePath);

            // The recording for the application under test '\\itliv-nas03\development team\BuildTC\Landscape-Direct-Develop\20180921.707\Release\_GeneratedClient\Landscape.Client\sit\uiMain.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Customers' button
            Mouse.Click(uICustomersButton, new Point(48, 9));

            // Click 'Search' button
            Mouse.Click(uISearchButton, new Point(42, 16));

            //enter the quote Id from properties of Generate Quote
            uITxtQuoteNoEdit.Text = Direct.Properties.Resources.QuoteID2;

            // Click '&Search' button
            Mouse.Click(uISearchButton1, new Point(34, 13));

            // Click 'Quotes (1)' tab
          //  Mouse.Click(uIQuotes1TabPage, new Point(39, 15));

            // Double-Click 'Private Car' list item
            Mouse.DoubleClick(uIPrivateCarListItem, new Point(153, 8));

            // Click 'Documents' -> 'Document Store' menu item
            Mouse.Click(uIDocumentStoreMenuItem, new Point(61, 16));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(37, 8));

            // Click 'Close' button
            Mouse.Click(uICloseButton1, new Point(29, 8));

            // Click 'Close' button
            Mouse.Click(uICloseButton2, new Point(27, 13));

            // Click 'Close' button
            Mouse.Click(uICloseButton3, new Point(30, 4));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(55, 11));
        }
        
        /// <summary>
        /// search - Use 'searchParams' to pass parameters into this method.
        /// </summary>
        public void search()
        {
            #region Variable Declarations
            WinEdit uITxtQuoteNoEdit = this.UICILandscapeWindow.UIFrmClientWindow.UITxtQuoteNoWindow.UITxtQuoteNoEdit;
            WinButton uISearchButton = this.UICILandscapeWindow.UIFrmClientWindow.UISearchWindow.UISearchButton;
            #endregion

            // The recording for the application under test '\\itliv-nas03\development team\BuildTC\Landscape-Direct-Develop\20180921.707\Release\_GeneratedClient\Landscape.Client\sit\uiMain.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '123456' in 'txtQuoteNo' text box
            uITxtQuoteNoEdit.Text = this.searchParams.UITxtQuoteNoEditText;

            // Click '&Search' button
            Mouse.Click(uISearchButton, new Point(27, 10));
        }
        
        #region Properties
        public virtual Landscape1Params Landscape1Params
        {
            get
            {
                if ((this.mLandscape1Params == null))
                {
                    this.mLandscape1Params = new Landscape1Params();
                }
                return this.mLandscape1Params;
            }
        }
        
        public virtual searchParams searchParams
        {
            get
            {
                if ((this.msearchParams == null))
                {
                    this.msearchParams = new searchParams();
                }
                return this.msearchParams;
            }
        }
        
        public UICILandscapeWindow UICILandscapeWindow
        {
            get
            {
                if ((this.mUICILandscapeWindow == null))
                {
                    this.mUICILandscapeWindow = new UICILandscapeWindow();
                }
                return this.mUICILandscapeWindow;
            }
        }
        
        public UICustomerMrAaaaaTpahdWindow UICustomerMrAaaaaTpahdWindow
        {
            get
            {
                if ((this.mUICustomerMrAaaaaTpahdWindow == null))
                {
                    this.mUICustomerMrAaaaaTpahdWindow = new UICustomerMrAaaaaTpahdWindow();
                }
                return this.mUICustomerMrAaaaaTpahdWindow;
            }
        }
        
        public UIPrivateCarPolicyS218Window UIPrivateCarPolicyS218Window
        {
            get
            {
                if ((this.mUIPrivateCarPolicyS218Window == null))
                {
                    this.mUIPrivateCarPolicyS218Window = new UIPrivateCarPolicyS218Window();
                }
                return this.mUIPrivateCarPolicyS218Window;
            }
        }
        
        public UIDocumentStoreWindow UIDocumentStoreWindow
        {
            get
            {
                if ((this.mUIDocumentStoreWindow == null))
                {
                    this.mUIDocumentStoreWindow = new UIDocumentStoreWindow();
                }
                return this.mUIDocumentStoreWindow;
            }
        }
        
        public UICILandscapeWindow1 UICILandscapeWindow1
        {
            get
            {
                if ((this.mUICILandscapeWindow1 == null))
                {
                    this.mUICILandscapeWindow1 = new UICILandscapeWindow1();
                }
                return this.mUICILandscapeWindow1;
            }
        }
        #endregion
        
        #region Fields
        private Landscape1Params mLandscape1Params;
        
        private searchParams msearchParams;
        
        private UICILandscapeWindow mUICILandscapeWindow;
        
        private UICustomerMrAaaaaTpahdWindow mUICustomerMrAaaaaTpahdWindow;
        
        private UIPrivateCarPolicyS218Window mUIPrivateCarPolicyS218Window;
        
        private UIDocumentStoreWindow mUIDocumentStoreWindow;
        
        private UICILandscapeWindow1 mUICILandscapeWindow1;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Landscape1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class Landscape1Params
    {
        
        #region Fields
        /// <summary>
        /// Launch '\\itliv-nas03\development team\BuildTC\Landscape-Direct-Develop\20180921.707\Release\_GeneratedClient\Landscape.Client\sit\uiMain.exe'
        /// </summary>
        public string UICILandscapeWindowExePath = "\\\\itliv-nas03\\development team\\BuildTC\\Landscape-Direct-Develop\\20180921.707\\Rele" +
            "ase\\_GeneratedClient\\Landscape.Client\\sit\\uiMain.exe";
        
        /// <summary>
        /// Launch '\\itliv-nas03\development team\BuildTC\Landscape-Direct-Develop\20180921.707\Release\_GeneratedClient\Landscape.Client\sit\uiMain.exe'
        /// </summary>
        public string UICILandscapeWindowAlternateExePath = "\\\\itliv-nas03\\development team\\BuildTC\\Landscape-Direct-Develop\\20180921.707\\Rele" +
            "ase\\_GeneratedClient\\Landscape.Client\\sit\\uiMain.exe";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'search'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class searchParams
    {
        
        #region Fields
        /// <summary>
        /// Type '123456' in 'txtQuoteNo' text box
        /// </summary>
        public string UITxtQuoteNoEditText = "123456";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICILandscapeWindow : WinWindow
    {
        
        public UICILandscapeWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "CI Landscape";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("CI Landscape");
            #endregion
        }
        
        #region Properties
        public UIItemButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new UIItemButton(this);
                }
                return this.mUIItemButton;
            }
        }
        
        public UICustomersButton UICustomersButton
        {
            get
            {
                if ((this.mUICustomersButton == null))
                {
                    this.mUICustomersButton = new UICustomersButton(this);
                }
                return this.mUICustomersButton;
            }
        }
        
        public UIFrmClientWindow UIFrmClientWindow
        {
            get
            {
                if ((this.mUIFrmClientWindow == null))
                {
                    this.mUIFrmClientWindow = new UIFrmClientWindow(this);
                }
                return this.mUIFrmClientWindow;
            }
        }
        
        public UICILandscapeTitleBar UICILandscapeTitleBar
        {
            get
            {
                if ((this.mUICILandscapeTitleBar == null))
                {
                    this.mUICILandscapeTitleBar = new UICILandscapeTitleBar(this);
                }
                return this.mUICILandscapeTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIItemButton mUIItemButton;
        
        private UICustomersButton mUICustomersButton;
        
        private UIFrmClientWindow mUIFrmClientWindow;
        
        private UICILandscapeTitleBar mUICILandscapeTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemButton : WinButton
    {
        
        public UIItemButton(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("CI Landscape");
            #endregion
        }
        
        #region Properties
        public WinButton UICustomersButton
        {
            get
            {
                if ((this.mUICustomersButton == null))
                {
                    this.mUICustomersButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICustomersButton.SearchProperties[WinButton.PropertyNames.Name] = "Customers";
                    this.mUICustomersButton.WindowTitles.Add("CI Landscape");
                    #endregion
                }
                return this.mUICustomersButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICustomersButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICustomersButton : WinButton
    {
        
        public UICustomersButton(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinButton.PropertyNames.Name] = "Customers";
            this.WindowTitles.Add("CI Landscape");
            #endregion
        }
        
        #region Properties
        public WinButton UISearchButton
        {
            get
            {
                if ((this.mUISearchButton == null))
                {
                    this.mUISearchButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISearchButton.SearchProperties[WinButton.PropertyNames.Name] = "Search";
                    this.mUISearchButton.WindowTitles.Add("CI Landscape");
                    #endregion
                }
                return this.mUISearchButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISearchButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIFrmClientWindow : WinWindow
    {
        
        public UIFrmClientWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "frmClient";
            this.WindowTitles.Add("CI Landscape");
            #endregion
        }
        
        #region Properties
        public UITxtQuoteNoWindow UITxtQuoteNoWindow
        {
            get
            {
                if ((this.mUITxtQuoteNoWindow == null))
                {
                    this.mUITxtQuoteNoWindow = new UITxtQuoteNoWindow(this);
                }
                return this.mUITxtQuoteNoWindow;
            }
        }
        
        public UISearchWindow UISearchWindow
        {
            get
            {
                if ((this.mUISearchWindow == null))
                {
                    this.mUISearchWindow = new UISearchWindow(this);
                }
                return this.mUISearchWindow;
            }
        }
        #endregion
        
        #region Fields
        private UITxtQuoteNoWindow mUITxtQuoteNoWindow;
        
        private UISearchWindow mUISearchWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITxtQuoteNoWindow : WinWindow
    {
        
        public UITxtQuoteNoWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtQuoteNo";
            this.WindowTitles.Add("CI Landscape");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtQuoteNoEdit
        {
            get
            {
                if ((this.mUITxtQuoteNoEdit == null))
                {
                    this.mUITxtQuoteNoEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtQuoteNoEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Policy Number";
                    this.mUITxtQuoteNoEdit.WindowTitles.Add("CI Landscape");
                    #endregion
                }
                return this.mUITxtQuoteNoEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtQuoteNoEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISearchWindow : WinWindow
    {
        
        public UISearchWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "cmdSearch";
            this.WindowTitles.Add("CI Landscape");
            #endregion
        }
        
        #region Properties
        public WinButton UISearchButton
        {
            get
            {
                if ((this.mUISearchButton == null))
                {
                    this.mUISearchButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISearchButton.SearchProperties[WinButton.PropertyNames.Name] = "Search";
                    this.mUISearchButton.WindowTitles.Add("CI Landscape");
                    #endregion
                }
                return this.mUISearchButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISearchButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICILandscapeTitleBar : WinTitleBar
    {
        
        public UICILandscapeTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("CI Landscape");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("CI Landscape");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICustomerMrAaaaaTpahdWindow : WinWindow
    {
        
        public UICustomerMrAaaaaTpahdWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Customer - Mr Aaaaa  Tpahdrimq";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Customer - Mr Aaaaa  Tpahdrimq");
            #endregion
        }
        
        #region Properties
        public UITabCustomerWindow UITabCustomerWindow
        {
            get
            {
                if ((this.mUITabCustomerWindow == null))
                {
                    this.mUITabCustomerWindow = new UITabCustomerWindow(this);
                }
                return this.mUITabCustomerWindow;
            }
        }
        
        public UILvwQuotesWindow UILvwQuotesWindow
        {
            get
            {
                if ((this.mUILvwQuotesWindow == null))
                {
                    this.mUILvwQuotesWindow = new UILvwQuotesWindow(this);
                }
                return this.mUILvwQuotesWindow;
            }
        }
        
        public UICustomerMrAaaaaTpahdTitleBar UICustomerMrAaaaaTpahdTitleBar
        {
            get
            {
                if ((this.mUICustomerMrAaaaaTpahdTitleBar == null))
                {
                    this.mUICustomerMrAaaaaTpahdTitleBar = new UICustomerMrAaaaaTpahdTitleBar(this);
                }
                return this.mUICustomerMrAaaaaTpahdTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UITabCustomerWindow mUITabCustomerWindow;
        
        private UILvwQuotesWindow mUILvwQuotesWindow;
        
        private UICustomerMrAaaaaTpahdTitleBar mUICustomerMrAaaaaTpahdTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITabCustomerWindow : WinWindow
    {
        
        public UITabCustomerWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "tabCustomer";
            this.WindowTitles.Add("Customer - Mr Aaaaa  Tpahdrimq");
            #endregion
        }
        
        #region Properties
        public WinTabPage UIQuotes1TabPage
        {
            get
            {
                if ((this.mUIQuotes1TabPage == null))
                {
                    this.mUIQuotes1TabPage = new WinTabPage(this);
                    #region Search Criteria
                    this.mUIQuotes1TabPage.SearchProperties[WinTabPage.PropertyNames.Name] = "Quotes (1)";
                    this.mUIQuotes1TabPage.WindowTitles.Add("Customer - Mr Aaaaa  Tpahdrimq");
                    #endregion
                }
                return this.mUIQuotes1TabPage;
            }
        }
        #endregion
        
        #region Fields
        private WinTabPage mUIQuotes1TabPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UILvwQuotesWindow : WinWindow
    {
        
        public UILvwQuotesWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "lvwQuotes";
            this.WindowTitles.Add("Customer - Mr Aaaaa  Tpahdrimq");
            #endregion
        }
        
        #region Properties
        public WinListItem UIPrivateCarListItem
        {
            get
            {
                if ((this.mUIPrivateCarListItem == null))
                {
                    this.mUIPrivateCarListItem = new WinListItem(this);
                    #region Search Criteria
                    this.mUIPrivateCarListItem.SearchProperties[WinListItem.PropertyNames.Name] = "Private Car";
                    this.mUIPrivateCarListItem.WindowTitles.Add("Customer - Mr Aaaaa  Tpahdrimq");
                    #endregion
                }
                return this.mUIPrivateCarListItem;
            }
        }
        #endregion
        
        #region Fields
        private WinListItem mUIPrivateCarListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICustomerMrAaaaaTpahdTitleBar : WinTitleBar
    {
        
        public UICustomerMrAaaaaTpahdTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Customer - Mr Aaaaa  Tpahdrimq");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Customer - Mr Aaaaa  Tpahdrimq");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIPrivateCarPolicyS218Window : WinWindow
    {
        
        public UIPrivateCarPolicyS218Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Private Car Policy - S2/18267/002FV - (Quote Reference - S2/18267/002FV) : (Web Q" +
                "uote ID - S2/18267/002FV)";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Private Car Policy - S2/18267/002FV - (Quote Reference - S2/18267/002FV) : (Web Q" +
                    "uote ID - S2/18267/002FV)");
            #endregion
        }
        
        #region Properties
        public UIPolicyMenuBar UIPolicyMenuBar
        {
            get
            {
                if ((this.mUIPolicyMenuBar == null))
                {
                    this.mUIPolicyMenuBar = new UIPolicyMenuBar(this);
                }
                return this.mUIPolicyMenuBar;
            }
        }
        
        public UIPrivateCarPolicyS218TitleBar UIPrivateCarPolicyS218TitleBar
        {
            get
            {
                if ((this.mUIPrivateCarPolicyS218TitleBar == null))
                {
                    this.mUIPrivateCarPolicyS218TitleBar = new UIPrivateCarPolicyS218TitleBar(this);
                }
                return this.mUIPrivateCarPolicyS218TitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIPolicyMenuBar mUIPolicyMenuBar;
        
        private UIPrivateCarPolicyS218TitleBar mUIPrivateCarPolicyS218TitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIPolicyMenuBar : WinMenuBar
    {
        
        public UIPolicyMenuBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "DotNetBar Bar";
            this.WindowTitles.Add("Private Car Policy - S2/18267/002FV - (Quote Reference - S2/18267/002FV) : (Web Q" +
                    "uote ID - S2/18267/002FV)");
            #endregion
        }
        
        #region Properties
        public UIDocumentsMenuItem UIDocumentsMenuItem
        {
            get
            {
                if ((this.mUIDocumentsMenuItem == null))
                {
                    this.mUIDocumentsMenuItem = new UIDocumentsMenuItem(this);
                }
                return this.mUIDocumentsMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIDocumentsMenuItem mUIDocumentsMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDocumentsMenuItem : WinMenuItem
    {
        
        public UIDocumentsMenuItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Documents";
            this.WindowTitles.Add("Private Car Policy - S2/18267/002FV - (Quote Reference - S2/18267/002FV) : (Web Q" +
                    "uote ID - S2/18267/002FV)");
            #endregion
        }
        
        #region Properties
        public WinMenuItem UIDocumentStoreMenuItem
        {
            get
            {
                if ((this.mUIDocumentStoreMenuItem == null))
                {
                    this.mUIDocumentStoreMenuItem = new WinMenuItem(this);
                    #region Search Criteria
                    this.mUIDocumentStoreMenuItem.SearchProperties[WinMenuItem.PropertyNames.Name] = "Document Store";
                    this.mUIDocumentStoreMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIDocumentStoreMenuItem.WindowTitles.Add("Private Car Policy - S2/18267/002FV - (Quote Reference - S2/18267/002FV) : (Web Q" +
                            "uote ID - S2/18267/002FV)");
                    #endregion
                }
                return this.mUIDocumentStoreMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WinMenuItem mUIDocumentStoreMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIPrivateCarPolicyS218TitleBar : WinTitleBar
    {
        
        public UIPrivateCarPolicyS218TitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Private Car Policy - S2/18267/002FV - (Quote Reference - S2/18267/002FV) : (Web Q" +
                    "uote ID - S2/18267/002FV)");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Private Car Policy - S2/18267/002FV - (Quote Reference - S2/18267/002FV) : (Web Q" +
                            "uote ID - S2/18267/002FV)");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDocumentStoreWindow : WinWindow
    {
        
        public UIDocumentStoreWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Document Store";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Document Store");
            #endregion
        }
        
        #region Properties
        public UIDocumentStoreTitleBar UIDocumentStoreTitleBar
        {
            get
            {
                if ((this.mUIDocumentStoreTitleBar == null))
                {
                    this.mUIDocumentStoreTitleBar = new UIDocumentStoreTitleBar(this);
                }
                return this.mUIDocumentStoreTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIDocumentStoreTitleBar mUIDocumentStoreTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDocumentStoreTitleBar : WinTitleBar
    {
        
        public UIDocumentStoreTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Document Store");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Document Store");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICILandscapeWindow1 : WinWindow
    {
        
        public UICILandscapeWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "CI Landscape";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("CI Landscape");
            #endregion
        }
        
        #region Properties
        public UIYesWindow UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIYesWindow(this);
                }
                return this.mUIYesWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIYesWindow mUIYesWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIYesWindow : WinWindow
    {
        
        public UIYesWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("CI Landscape");
            #endregion
        }
        
        #region Properties
        public WinButton UIYesButton
        {
            get
            {
                if ((this.mUIYesButton == null))
                {
                    this.mUIYesButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIYesButton.SearchProperties[WinButton.PropertyNames.Name] = "Yes";
                    this.mUIYesButton.WindowTitles.Add("CI Landscape");
                    #endregion
                }
                return this.mUIYesButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIYesButton;
        #endregion
    }
}
