using System.Reflection;
using Bieber.Hub.AuthService.API;
using Bieber.Hub.AuthService.Application;
using Bieber.Hub.AuthService.Domain;
using Bieber.Hub.AuthService.Infrastructure;
using Bieber.Hub.AuthService.Presentation;

namespace Bieber.Hub.AuthService.Test.Architecture;

public abstract class BaseTest
{
    protected static readonly Assembly DomainAssembly = DomainAssemblyInfo.Assembly;
    protected static readonly Assembly ApplicationAssembly = ApplicationAssemblyInfo.Assembly;
    protected static readonly Assembly InfrastructureAssembly = InfrastructureAssemblyInfo.Assembly;
    protected static readonly Assembly PresentationAssembly = PresentationAssemblyInfo.Assembly;
    protected static readonly Assembly ApiAssembly = ApiAssemblyInfo.Assembly;
}
