<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataTransaksi
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
        Me.DGDataT = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.DGDataT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGDataT
        '
        Me.DGDataT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGDataT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGDataT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDataT.Location = New System.Drawing.Point(12, 12)
        Me.DGDataT.Name = "DGDataT"
        Me.DGDataT.ReadOnly = True
        Me.DGDataT.Size = New System.Drawing.Size(453, 188)
        Me.DGDataT.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(12, 216)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(453, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'FormDataTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 254)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DGDataT)
        Me.Name = "FormDataTransaksi"
        Me.Text = "FormDataTransaksi"
        CType(Me.DGDataT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGDataT As DataGridView
    Friend WithEvents btnRefresh As Button
End Class
