using System.Threading;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.GoDotTestRiderPlugin.Tests
{
    [ZoneDefinition]
    public class GoDotTestRiderPluginTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<IGoDotTestRiderPluginZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<GoDotTestRiderPluginTestEnvironmentZone> { }

    [SetUpFixture]
    public class GoDotTestRiderPluginTestsAssembly : ExtensionTestEnvironmentAssembly<GoDotTestRiderPluginTestEnvironmentZone> { }
}
