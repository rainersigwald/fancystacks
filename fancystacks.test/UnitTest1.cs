using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace fancystacks.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string markdown = fancystacks.Program.Markdownify(@"Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.RegisteredTaskRecord.GetTaskFactory(targetLoggingContext, elementLocation, taskProjectFile) Line 1295
	at S:\msbuild\src\Build\Instance\TaskRegistry.cs(1295)", 
    "https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/",
    @"S:\msbuild");

            markdown.ShouldBe(@"* [`Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.RegisteredTaskRecord.GetTaskFactory(targetLoggingContext, elementLocation, taskProjectFile)`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/Instance/TaskRegistry.cs#L1295)
");
        }
    }
}
