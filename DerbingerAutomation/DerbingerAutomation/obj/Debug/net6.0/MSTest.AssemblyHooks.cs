// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using System.Diagnostics;
using global::Microsoft.VisualStudio.TestTools.UnitTesting;
using global::TechTalk.SpecFlow;
using global::TechTalk.SpecFlow.MSTest.SpecFlowPlugin;
using global::System.Runtime.CompilerServices;

[GeneratedCode("SpecFlow", "3.9.40")]
[TestClass]
public class DerbingerAutomation_MSTestAssemblyHooks
{
    [AssemblyInitialize]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AssemblyInitialize(TestContext testContext)
    {
        var currentAssembly = typeof(DerbingerAutomation_MSTestAssemblyHooks).Assembly;
        var containerBuilder = new MsTestContainerBuilder(testContext);

        TestRunnerManager.OnTestRunStart(currentAssembly, containerBuilder);
    }

    [AssemblyCleanup]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AssemblyCleanup()
    {
        var currentAssembly = typeof(DerbingerAutomation_MSTestAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
#pragma warning restore
