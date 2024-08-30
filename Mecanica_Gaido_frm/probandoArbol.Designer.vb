<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProbandoArbol
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.treeViewCodDep = New System.Windows.Forms.TreeView()
        Me.txtCodDep = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'treeViewCodDep
        '
        Me.treeViewCodDep.Location = New System.Drawing.Point(0, -6)
        Me.treeViewCodDep.Name = "treeViewCodDep"
        Me.treeViewCodDep.Size = New System.Drawing.Size(798, 381)
        Me.treeViewCodDep.TabIndex = 0
        '
        'txtCodDep
        '
        Me.txtCodDep.Location = New System.Drawing.Point(463, 403)
        Me.txtCodDep.Name = "txtCodDep"
        Me.txtCodDep.Size = New System.Drawing.Size(180, 26)
        Me.txtCodDep.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(650, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'probandoArbol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCodDep)
        Me.Controls.Add(Me.treeViewCodDep)
        Me.Name = "probandoArbol"
        Me.Text = "probandoArbol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents treeViewCodDep As TreeView
    Friend WithEvents txtCodDep As TextBox
    Friend WithEvents Button1 As Button
End Class
