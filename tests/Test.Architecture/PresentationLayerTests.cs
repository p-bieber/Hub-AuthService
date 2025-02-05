using NetArchTest.Rules;
using Shouldly;

namespace Bieber.Hub.AuthService.Test.Architecture;
public class PresentationLayerTests : BaseTest
{
    [Fact]
    public void Presentation_Should_NotHaveDependencyOn_ApiLayer()
    {
        TestResult result = Types.InAssembly(PresentationAssembly)
            .ShouldNot()
            .HaveDependencyOn(ApiAssembly.GetName().Name)
            .GetResult();
        result.IsSuccessful.ShouldBeTrue();
    }
}
