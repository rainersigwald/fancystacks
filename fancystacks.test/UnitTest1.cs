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
	at S:\msbuild\src\Build\Instance\TaskRegistry.cs(1295)
Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.RegisteredTaskRecord.CanTaskBeCreatedByFactory(taskName, taskProjectFile, taskIdentityParameters, targetLoggingContext, elementLocation) Line 1189
	at S:\msbuild\src\Build\Instance\TaskRegistry.cs(1189)
Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.GetMatchingRegistration(taskName, taskRecords, taskProjectFile, taskIdentityParameters, targetLoggingContext, elementLocation) Line 689
	at S:\msbuild\src\Build\Instance\TaskRegistry.cs(689)
Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.GetTaskRegistrationRecord(taskName, taskProjectFile, taskIdentityParameters, exactMatchRequired, targetLoggingContext, elementLocation, retrievedFromCache) Line 538
	at S:\msbuild\src\Build\Instance\TaskRegistry.cs(538)
Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.GetRegisteredTask(taskName, taskProjectFile, taskIdentityParameters, exactMatchRequired, targetLoggingContext, elementLocation) Line 417
	at S:\msbuild\src\Build\Instance\TaskRegistry.cs(417)
Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskExecutionHost.FindTaskInRegistry(taskIdentityParameters) Line 868
	at S:\msbuild\src\Build\BackEnd\TaskExecutionHost\TaskExecutionHost.cs(868)
Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskExecutionHost.Microsoft.Build.BackEnd.ITaskExecutionHost.FindTask(taskIdentityParameters) Line 249
	at S:\msbuild\src\Build\BackEnd\TaskExecutionHost\TaskExecutionHost.cs(249)
Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskBuilder.ExecuteBucket(taskHost, bucket, howToExecuteTask, lookupHash) Line 414
	at S:\msbuild\src\Build\BackEnd\Components\RequestBuilder\TaskBuilder.cs(414)
Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskBuilder.ExecuteTask(mode, lookup) Line 325
	at S:\msbuild\src\Build\BackEnd\Components\RequestBuilder\TaskBuilder.cs(325)
Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskBuilder.ExecuteTask(loggingContext, requestEntry, targetBuilderCallback, taskInstance, mode, inferLookup, executeLookup, cancellationToken) Line 179
	at S:\msbuild\src\Build\BackEnd\Components\RequestBuilder\TaskBuilder.cs(179)
Microsoft.Build.dll!Microsoft.Build.BackEnd.TargetEntry.ProcessBucket(taskBuilder, targetLoggingContext, mode, lookupForInference, lookupForExecution) Line 816
	at S:\msbuild\src\Build\BackEnd\Components\RequestBuilder\TargetEntry.cs(816)
Microsoft.Build.dll!Microsoft.Build.BackEnd.TargetEntry.ExecuteTarget(taskBuilder, requestEntry, projectLoggingContext, cancellationToken) Line 499
	at S:\msbuild\src\Build\BackEnd\Components\RequestBuilder\TargetEntry.cs(499)
Microsoft.Build.dll!Microsoft.Build.BackEnd.TargetBuilder.ProcessTargetStack(taskBuilder) Line 486
	at S:\msbuild\src\Build\BackEnd\Components\RequestBuilder\TargetBuilder.cs(486)
", "https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/");

            markdown.ShouldBe(@"* [`Microsoft.Build.dll!Microsoft.Build.Shared.TypeLoader.LoadAssembly(assemblyLoadInfo) Line 162`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Shared/TypeLoader.cs#L162)
* [`Microsoft.Build.dll!Microsoft.Build.Shared.TypeLoader.AssemblyInfoToLoadedTypes.ScanAssemblyForPublicTypes() Line 355`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Shared/TypeLoader.cs#L355)
* [`Microsoft.Build.dll!Microsoft.Build.Shared.TypeLoader.AssemblyInfoToLoadedTypes.GetLoadedTypeByTypeName.AnonymousMethod__0(key) Line 326`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Shared/TypeLoader.cs#L326)
* [`mscorlib.dll!System.Collections.Concurrent.ConcurrentDictionary<string, System.Type>.GetOrAdd(key, valueFactory) Line 1069`](f://dd/ndp/clr/src/BCL/system/Collections/Concurrent/ConcurrentDictionary.cs#L1069)
* [`Microsoft.Build.dll!Microsoft.Build.Shared.TypeLoader.AssemblyInfoToLoadedTypes.GetLoadedTypeByTypeName(typeName) Line 299`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Shared/TypeLoader.cs#L299)
* [`Microsoft.Build.dll!Microsoft.Build.Shared.TypeLoader.GetLoadedType(cache, typeName, assembly) Line 226`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Shared/TypeLoader.cs#L226)
* [`Microsoft.Build.dll!Microsoft.Build.Shared.TypeLoader.Load(typeName, assembly) Line 192`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Shared/TypeLoader.cs#L192)
* [`Microsoft.Build.dll!Microsoft.Build.BackEnd.AssemblyTaskFactory.InitializeFactory(loadInfo, taskName, taskParameters, taskElementContents, taskFactoryIdentityParameters, taskHostFactoryExplicitlyRequested, targetLoggingContext, elementLocation, taskProjectFile) Line 278`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/Instance/TaskFactories/AssemblyTaskFactory.cs#L278)
* [`Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.RegisteredTaskRecord.GetTaskFactory(targetLoggingContext, elementLocation, taskProjectFile) Line 1307`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/Instance/TaskRegistry.cs#L1307)
* [`Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.RegisteredTaskRecord.CanTaskBeCreatedByFactory(taskName, taskProjectFile, taskIdentityParameters, targetLoggingContext, elementLocation) Line 1189`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/Instance/TaskRegistry.cs#L1189)
* [`Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.GetMatchingRegistration(taskName, taskRecords, taskProjectFile, taskIdentityParameters, targetLoggingContext, elementLocation) Line 689`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/Instance/TaskRegistry.cs#L689)
* [`Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.GetTaskRegistrationRecord(taskName, taskProjectFile, taskIdentityParameters, exactMatchRequired, targetLoggingContext, elementLocation, retrievedFromCache) Line 538`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/Instance/TaskRegistry.cs#L538)
* [`Microsoft.Build.dll!Microsoft.Build.Execution.TaskRegistry.GetRegisteredTask(taskName, taskProjectFile, taskIdentityParameters, exactMatchRequired, targetLoggingContext, elementLocation) Line 417`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/Instance/TaskRegistry.cs#L417)
* [`Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskExecutionHost.FindTaskInRegistry(taskIdentityParameters) Line 868`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/BackEnd/TaskExecutionHost/TaskExecutionHost.cs#L868)
* [`Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskExecutionHost.Microsoft.Build.BackEnd.ITaskExecutionHost.FindTask(taskIdentityParameters) Line 249`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/BackEnd/TaskExecutionHost/TaskExecutionHost.cs#L249)
* [`Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskBuilder.ExecuteBucket(taskHost, bucket, howToExecuteTask, lookupHash) Line 414`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/BackEnd/Components/RequestBuilder/TaskBuilder.cs#L414)
* [`Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskBuilder.ExecuteTask(mode, lookup) Line 325`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/BackEnd/Components/RequestBuilder/TaskBuilder.cs#L325)
* [`Microsoft.Build.dll!Microsoft.Build.BackEnd.TaskBuilder.ExecuteTask(loggingContext, requestEntry, targetBuilderCallback, taskInstance, mode, inferLookup, executeLookup, cancellationToken) Line 179`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/BackEnd/Components/RequestBuilder/TaskBuilder.cs#L179)
* [`Microsoft.Build.dll!Microsoft.Build.BackEnd.TargetEntry.ProcessBucket(taskBuilder, targetLoggingContext, mode, lookupForInference, lookupForExecution) Line 816`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/BackEnd/Components/RequestBuilder/TargetEntry.cs#L816)
* [`Microsoft.Build.dll!Microsoft.Build.BackEnd.TargetEntry.ExecuteTarget(taskBuilder, requestEntry, projectLoggingContext, cancellationToken) Line 499`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/BackEnd/Components/RequestBuilder/TargetEntry.cs#L499)
* [`Microsoft.Build.dll!Microsoft.Build.BackEnd.TargetBuilder.ProcessTargetStack(taskBuilder) Line 486`](https://github.com/dotnet/msbuild/blob/4242f381a90f77f483b123819759db1ff8eddf67/src/Build/BackEnd/Components/RequestBuilder/TargetBuilder.cs#L486)");
        }
    }
}
