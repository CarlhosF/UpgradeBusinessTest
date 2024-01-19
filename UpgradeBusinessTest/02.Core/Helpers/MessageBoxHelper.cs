using System;
using System.Windows.Forms;

namespace UpgradeBusinessTest._02.Core.Helpers
{
    public static class MessageBoxHelper
    {
        public static bool ShowConfirmation(string message, string caption)
        {
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public static void ShowAlert(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowAlert(Exception ex)
        {
            var inner = ex.InnerException == null ? "" : ex.InnerException.Message;
            MessageBoxHelper.ShowAlert($"Error: {ex.Message} Inner: {inner}", "Error");
        }
    }
}
