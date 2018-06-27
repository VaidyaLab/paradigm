<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sample
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Mask1 = New System.Windows.Forms.PictureBox()
        Me.Mask2 = New System.Windows.Forms.PictureBox()
        Me.Mask3 = New System.Windows.Forms.PictureBox()
        Me.Mask4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mask1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mask2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mask3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mask4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(550, 300)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Mask1
        '
        Me.Mask1.Image = Global.Experiment_2.My.Resources.Resources.black
        Me.Mask1.Location = New System.Drawing.Point(550, 300)
        Me.Mask1.Name = "Mask1"
        Me.Mask1.Size = New System.Drawing.Size(125, 125)
        Me.Mask1.TabIndex = 1
        Me.Mask1.TabStop = False
        '
        'Mask2
        '
        Me.Mask2.Image = Global.Experiment_2.My.Resources.Resources.black
        Me.Mask2.Location = New System.Drawing.Point(675, 300)
        Me.Mask2.Name = "Mask2"
        Me.Mask2.Size = New System.Drawing.Size(125, 125)
        Me.Mask2.TabIndex = 3
        Me.Mask2.TabStop = False
        '
        'Mask3
        '
        Me.Mask3.Image = Global.Experiment_2.My.Resources.Resources.black
        Me.Mask3.Location = New System.Drawing.Point(550, 425)
        Me.Mask3.Name = "Mask3"
        Me.Mask3.Size = New System.Drawing.Size(125, 125)
        Me.Mask3.TabIndex = 4
        Me.Mask3.TabStop = False
        '
        'Mask4
        '
        Me.Mask4.Image = Global.Experiment_2.My.Resources.Resources.black
        Me.Mask4.Location = New System.Drawing.Point(675, 425)
        Me.Mask4.Name = "Mask4"
        Me.Mask4.Size = New System.Drawing.Size(125, 125)
        Me.Mask4.TabIndex = 5
        Me.Mask4.TabStop = False
        '
        'Sample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1612, 912)
        Me.Controls.Add(Me.Mask4)
        Me.Controls.Add(Me.Mask3)
        Me.Controls.Add(Me.Mask2)
        Me.Controls.Add(Me.Mask1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sample"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mask1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mask2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mask3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mask4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Mask1 As System.Windows.Forms.PictureBox
    Friend WithEvents Mask2 As System.Windows.Forms.PictureBox
    Friend WithEvents Mask3 As System.Windows.Forms.PictureBox
    Friend WithEvents Mask4 As System.Windows.Forms.PictureBox

End Class
