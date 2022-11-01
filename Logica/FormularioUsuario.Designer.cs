namespace EmpresaTuLuz
{
    partial class Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.chkInactivo = new System.Windows.Forms.CheckBox();
            this.lblEmpleadoId = new System.Windows.Forms.Label();
            this.cbEmpleadoId = new System.Windows.Forms.ComboBox();
            this.txtRepetirPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbListadoUsuarios = new System.Windows.Forms.GroupBox();
            this.grillaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuscarEmpleado = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbEdicion = new System.Windows.Forms.GroupBox();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatos.SuspendLayout();
            this.gbListadoUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.gbEdicion.SuspendLayout();
            this.gbAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.chkInactivo);
            this.gbDatos.Controls.Add(this.lblEmpleadoId);
            this.gbDatos.Controls.Add(this.cbEmpleadoId);
            this.gbDatos.Controls.Add(this.txtRepetirPassword);
            this.gbDatos.Controls.Add(this.txtPassword);
            this.gbDatos.Controls.Add(this.btnAgregarUsuario);
            this.gbDatos.Controls.Add(this.btnLimpiar);
            this.gbDatos.Controls.Add(this.txtUsuario);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.lblUsuario);
            this.gbDatos.Location = new System.Drawing.Point(27, 431);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(912, 177);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos de usuario";
            // 
            // chkInactivo
            // 
            this.chkInactivo.AutoSize = true;
            this.chkInactivo.Location = new System.Drawing.Point(130, 140);
            this.chkInactivo.Name = "chkInactivo";
            this.chkInactivo.Size = new System.Drawing.Size(114, 17);
            this.chkInactivo.TabIndex = 8;
            this.chkInactivo.Text = "En estado inactivo";
            this.chkInactivo.UseVisualStyleBackColor = true;
            // 
            // lblEmpleadoId
            // 
            this.lblEmpleadoId.AutoSize = true;
            this.lblEmpleadoId.Location = new System.Drawing.Point(62, 116);
            this.lblEmpleadoId.Name = "lblEmpleadoId";
            this.lblEmpleadoId.Size = new System.Drawing.Size(87, 13);
            this.lblEmpleadoId.TabIndex = 7;
            this.lblEmpleadoId.Text = "ID del empleado:";
            // 
            // cbEmpleadoId
            // 
            this.cbEmpleadoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleadoId.FormattingEnabled = true;
            this.cbEmpleadoId.Location = new System.Drawing.Point(155, 113);
            this.cbEmpleadoId.Name = "cbEmpleadoId";
            this.cbEmpleadoId.Size = new System.Drawing.Size(119, 21);
            this.cbEmpleadoId.TabIndex = 6;
            // 
            // txtRepetirPassword
            // 
            this.txtRepetirPassword.Location = new System.Drawing.Point(155, 86);
            this.txtRepetirPassword.Name = "txtRepetirPassword";
            this.txtRepetirPassword.PasswordChar = '*';
            this.txtRepetirPassword.Size = new System.Drawing.Size(119, 20);
            this.txtRepetirPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(155, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(119, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(489, 140);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Guardar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(391, 140);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(155, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(119, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(103, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // gbListadoUsuarios
            // 
            this.gbListadoUsuarios.Controls.Add(this.grillaUsuarios);
            this.gbListadoUsuarios.Location = new System.Drawing.Point(27, 12);
            this.gbListadoUsuarios.Name = "gbListadoUsuarios";
            this.gbListadoUsuarios.Size = new System.Drawing.Size(912, 308);
            this.gbListadoUsuarios.TabIndex = 3;
            this.gbListadoUsuarios.TabStop = false;
            this.gbListadoUsuarios.Text = "Listado de usuarios";
            // 
            // grillaUsuarios
            // 
            this.grillaUsuarios.AllowUserToAddRows = false;
            this.grillaUsuarios.AllowUserToDeleteRows = false;
            this.grillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario_id,
            this.usuario_nombre,
            this.usuario_pass,
            this.empleado_id,
            this.usuario_activo});
            this.grillaUsuarios.Location = new System.Drawing.Point(22, 19);
            this.grillaUsuarios.Name = "grillaUsuarios";
            this.grillaUsuarios.ReadOnly = true;
            this.grillaUsuarios.Size = new System.Drawing.Size(872, 271);
            this.grillaUsuarios.TabIndex = 0;
            this.grillaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaUsuarios_CellClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(14, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Modificar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(95, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(358, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.button1);
            this.gbBuscar.Controls.Add(this.label1);
            this.gbBuscar.Controls.Add(this.cbBuscarEmpleado);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(27, 326);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(443, 99);
            this.gbBuscar.TabIndex = 7;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mostrar todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID del empleado:";
            // 
            // cbBuscarEmpleado
            // 
            this.cbBuscarEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarEmpleado.FormattingEnabled = true;
            this.cbBuscarEmpleado.Location = new System.Drawing.Point(174, 37);
            this.cbBuscarEmpleado.Name = "cbBuscarEmpleado";
            this.cbBuscarEmpleado.Size = new System.Drawing.Size(119, 21);
            this.cbBuscarEmpleado.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbEdicion
            // 
            this.gbEdicion.Controls.Add(this.btnActualizar);
            this.gbEdicion.Controls.Add(this.btnEliminar);
            this.gbEdicion.Location = new System.Drawing.Point(751, 326);
            this.gbEdicion.Name = "gbEdicion";
            this.gbEdicion.Size = new System.Drawing.Size(188, 53);
            this.gbEdicion.TabIndex = 9;
            this.gbEdicion.TabStop = false;
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.btnAgregar);
            this.gbAgregar.Location = new System.Drawing.Point(638, 325);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(107, 54);
            this.gbAgregar.TabIndex = 10;
            this.gbAgregar.TabStop = false;
            // 
            // usuario_id
            // 
            this.usuario_id.DataPropertyName = "USUARIO_ID";
            this.usuario_id.HeaderText = "ID USER";
            this.usuario_id.Name = "usuario_id";
            this.usuario_id.ReadOnly = true;
            this.usuario_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usuario_id.Width = 40;
            // 
            // usuario_nombre
            // 
            this.usuario_nombre.DataPropertyName = "USUARIO_NOMBRE";
            this.usuario_nombre.HeaderText = "USERNAME";
            this.usuario_nombre.Name = "usuario_nombre";
            this.usuario_nombre.ReadOnly = true;
            this.usuario_nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usuario_nombre.Width = 80;
            // 
            // usuario_pass
            // 
            this.usuario_pass.DataPropertyName = "USUARIO_PASS";
            this.usuario_pass.HeaderText = "CONTRASENA";
            this.usuario_pass.Name = "usuario_pass";
            this.usuario_pass.ReadOnly = true;
            this.usuario_pass.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usuario_pass.Width = 80;
            // 
            // empleado_id
            // 
            this.empleado_id.DataPropertyName = "EMPLEADO_ID";
            this.empleado_id.HeaderText = "ID EMPLEADO";
            this.empleado_id.Name = "empleado_id";
            this.empleado_id.ReadOnly = true;
            this.empleado_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.empleado_id.Width = 80;
            // 
            // usuario_activo
            // 
            this.usuario_activo.DataPropertyName = "USUARIO_ACTIVO";
            this.usuario_activo.HeaderText = "ACTIVO";
            this.usuario_activo.Name = "usuario_activo";
            this.usuario_activo.ReadOnly = true;
            this.usuario_activo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usuario_activo.Width = 50;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 632);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.gbEdicion);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbListadoUsuarios);
            this.Controls.Add(this.gbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbListadoUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.gbEdicion.ResumeLayout(false);
            this.gbAgregar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtRepetirPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbListadoUsuarios;
        private System.Windows.Forms.DataGridView grillaUsuarios;
        private System.Windows.Forms.Label lblEmpleadoId;
        private System.Windows.Forms.ComboBox cbEmpleadoId;
        private System.Windows.Forms.CheckBox chkInactivo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBuscarEmpleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbEdicion;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_activo;
    }
}