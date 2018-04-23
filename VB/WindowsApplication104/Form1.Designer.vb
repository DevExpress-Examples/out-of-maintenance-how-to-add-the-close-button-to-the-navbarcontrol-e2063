Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication104
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel1_Container.SuspendLayout()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.dockPanel1})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
			Me.dockPanel1.ID = New System.Guid("426d819f-3717-417d-b9da-472ff53d0580")
			Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.Options.ShowAutoHideButton = False
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(201, 200)
			Me.dockPanel1.Size = New System.Drawing.Size(201, 437)
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Controls.Add(Me.navBarControl1)
			Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(195, 409)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6})
			Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.Size = New System.Drawing.Size(195, 409)
			Me.navBarControl1.TabIndex = 1
			Me.navBarControl1.Text = "navBarControl1"
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "navBarGroup1"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2)})
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "navBarGroup2"
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Caption = "navBarItem1"
			Me.navBarItem1.Name = "navBarItem1"
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "navBarItem2"
			Me.navBarItem2.Name = "navBarItem2"
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "navBarItem3"
			Me.navBarItem3.Name = "navBarItem3"
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "navBarItem4"
			Me.navBarItem4.Name = "navBarItem4"
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "navBarGroup3"
			Me.navBarGroup3.Expanded = True
			Me.navBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6)})
			Me.navBarGroup3.Name = "navBarGroup3"
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "navBarItem5"
			Me.navBarItem5.Name = "navBarItem5"
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "navBarItem6"
			Me.navBarItem6.Name = "navBarItem6"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(407, 437)
			Me.Controls.Add(Me.dockPanel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel1_Container.ResumeLayout(False)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
	End Class
End Namespace

