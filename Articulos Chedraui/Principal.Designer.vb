<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.contenedor = New System.Windows.Forms.Panel()
        Me.datamostras = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArticulosUPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarUPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoProveedorArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarCatalogoCompletoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrigenDeDatosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hilosegundoplano = New System.ComponentModel.BackgroundWorker()
        Me.contenedor.SuspendLayout()
        CType(Me.datamostras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'contenedor
        '
        Me.contenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contenedor.Controls.Add(Me.datamostras)
        Me.contenedor.Location = New System.Drawing.Point(22, 70)
        Me.contenedor.Name = "contenedor"
        Me.contenedor.Size = New System.Drawing.Size(1116, 628)
        Me.contenedor.TabIndex = 1
        '
        'datamostras
        '
        Me.datamostras.AllowUserToAddRows = False
        Me.datamostras.AllowUserToOrderColumns = True
        Me.datamostras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datamostras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datamostras.Location = New System.Drawing.Point(0, 0)
        Me.datamostras.Name = "datamostras"
        Me.datamostras.ReadOnly = True
        Me.datamostras.Size = New System.Drawing.Size(1116, 628)
        Me.datamostras.TabIndex = 0
        Me.datamostras.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tiendas Chedraui S.A de C.V"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(882, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 34)
        Me.Button1.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Button1, "Exportar Datos a Excel")
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(927, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 34)
        Me.Button2.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Button2, "Exportar A Texto")
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Beige
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosUPCToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1150, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArticulosUPCToolStripMenuItem
        '
        Me.ArticulosUPCToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarUPCToolStripMenuItem, Me.ConsultarArticuloToolStripMenuItem, Me.CatalogoProveedorArticuloToolStripMenuItem, Me.DescargarCatalogoCompletoToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.ArticulosUPCToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArticulosUPCToolStripMenuItem.Name = "ArticulosUPCToolStripMenuItem"
        Me.ArticulosUPCToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.ArticulosUPCToolStripMenuItem.Text = "Operaciones"
        '
        'ConsultarUPCToolStripMenuItem
        '
        Me.ConsultarUPCToolStripMenuItem.Name = "ConsultarUPCToolStripMenuItem"
        Me.ConsultarUPCToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.ConsultarUPCToolStripMenuItem.Text = "Consultar UPC"
        '
        'ConsultarArticuloToolStripMenuItem
        '
        Me.ConsultarArticuloToolStripMenuItem.Name = "ConsultarArticuloToolStripMenuItem"
        Me.ConsultarArticuloToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.ConsultarArticuloToolStripMenuItem.Text = "Consultar Articulo"
        '
        'CatalogoProveedorArticuloToolStripMenuItem
        '
        Me.CatalogoProveedorArticuloToolStripMenuItem.Name = "CatalogoProveedorArticuloToolStripMenuItem"
        Me.CatalogoProveedorArticuloToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.CatalogoProveedorArticuloToolStripMenuItem.Text = "Catalogo Proveedor Articulo"
        '
        'DescargarCatalogoCompletoToolStripMenuItem
        '
        Me.DescargarCatalogoCompletoToolStripMenuItem.Name = "DescargarCatalogoCompletoToolStripMenuItem"
        Me.DescargarCatalogoCompletoToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.DescargarCatalogoCompletoToolStripMenuItem.Text = "Descargar Catalogo Completo"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrigenDeDatosToolStripMenuItem1})
        Me.ConfiguraciónToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'OrigenDeDatosToolStripMenuItem1
        '
        Me.OrigenDeDatosToolStripMenuItem1.Name = "OrigenDeDatosToolStripMenuItem1"
        Me.OrigenDeDatosToolStripMenuItem1.Size = New System.Drawing.Size(177, 24)
        Me.OrigenDeDatosToolStripMenuItem1.Text = "Origen de datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(692, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Registros"
        Me.Label2.Visible = False
        '
        'hilosegundoplano
        '
        Me.hilosegundoplano.WorkerReportsProgress = True
        Me.hilosegundoplano.WorkerSupportsCancellation = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1150, 710)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.contenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Tiendas Chedraui"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.contenedor.ResumeLayout(False)
        CType(Me.datamostras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contenedor As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datamostras As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArticulosUPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarUPCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescargarCatalogoCompletoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoProveedorArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrigenDeDatosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents hilosegundoplano As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
