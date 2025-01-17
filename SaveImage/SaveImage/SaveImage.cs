﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SaveImage
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SaveImage recording.
    /// </summary>
    [TestModule("a1f8f5c8-e0e2-481f-af81-c4935289cae8", ModuleType.Recording, 1)]
    public partial class SaveImage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SaveImageRepository repository.
        /// </summary>
        public static SaveImageRepository repo = SaveImageRepository.Instance;

        static SaveImage instance = new SaveImage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SaveImage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SaveImage Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXAutoRunModeUntitled.SaveImage' at Center.", repo.SnapXAutoRunModeUntitled.SaveImageInfo, new RecordItemIndex(0));
            repo.SnapXAutoRunModeUntitled.SaveImage.Click();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SaveImage.Text1001' at 777;8.", repo.SaveImage.Text1001Info, new RecordItemIndex(1));
            repo.SaveImage.Text1001.DoubleClick("777;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(2));
            repo.SaveImage.Text1001.PressKeys("{Delete}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image'.", new RecordItemIndex(3));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(4));
            repo.SaveImage.Text1001.PressKeys("{Return}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXAutoRunModeUntitled.SaveImage' at Center.", repo.SnapXAutoRunModeUntitled.SaveImageInfo, new RecordItemIndex(5));
            repo.SnapXAutoRunModeUntitled.SaveImage.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(6));
            repo.SaveImage.DropDown.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(7));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(8));
            repo.SaveImage.DropDown.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItemJpegFilesAsteriskJpgAsteri' at 802;6.", repo.List1000.ListItemJpegFilesAsteriskJpgAsteriInfo, new RecordItemIndex(9));
            repo.List1000.ListItemJpegFilesAsteriskJpgAsteri.Click("802;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SaveImage.Text1001' at 777;8.", repo.SaveImage.Text1001Info, new RecordItemIndex(10));
            repo.SaveImage.Text1001.DoubleClick("777;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(11));
            repo.SaveImage.Text1001.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image'.", new RecordItemIndex(12));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(13));
            repo.SaveImage.Text1001.PressKeys("{Return}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXAutoRunModeUntitled.SaveImage' at Center.", repo.SnapXAutoRunModeUntitled.SaveImageInfo, new RecordItemIndex(14));
            repo.SnapXAutoRunModeUntitled.SaveImage.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(15));
            repo.SaveImage.DropDown.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(16));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(17));
            repo.SaveImage.DropDown.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItemTiffFilesAsteriskTifAsteri' at 795;8.", repo.List1000.ListItemTiffFilesAsteriskTifAsteriInfo, new RecordItemIndex(18));
            repo.List1000.ListItemTiffFilesAsteriskTifAsteri.Click("795;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SaveImage.Text1001' at 777;8.", repo.SaveImage.Text1001Info, new RecordItemIndex(19));
            repo.SaveImage.Text1001.DoubleClick("777;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(20));
            repo.SaveImage.Text1001.PressKeys("{Delete}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image'.", new RecordItemIndex(21));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(22));
            repo.SaveImage.Text1001.PressKeys("{Return}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXAutoRunModeUntitled.SaveImage' at Center.", repo.SnapXAutoRunModeUntitled.SaveImageInfo, new RecordItemIndex(23));
            repo.SnapXAutoRunModeUntitled.SaveImage.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(24));
            repo.SaveImage.DropDown.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(25));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(26));
            repo.SaveImage.DropDown.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItemGifFilesAsteriskGif' at 787;8.", repo.List1000.ListItemGifFilesAsteriskGifInfo, new RecordItemIndex(27));
            repo.List1000.ListItemGifFilesAsteriskGif.Click("787;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SaveImage.Text1001' at 777;8.", repo.SaveImage.Text1001Info, new RecordItemIndex(28));
            repo.SaveImage.Text1001.DoubleClick("777;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(29));
            repo.SaveImage.Text1001.PressKeys("{Delete}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image'.", new RecordItemIndex(30));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(31));
            repo.SaveImage.Text1001.PressKeys("{Return}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXAutoRunModeUntitled.SaveImage' at Center.", repo.SnapXAutoRunModeUntitled.SaveImageInfo, new RecordItemIndex(32));
            repo.SnapXAutoRunModeUntitled.SaveImage.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(33));
            repo.SaveImage.DropDown.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(34));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(35));
            repo.SaveImage.DropDown.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItemTargaFilesAsteriskTga' at 789;6.", repo.List1000.ListItemTargaFilesAsteriskTgaInfo, new RecordItemIndex(36));
            repo.List1000.ListItemTargaFilesAsteriskTga.Click("789;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SaveImage.Text1001' at 777;8.", repo.SaveImage.Text1001Info, new RecordItemIndex(37));
            repo.SaveImage.Text1001.DoubleClick("777;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(38));
            repo.SaveImage.Text1001.PressKeys("{Delete}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image'.", new RecordItemIndex(39));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(40));
            repo.SaveImage.Text1001.PressKeys("{Return}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXAutoRunModeUntitled.SaveImage' at Center.", repo.SnapXAutoRunModeUntitled.SaveImageInfo, new RecordItemIndex(41));
            repo.SnapXAutoRunModeUntitled.SaveImage.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(42));
            repo.SaveImage.DropDown.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(43));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(44));
            repo.SaveImage.DropDown.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItemPortableNetworkGraphicsFiles' at 792;7.", repo.List1000.ListItemPortableNetworkGraphicsFilesInfo, new RecordItemIndex(45));
            repo.List1000.ListItemPortableNetworkGraphicsFiles.Click("792;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SaveImage.Text1001' at 777;8.", repo.SaveImage.Text1001Info, new RecordItemIndex(46));
            repo.SaveImage.Text1001.DoubleClick("777;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(47));
            repo.SaveImage.Text1001.PressKeys("{Delete}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image'.", new RecordItemIndex(48));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(49));
            repo.SaveImage.Text1001.PressKeys("{Return}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXAutoRunModeUntitled.SaveImage' at Center.", repo.SnapXAutoRunModeUntitled.SaveImageInfo, new RecordItemIndex(50));
            repo.SnapXAutoRunModeUntitled.SaveImage.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(51));
            repo.SaveImage.DropDown.MoveTo();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(52));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SaveImage.DropDown' at Center.", repo.SaveImage.DropDownInfo, new RecordItemIndex(53));
            repo.SaveImage.DropDown.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItemPDFFilesAsteriskPdf' at 794;7.", repo.List1000.ListItemPDFFilesAsteriskPdfInfo, new RecordItemIndex(54));
            repo.List1000.ListItemPDFFilesAsteriskPdf.Click("794;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SaveImage.Text1001' at 777;8.", repo.SaveImage.Text1001Info, new RecordItemIndex(55));
            repo.SaveImage.Text1001.DoubleClick("777;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(56));
            repo.SaveImage.Text1001.PressKeys("{Delete}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image'.", new RecordItemIndex(57));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationImages\\Reports\\image");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SaveImage.Text1001'.", repo.SaveImage.Text1001Info, new RecordItemIndex(58));
            repo.SaveImage.Text1001.PressKeys("{Return}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXAutoRunModeUntitled.BoxTarget' at Center.", repo.SnapXAutoRunModeUntitled.BoxTargetInfo, new RecordItemIndex(59));
            repo.SnapXAutoRunModeUntitled.BoxTarget.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXAutoRunModeUntitled.SaveImage' at 47;18.", repo.SnapXAutoRunModeUntitled.SaveImageInfo, new RecordItemIndex(60));
            repo.SnapXAutoRunModeUntitled.SaveImage.Click("47;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SNAPX.SaveImageAndTargetAs' at Center.", repo.SNAPX.SaveImageAndTargetAsInfo, new RecordItemIndex(61));
            repo.SNAPX.SaveImageAndTargetAs.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
