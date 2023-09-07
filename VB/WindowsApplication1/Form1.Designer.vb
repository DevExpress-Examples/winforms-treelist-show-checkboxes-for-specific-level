Namespace WindowsApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 29)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsView.ShowCheckBoxes = True
            Me.treeList1.Size = New System.Drawing.Size(378, 512)
            Me.treeList1.TabIndex = 0
            ' 
            ' spinEdit1
            ' 
            Me.spinEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spinEdit1.EditValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.spinEdit1.Location = New System.Drawing.Point(59, 2)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinEdit1.Size = New System.Drawing.Size(242, 20)
            Me.spinEdit1.TabIndex = 1
            AddHandler Me.spinEdit1.EditValueChanged, New System.EventHandler(AddressOf Me.spinEdit1_EditValueChanged)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.spinEdit1)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Controls.Add(Me.checkEdit1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(378, 29)
            Me.panelControl1.TabIndex = 2
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.labelControl1.Location = New System.Drawing.Point(2, 2)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(57, 23)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "Level:"
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Dock = System.Windows.Forms.DockStyle.Right
            Me.checkEdit1.EditValue = True
            Me.checkEdit1.Location = New System.Drawing.Point(301, 2)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Hide"
            Me.checkEdit1.Size = New System.Drawing.Size(75, 19)
            Me.checkEdit1.TabIndex = 3
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(378, 541)
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private spinEdit1 As DevExpress.XtraEditors.SpinEdit

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
    End Class
End Namespace
