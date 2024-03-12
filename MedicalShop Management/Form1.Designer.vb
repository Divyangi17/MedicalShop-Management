<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReortsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastMonthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.SellToolStripMenuItem, Me.ReortsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1567, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(98, 29)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'SellToolStripMenuItem
        '
        Me.SellToolStripMenuItem.Name = "SellToolStripMenuItem"
        Me.SellToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.SellToolStripMenuItem.Text = "Sell"
        '
        'ReortsToolStripMenuItem
        '
        Me.ReortsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LastMonthToolStripMenuItem})
        Me.ReortsToolStripMenuItem.Name = "ReortsToolStripMenuItem"
        Me.ReortsToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.ReortsToolStripMenuItem.Text = "Reorts"
        '
        'LastMonthToolStripMenuItem
        '
        Me.LastMonthToolStripMenuItem.Name = "LastMonthToolStripMenuItem"
        Me.LastMonthToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.LastMonthToolStripMenuItem.Text = "Last month"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1567, 818)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Sanjeevini MedicalStore"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReortsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LastMonthToolStripMenuItem As ToolStripMenuItem
End Class
