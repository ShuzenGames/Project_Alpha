using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Alpha
{
    public interface ButtonInterface
    {

        /// <devdoc>
        ///    <para>Notifies a control that it is the default button so that its appearance and behavior
        ///       is adjusted accordingly.
        ///       </para>
        /// </devdoc>
        public void NotifyDefault(bool value);

        /// <devdoc>
        /// <para>Generates a event for the control.</para>
        /// </devdoc>
        public void PerformClick();

    }
}
