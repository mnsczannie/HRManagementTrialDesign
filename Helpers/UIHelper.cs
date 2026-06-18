using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial_hr_system.Helpers
{
    internal class UIHelper
    {
        public static void ScaleControls(Form form, float designWidth, float designHeight)
        {
            float scaleX = form.ClientSize.Width / designWidth;
            float scaleY = form.ClientSize.Height / designHeight;

            ScaleControlList(form.Controls, scaleX, scaleY);
        }

        private static void ScaleControlList(Control.ControlCollection controls, float scaleX, float scaleY)
        {
            foreach (Control ctrl in controls)
            {
                ctrl.Left = (int)(ctrl.Left * scaleX);
                ctrl.Top = (int)(ctrl.Top * scaleY);
                ctrl.Width = (int)(ctrl.Width * scaleX);
                ctrl.Height = (int)(ctrl.Height * scaleY);

                // Recursively scale controls inside panels
                if (ctrl.Controls.Count > 0)
                    ScaleControlList(ctrl.Controls, scaleX, scaleY);
            }
        }
    }
}
