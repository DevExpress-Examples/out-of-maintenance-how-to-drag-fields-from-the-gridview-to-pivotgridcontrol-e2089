using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraGrid.Columns;

namespace Q250992 {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

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