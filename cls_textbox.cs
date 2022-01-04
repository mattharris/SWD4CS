﻿
namespace SWD4CS
{
    public partial class cls_textbox : TextBox
    {
        public cls_control_base ctrlBase;

        public cls_textbox(Control parent, Control backPanel, DataGridView propertyList, int index, int X = 0, int Y = 0)
        {
            InitializeComponent(index, X, Y);

            cls_form ctrl = (cls_form)parent;
            ctrl.CtrlItems.Add(this);
            ctrl.Controls.Add(ctrl.CtrlItems[ctrl.CtrlItems.Count - 1] as cls_textbox as cls_textbox);
            ctrlBase = new cls_control_base(parent, this, backPanel, propertyList);
        }

        public void Deleate(Control parent, cls_textbox ctrl)
        {
            parent.Controls.Remove(ctrl);
            ctrlBase.SetSelect(false);
            this.Dispose();
        }
    }
}
