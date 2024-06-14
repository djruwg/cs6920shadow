using System.Security.Principal;

namespace BBB.Helpers
{
    internal static class WindowsUsername
    {
        public static string GetWindowsUsername()
        {
            return WindowsIdentity.GetCurrent().Name;
        }
    }
}
