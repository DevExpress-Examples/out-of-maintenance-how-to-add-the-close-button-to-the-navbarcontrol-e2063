<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2063)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication104/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication104/Form1.vb))
* [Program.cs](./CS/WindowsApplication104/Program.cs) (VB: [Program.vb](./VB/WindowsApplication104/Program.vb))
<!-- default file list end -->
# How to add the close button to the NavBarControl


<p>You can introduce this functionality by using the DockPanel:</p><p>1. Place the NavBarControl in the DockPanel.<br />
2. Set the NavBarControl's Dock property to Fill.<br />
3. Set the DockPanel's Dock property.<br />
3. Set the DockPanel.Options.ShowAutoHideButton property to false.</p><p>Now you can close the NavBarControl by pressing the DockPanel's close button.</p><p>This example demonstrates this approach in action.</p>

<br/>


