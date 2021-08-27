<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2089)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q250992/Form1.cs) (VB: [Form1.vb](./VB/Q250992/Form1.vb))
<!-- default file list end -->
# How to drag fields from the GridView to PivotGridControl


<p>This example demonstrates how to implement the capability to add fields to the PivotGridControl by dragging columns from the GridView.</p>


<h3>Description</h3>

<p>This feature can be implemented by handling two events. Within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_DragObjectOvertopic">GridView.DragObjectOver</a> event handler, the Valid parameter of the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseDragObjectOverEventArgs_DropInfotopic">DragObjectOverEventArgs.DropInfo</a> is set to false if the cursor is hovering over the PivotGridControl. This is done to prevent the dragged column from being hidden.</p><p>Within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_DragObjectDroptopic">GridView.DragObjectDrop</a> event handler, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CalcHitInfotopic">PivotGridControl.CalcHitInfo</a> method is used to check whether the column has been dropped within the field area. If so, a new PivodGridField is created and added to the corresponding area.</p>

<br/>


