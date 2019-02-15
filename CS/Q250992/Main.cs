using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace DXSample {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e) {
            recordBindingSource.DataSource = DataHelper.GetData(10);
        }

        private void OnGridViewDragObjectDrop(object sender, DragObjectDropEventArgs e) {
            Point location = MousePosition;
            if (!(e.DragObject is GridColumn)) return;
            PivotGridHitInfo hitInfo = pivot.CalcHitInfo(pivot.PointToClient(location));
            if (null == hitInfo.HeadersAreaInfo) return;
            pivot.Fields.Add(((GridColumn)e.DragObject).FieldName, hitInfo.HeadersAreaInfo.Area);
        }

        private void OnGridViewDragObjectOver(object sender, DragObjectOverEventArgs e) {
            Point location = MousePosition;
            if (!(e.DragObject is GridColumn)) return;
            e.DropInfo.Valid = GetChildAtPoint(PointToClient(location)) != pivot;
        }
    }
}