using System;
using System.Windows.Forms;

namespace portfoliosInit
{
    class ComboBoxWithPrevious : ComboBox
    {
        public int previousIndex { get; set; }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            if (DataManager != null)
                previousIndex = DataManager.Position;

            base.OnSelectedIndexChanged(e);
        }
    }
}
