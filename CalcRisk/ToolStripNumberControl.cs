using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CalcRisk
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
    class ToolStripNumberControl : ToolStripControlHost
    {
        public ToolStripNumberControl() : base(new NumericUpDown())
        {

        }

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            ((NumericUpDown)control).ValueChanged += new EventHandler(OnValueChanged);
            ((NumericUpDown)control).Maximum = 12;
            ((NumericUpDown)control).Minimum = 1;
            ((NumericUpDown)control).Value = 12;
            ((NumericUpDown)control).ReadOnly = true;
            ((NumericUpDown)control).TextAlign = HorizontalAlignment.Center;
        }

        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            ((NumericUpDown)control).ValueChanged -= new EventHandler(OnValueChanged);
        }

        public event EventHandler ValueChanged;

        public Control NumericUpDownControl
        {
            get { return Control as NumericUpDown; }
        }

        public void OnValueChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }
}
