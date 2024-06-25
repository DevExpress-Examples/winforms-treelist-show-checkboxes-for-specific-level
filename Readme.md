<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638231/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2810)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms TreeList - Display node checkboxes for a specific tree level

This example shows how to show checkboxes within nodes displayed at a specified tree level and hide/disable checkboxes for other nodes.

The [CustomDrawNodeCheckBox](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.CustomDrawNodeCheckBox) event is handled to hide checkboxes or set them to disabled.

```csharp
void treeList_CustomDrawNodeCheckBox(object sender, CustomDrawNodeCheckBoxEventArgs e) {
    bool canCheckNode = CanCheckNode(e.Node);
    if (canCheckNode)
        return;
    e.ObjectArgs.State = DevExpress.Utils.Drawing.ObjectState.Disabled;
    e.Handled = NeedHide;
}
```

The [BeforeCheckNode](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.BeforeCheckNode) event is handled to prevent users from changing the state of disabled checkboxes.

```csharp
void treeList_BeforeCheckNode(object sender, CheckNodeEventArgs e) {
    e.CanCheck = CanCheckNode(e.Node);
}
```

![WinForms TreeList - Display node checkboxes for a specific tree level](https://raw.githubusercontent.com/DevExpress-Examples/how-to-show-checkboxes-for-only-a-specific-level-e2810/13.1.4%2B/media/winforms-treelist-display-node-checkboxes.gif)


## Files to Review

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))


## Documentation

* [Node Checking - Checkboxes and Radio Buttons](https://docs.devexpress.com/WindowsForms/120672/controls-and-libraries/tree-list/feature-center/focus-selection-and-navigation/node-checking-checkboxes-and-radio-buttons)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-show-checkboxes-for-specific-level&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-show-checkboxes-for-specific-level&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
