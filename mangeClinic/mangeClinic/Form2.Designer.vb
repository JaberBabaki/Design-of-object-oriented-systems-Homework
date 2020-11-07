<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChap = New System.Windows.Forms.Button()
        Me.txtTelephon = New System.Windows.Forms.TextBox()
        Me.txtFamily = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnJostejoo = New System.Windows.Forms.Button()
        Me.btnHazf = New System.Windows.Forms.Button()
        Me.btnVirayesh = New System.Windows.Forms.Button()
        Me.btnDarj = New System.Windows.Forms.Button()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Linen
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.PeachPuff
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(-4, 1)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(421, 202)
        Me.DataGrid1.TabIndex = 12
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Orange
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "نام"
        Me.DataGridTextBoxColumn1.MappingName = "name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "نام خانوادگي"
        Me.DataGridTextBoxColumn2.MappingName = "family"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "شماره تلفن"
        Me.DataGridTextBoxColumn3.MappingName = "tel"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "شماره تلفن"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "نام خانوادگي"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "نام"
        '
        'btnChap
        '
        Me.btnChap.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnChap.Location = New System.Drawing.Point(70, 275)
        Me.btnChap.Name = "btnChap"
        Me.btnChap.Size = New System.Drawing.Size(75, 23)
        Me.btnChap.TabIndex = 20
        Me.btnChap.Text = "چاپ"
        '
        'txtTelephon
        '
        Me.txtTelephon.Location = New System.Drawing.Point(242, 260)
        Me.txtTelephon.Name = "txtTelephon"
        Me.txtTelephon.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephon.TabIndex = 15
        '
        'txtFamily
        '
        Me.txtFamily.Location = New System.Drawing.Point(242, 236)
        Me.txtFamily.Name = "txtFamily"
        Me.txtFamily.Size = New System.Drawing.Size(100, 20)
        Me.txtFamily.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(242, 212)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 13
        '
        'btnJostejoo
        '
        Me.btnJostejoo.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnJostejoo.Location = New System.Drawing.Point(111, 241)
        Me.btnJostejoo.Name = "btnJostejoo"
        Me.btnJostejoo.Size = New System.Drawing.Size(75, 23)
        Me.btnJostejoo.TabIndex = 19
        Me.btnJostejoo.Text = "جستجو"
        '
        'btnHazf
        '
        Me.btnHazf.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnHazf.Location = New System.Drawing.Point(111, 211)
        Me.btnHazf.Name = "btnHazf"
        Me.btnHazf.Size = New System.Drawing.Size(75, 23)
        Me.btnHazf.TabIndex = 18
        Me.btnHazf.Text = "حذف "
        '
        'btnVirayesh
        '
        Me.btnVirayesh.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnVirayesh.Location = New System.Drawing.Point(30, 240)
        Me.btnVirayesh.Name = "btnVirayesh"
        Me.btnVirayesh.Size = New System.Drawing.Size(75, 23)
        Me.btnVirayesh.TabIndex = 17
        Me.btnVirayesh.Text = "ويرايش"
        '
        'btnDarj
        '
        Me.btnDarj.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnDarj.Location = New System.Drawing.Point(30, 211)
        Me.btnDarj.Name = "btnDarj"
        Me.btnDarj.Size = New System.Drawing.Size(75, 23)
        Me.btnDarj.TabIndex = 16
        Me.btnDarj.Text = "درج"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 310)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChap)
        Me.Controls.Add(Me.txtTelephon)
        Me.Controls.Add(Me.txtFamily)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnJostejoo)
        Me.Controls.Add(Me.btnHazf)
        Me.Controls.Add(Me.btnVirayesh)
        Me.Controls.Add(Me.btnDarj)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnChap As System.Windows.Forms.Button
    Friend WithEvents txtTelephon As System.Windows.Forms.TextBox
    Friend WithEvents txtFamily As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnJostejoo As System.Windows.Forms.Button
    Friend WithEvents btnHazf As System.Windows.Forms.Button
    Friend WithEvents btnVirayesh As System.Windows.Forms.Button
    Friend WithEvents btnDarj As System.Windows.Forms.Button
End Class
