using Microsoft.TestPlatform.VsTestConsole.TranslationLayer;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
using System;
using System.Collections.Generic;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to your test dll
            string testProject = @"C:\Projects\UnitTestProject1\bin\Debug\UnitTestProject1.dll";
            string runsettings = @"<?xml version=""1.0"" encoding=""utf-8""?>
                                             <RunSettings>
                                               <RunConfiguration>
                                               </RunConfiguration>
                                             </RunSettings>";

            VsTestConsoleWrapper wrapper = new VsTestConsoleWrapper(@"{path to your vstest.console.exe}");
            var handler = new RunEventsHandler();

            Console.WriteLine("Started");
            wrapper.StartSession();
            wrapper.RunTests(new List<string>() { testProject }, runsettings, handler);
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }


    internal class RunEventsHandler : ITestRunEventsHandler
    {
        public void HandleLogMessage(TestMessageLevel level, string message)
        {
        }

        public void HandleRawMessage(string rawMessage)
        {
        }

        public void HandleTestRunComplete(TestRunCompleteEventArgs testRunCompleteArgs, TestRunChangedEventArgs lastChunkArgs, ICollection<AttachmentSet> runContextAttachments, ICollection<string> executorUris)
        {
        }

        public void HandleTestRunStatsChange(TestRunChangedEventArgs testRunChangedArgs)
        {
        }

        public int LaunchProcessWithDebuggerAttached(TestProcessStartInfo testProcessStartInfo)
        {
            return 0;
        }
    }
}
