using NUnit.Framework;
using System;
using System.Drawing;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core;
using FlaUI.UIA3;
using FlaUI.Core.Conditions;
using FlaUI.Core.WindowsAPI;
using System.Threading;
using FlaUI.Core.Tools;
using System.Diagnostics;

namespace FlaUITests
{
    public class Tests
    {
        [Test]
        public void AutorizationAdmin()   //����������� �� ��������������
        {
            var application = Application.Launch(@"G:\������\�������\������� �#\��� ��������\Marathon\Marathon\bin\Debug\Marathon.exe");
            var window = application.GetMainWindow(new UIA3Automation());

            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            window.FindFirstDescendant(cf.ByAutomationId("textBoxLogin")).AsTextBox().Enter("ad");
            window.FindFirstDescendant(cf.ByAutomationId("textBoxPassword")).AsTextBox().Enter("ad");
            window.FindFirstDescendant(cf.ByAutomationId("buttonEntry")).AsButton().Click();

            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);
            application.Close();
        }

        [Test]
        public void AutorizationAdminAndAddAcc()    //����������� �� �������������� � ���������� � ������ ������ �������� ������ 
        {
            UIA3Automation automation = new UIA3Automation();
            var application = Application.Launch(@"G:\������\�������\������� �#\��� ��������\Marathon\Marathon\bin\Debug\Marathon.exe");
            var window = application.GetMainWindow(automation);

            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            window.FindFirstDescendant(cf.ByAutomationId("textBoxLogin")).AsTextBox().Enter("ad");
            window.FindFirstDescendant(cf.ByAutomationId("textBoxPassword")).AsTextBox().Enter("ad");
            window.FindFirstDescendant(cf.ByAutomationId("buttonEntry")).AsButton().Click();
            Keyboard.Type(VirtualKeyShort.ENTER);

            window = automation.GetDesktop().AsWindow();

            window.FindFirstDescendant(cf.ByAutomationId("buttonWorkAccounts")).AsButton().Click();
            window.FindFirstDescendant(cf.ByAutomationId("buttonReg")).AsButton().Click();
            window.FindFirstDescendant(cf.ByAutomationId("textBoxLog")).AsTextBox().Enter("runner@runner.ru");
            window.FindFirstDescendant(cf.ByAutomationId("textBoxPas")).AsTextBox().Enter("runner");
            window.FindFirstDescendant(cf.ByAutomationId("buttonEnter")).AsButton().Click();

            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);

            application.Close();
        }

        [Test]
        public void AutorizationSponsor()    //����������� �� ��������
        {
            var application = Application.Launch(@"G:\������\�������\������� �#\��� ��������\Marathon\Marathon\bin\Debug\Marathon.exe");
            var window = application.GetMainWindow(new UIA3Automation());

            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            window.FindFirstDescendant(cf.ByAutomationId("textBoxLogin")).AsTextBox().Enter("sp@ons.or");
            window.FindFirstDescendant(cf.ByAutomationId("textBoxPassword")).AsTextBox().Enter("sp");
            window.FindFirstDescendant(cf.ByAutomationId("buttonEntry")).AsButton().Click();

            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);
            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);
            application.Close();
        }

        [Test]
        public void AutorizationSponsorAndSponsRunner()       //����������� �� �������� � ������������� �������� � ������ ������
        {
            UIA3Automation automation = new UIA3Automation();
            var application = Application.Launch(@"G:\������\�������\������� �#\��� ��������\Marathon\Marathon\bin\Debug\Marathon.exe");
            var window = application.GetMainWindow(automation);

            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            window.FindFirstDescendant(cf.ByAutomationId("textBoxLogin")).AsTextBox().Enter("sp@ons.or");
            window.FindFirstDescendant(cf.ByAutomationId("textBoxPassword")).AsTextBox().Enter("sp");
            window.FindFirstDescendant(cf.ByAutomationId("buttonEntry")).AsButton().Click();

            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);
            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);

            window = automation.GetDesktop().AsWindow();

            window.FindFirstDescendant(cf.ByAutomationId("buttonSponsRun")).AsButton().Click();

            window = application.GetMainWindow(automation);

            window.FindFirstDescendant(cf.ByAutomationId("comboBoxRunners")).AsComboBox().Select(2).Click();
            window.FindFirstDescendant(cf.ByAutomationId("buttonPlus")).AsButton().Click();
            window.FindFirstDescendant(cf.ByAutomationId("buttonPlus")).AsButton().Click();
            window.FindFirstDescendant(cf.ByAutomationId("buttonPlus")).AsButton().Click();
            window.FindFirstDescendant(cf.ByAutomationId("buttonSponsRun")).AsButton().Click();

            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);

            application.Close();
        }

        [Test]
        public void AutorizationRunner()        //����������� �� ������
        {
            var application = Application.Launch(@"G:\������\�������\������� �#\��� ��������\Marathon\Marathon\bin\Debug\Marathon.exe");
            var window = application.GetMainWindow(new UIA3Automation());

            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            window.FindFirstDescendant(cf.ByAutomationId("textBoxLogin")).AsTextBox().Enter("run");
            window.FindFirstDescendant(cf.ByAutomationId("textBoxPassword")).AsTextBox().Enter("run");
            window.FindFirstDescendant(cf.ByAutomationId("buttonEntry")).AsButton().Click();

            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);
            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);
            application.Close();
        }

        [Test]
        public void AutorizationRunnerAndAccountEditing()       //����������� �� ������ � �������������� �������
        {
            UIA3Automation automation = new UIA3Automation();
            var application = Application.Launch(@"G:\������\�������\������� �#\��� ��������\Marathon\Marathon\bin\Debug\Marathon.exe");
            var window = application.GetMainWindow(automation);

            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

            window.FindFirstDescendant(cf.ByAutomationId("textBoxLogin")).AsTextBox().Enter("run");
            window.FindFirstDescendant(cf.ByAutomationId("textBoxPassword")).AsTextBox().Enter("run");
            window.FindFirstDescendant(cf.ByAutomationId("buttonEntry")).AsButton().Click();

            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);
            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);

            window = automation.GetDesktop().AsWindow();

            window.FindFirstDescendant(cf.ByAutomationId("buttonProfile")).AsButton().Click();

            window = application.GetMainWindow(automation);

            window.FindFirstDescendant(cf.ByAutomationId("textBoxName")).AsTextBox().Enter("����");
            window.FindFirstDescendant(cf.ByAutomationId("textBoxSurname")).AsTextBox().Enter("������");
            window.FindFirstDescendant(cf.ByAutomationId("buttonUpdate")).AsButton().Click();

            Thread.Sleep(500);
            Keyboard.Type(VirtualKeyShort.ENTER);

            application.Close();
        }
    }
}