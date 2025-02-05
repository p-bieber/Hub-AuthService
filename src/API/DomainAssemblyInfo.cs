using System.Reflection;

namespace Bieber.Hub.AuthService.API;
public static class ApiAssemblyInfo
{
    public static Assembly Assembly => typeof(ApiAssemblyInfo).Assembly;
    public static string AssemblyName => Assembly.GetName().Name;
}
