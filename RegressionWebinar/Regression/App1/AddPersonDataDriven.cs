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
    ///The AddPersonDataDriven recording.
    /// </summary>
    [TestModule("572c6fe1-af8f-4256-a202-0a5034c5d823", ModuleType.Recording, 1)]
    public partial class AddPersonDataDriven : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::RegressionWebinar.RegressionWebinarRepository repository.
        /// </summary>
        public static global::RegressionWebinar.RegressionWebinarRepository repo = global::RegressionWebinar.RegressionWebinarRepository.Instance;

        static AddPersonDataDriven instance = new AddPersonDataDriven();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddPersonDataDriven()
        {
            varFirstName = "firstName";
            varLastName = "lastName";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddPersonDataDriven Instance
        {
            get { return instance; }
        }

#region Variables

        string _varFirstName;

        /// <summary>
        /// Gets or sets the value of variable varFirstName.
        /// </summary>
        [TestVariable("ce1ebcb5-477d-444b-97a2-500ea1f29527")]
        public string varFirstName
        {
            get { return _varFirstName; }
            set { _varFirstName = value; }
        }

        string _varLastName;

        /// <summary>
        /// Gets or sets the value of variable varLastName.
        /// </summary>
        [TestVariable("2c3579ae-47e5-4cb9-b1c2-f791873b9252")]
        public string varLastName
        {
            get { return _varLastName; }
            set { _varLastName = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FirstName' at Center.", repo.ApplicationUnderTest.FirstNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.FirstName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varFirstName' with focus on 'ApplicationUnderTest.FirstName'.", repo.ApplicationUnderTest.FirstNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.FirstName.PressKeys(varFirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LastName' at Center.", repo.ApplicationUnderTest.LastNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LastName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varLastName' with focus on 'ApplicationUnderTest.LastName'.", repo.ApplicationUnderTest.LastNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.LastName.PressKeys(varLastName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
