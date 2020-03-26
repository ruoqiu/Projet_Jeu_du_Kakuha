<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccueil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnp = New System.Windows.Forms.Button()
        Me.btnc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(240, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(585, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JEU DE KAKUHA"
        '
        'btnp
        '
        Me.btnp.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnp.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnp.Location = New System.Drawing.Point(430, 483)
        Me.btnp.Name = "btnp"
        Me.btnp.Size = New System.Drawing.Size(208, 53)
        Me.btnp.TabIndex = 1
        Me.btnp.Text = "JOUER A 2"
        Me.btnp.UseVisualStyleBackColor = True
        '
        'btnc
        '
        Me.btnc.BackColor = System.Drawing.Color.Transparent
        Me.btnc.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnc.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnc.Location = New System.Drawing.Point(430, 381)
        Me.btnc.Name = "btnc"
        Me.btnc.Size = New System.Drawing.Size(226, 64)
        Me.btnc.TabIndex = 2
        Me.btnc.Text = "REGLES DU JEU"
        Me.btnc.UseVisualStyleBackColor = False
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1038, 656)
        Me.Controls.Add(Me.btnc)
        Me.Controls.Add(Me.btnp)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Name = "FormAccueil"
        Me.Text = "FormAccueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnp As System.Windows.Forms.Button
    Friend WithEvents btnc As System.Windows.Forms.Button
End Class
