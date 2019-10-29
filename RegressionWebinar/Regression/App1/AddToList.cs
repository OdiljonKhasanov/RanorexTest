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

namespace RegressionWebinar.Regression.App1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddToList recording.
    /// </summary>
    [TestModule("c2b47ec3-aa45-4002-ad53-9fa31a9f77b6", ModuleType.Recording, 1)]
    public partial class AddToList : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RegressionWebinar.RegressionWebinarRepository repository.
        /// </summary>
        public static global::RegressionWebinar.RegressionWebinarRepository repo = global::RegressionWebinar.RegressionWebinarRepository.Instance;

        static AddToList instance = new AddToList();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddToList()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddToList Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Category' at Center.", repo.ApplicationUnderTest.CategoryInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Category.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Gender' at Center.", repo.ApplicationUnderTest.GenderInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Gender.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InputTagAdd' at Center.", repo.ApplicationUnderTest.InputTagAddInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.InputTagAdd.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}