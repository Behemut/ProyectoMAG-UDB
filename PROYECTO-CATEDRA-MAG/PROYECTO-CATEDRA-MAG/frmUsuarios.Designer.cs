namespace PROYECTO_CATEDRA_MAG
{
    partial class frmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtDUI = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbTipoUsuario = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtContraseña = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.txtEditarDUI = new System.Windows.Forms.MaskedTextBox();
            this.cmbEditarTipo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txtEditarUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtEditarContraseña = new MetroFramework.Controls.MetroTextBox();
            this.pbModificar = new System.Windows.Forms.PictureBox();
            this.txtEditarApellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtEditarNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtEditarID = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            this.dgvUsuarios = new MetroFramework.Controls.MetroGrid();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(300, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "USUARIOS";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(44, 87);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(595, 407);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroTabPage1.Controls.Add(this.btnGuardar);
            this.metroTabPage1.Controls.Add(this.txtUsuario);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.txtID);
            this.metroTabPage1.Controls.Add(this.btnIngresar);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.txtDUI);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.cmbTipoUsuario);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.txtContraseña);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.txtApellido);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.txtNombre);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.pictureBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(587, 365);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "AGREGAR USUARIOS";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(400, 304);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 44);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "GUARDAR USUARIO";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(302, 158);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(251, 23);
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.UseCustomBackColor = true;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.UseStyleColors = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            this.txtUsuario.Validated += new System.EventHandler(this.txtUsuario_Validated);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(186, 156);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(98, 25);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "USUARIO:";
            this.metroLabel10.UseStyleColors = true;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.AliceBlue;
            this.txtID.Location = new System.Drawing.Point(304, 61);
            this.txtID.Mask = "9999";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(249, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.txtID_Validating);
            this.txtID.Validated += new System.EventHandler(this.txtID_Validated);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(234, 304);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(121, 44);
            this.btnIngresar.TabIndex = 17;
            this.btnIngresar.Text = "INGRESAR USUARIO";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(186, 184);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(139, 25);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "CONTRASEÑA:";
            this.metroLabel9.UseStyleColors = true;
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDUI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDUI.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtDUI.Location = new System.Drawing.Point(329, 224);
            this.txtDUI.Mask = "00000000-0";
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(224, 23);
            this.txtDUI.TabIndex = 6;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(204, 22);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(194, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "AGREGAR USUARIOS";
            this.metroLabel7.UseStyleColors = true;
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.ItemHeight = 24;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(365, 257);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(190, 30);
            this.cmbTipoUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbTipoUsuario.TabIndex = 7;
            this.cmbTipoUsuario.UseCustomBackColor = true;
            this.cmbTipoUsuario.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(186, 257);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(173, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "TIPO DE USUARIO:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txtContraseña.CustomButton.Image = null;
            this.txtContraseña.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.txtContraseña.CustomButton.Name = "";
            this.txtContraseña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContraseña.CustomButton.TabIndex = 1;
            this.txtContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContraseña.CustomButton.UseSelectable = true;
            this.txtContraseña.CustomButton.Visible = false;
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.Lines = new string[0];
            this.txtContraseña.Location = new System.Drawing.Point(325, 186);
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.ShortcutsEnabled = true;
            this.txtContraseña.Size = new System.Drawing.Size(230, 23);
            this.txtContraseña.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.UseCustomBackColor = true;
            this.txtContraseña.UseSelectable = true;
            this.txtContraseña.UseStyleColors = true;
            this.txtContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.Validating += new System.ComponentModel.CancelEventHandler(this.txtContraseña_Validating);
            this.txtContraseña.Validated += new System.EventHandler(this.txtContraseña_Validated);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(186, 224);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "DUI:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txtApellido.CustomButton.Image = null;
            this.txtApellido.CustomButton.Location = new System.Drawing.Point(229, 1);
            this.txtApellido.CustomButton.Name = "";
            this.txtApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.CustomButton.TabIndex = 1;
            this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido.CustomButton.UseSelectable = true;
            this.txtApellido.CustomButton.Visible = false;
            this.txtApellido.ForeColor = System.Drawing.Color.White;
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(302, 125);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(251, 23);
            this.txtApellido.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.TabIndex = 3;
            this.txtApellido.UseCustomBackColor = true;
            this.txtApellido.UseSelectable = true;
            this.txtApellido.UseStyleColors = true;
            this.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellido_Validating);
            this.txtApellido.Validated += new System.EventHandler(this.txtApellido_Validated);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(186, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "APELLIDO:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(304, 87);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(249, 23);
            this.txtNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.TabIndex = 2;
            this.txtNombre.UseCustomBackColor = true;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.UseStyleColors = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(186, 87);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "NOMBRE:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(186, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "ID:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PROYECTO_CATEDRA_MAG.Properties.Resources.add_user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.txtEditarDUI);
            this.metroTabPage2.Controls.Add(this.cmbEditarTipo);
            this.metroTabPage2.Controls.Add(this.metroLabel16);
            this.metroTabPage2.Controls.Add(this.metroLabel17);
            this.metroTabPage2.Controls.Add(this.txtEditarUsuario);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.metroLabel15);
            this.metroTabPage2.Controls.Add(this.txtEditarContraseña);
            this.metroTabPage2.Controls.Add(this.pbModificar);
            this.metroTabPage2.Controls.Add(this.txtEditarApellido);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.txtEditarNombre);
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.txtEditarID);
            this.metroTabPage2.Controls.Add(this.metroLabel11);
            this.metroTabPage2.Controls.Add(this.pbEliminar);
            this.metroTabPage2.Controls.Add(this.pbActualizar);
            this.metroTabPage2.Controls.Add(this.dgvUsuarios);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(587, 365);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "CONTROL DE USUARIOS";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // txtEditarDUI
            // 
            this.txtEditarDUI.BackColor = System.Drawing.Color.AliceBlue;
            this.txtEditarDUI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarDUI.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEditarDUI.Location = new System.Drawing.Point(388, 289);
            this.txtEditarDUI.Mask = "00000000-0";
            this.txtEditarDUI.Name = "txtEditarDUI";
            this.txtEditarDUI.Size = new System.Drawing.Size(108, 23);
            this.txtEditarDUI.TabIndex = 31;
            // 
            // cmbEditarTipo
            // 
            this.cmbEditarTipo.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbEditarTipo.ForeColor = System.Drawing.Color.White;
            this.cmbEditarTipo.FormattingEnabled = true;
            this.cmbEditarTipo.ItemHeight = 23;
            this.cmbEditarTipo.Location = new System.Drawing.Point(388, 325);
            this.cmbEditarTipo.Name = "cmbEditarTipo";
            this.cmbEditarTipo.Size = new System.Drawing.Size(121, 29);
            this.cmbEditarTipo.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbEditarTipo.TabIndex = 32;
            this.cmbEditarTipo.UseCustomBackColor = true;
            this.cmbEditarTipo.UseSelectable = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(243, 325);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(132, 19);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel16.TabIndex = 34;
            this.metroLabel16.Text = "TIPO DE USUARIO:";
            this.metroLabel16.UseStyleColors = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(267, 288);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(37, 19);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel17.TabIndex = 33;
            this.metroLabel17.Text = "DUI:";
            this.metroLabel17.UseStyleColors = true;
            // 
            // txtEditarUsuario
            // 
            this.txtEditarUsuario.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txtEditarUsuario.CustomButton.Image = null;
            this.txtEditarUsuario.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtEditarUsuario.CustomButton.Name = "";
            this.txtEditarUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEditarUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditarUsuario.CustomButton.TabIndex = 1;
            this.txtEditarUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEditarUsuario.CustomButton.UseSelectable = true;
            this.txtEditarUsuario.CustomButton.Visible = false;
            this.txtEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.txtEditarUsuario.Lines = new string[0];
            this.txtEditarUsuario.Location = new System.Drawing.Point(94, 333);
            this.txtEditarUsuario.MaxLength = 32767;
            this.txtEditarUsuario.Name = "txtEditarUsuario";
            this.txtEditarUsuario.PasswordChar = '\0';
            this.txtEditarUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEditarUsuario.SelectedText = "";
            this.txtEditarUsuario.SelectionLength = 0;
            this.txtEditarUsuario.SelectionStart = 0;
            this.txtEditarUsuario.ShortcutsEnabled = true;
            this.txtEditarUsuario.Size = new System.Drawing.Size(105, 23);
            this.txtEditarUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditarUsuario.TabIndex = 27;
            this.txtEditarUsuario.UseCustomBackColor = true;
            this.txtEditarUsuario.UseSelectable = true;
            this.txtEditarUsuario.UseStyleColors = true;
            this.txtEditarUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEditarUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarUsuario.Leave += new System.EventHandler(this.txtEditarUsuario_Leave);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(3, 333);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(75, 19);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel14.TabIndex = 30;
            this.metroLabel14.Text = "USUARIO:";
            this.metroLabel14.UseStyleColors = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(257, 257);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(107, 19);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel15.TabIndex = 29;
            this.metroLabel15.Text = "CONTRASEÑA:";
            this.metroLabel15.UseStyleColors = true;
            // 
            // txtEditarContraseña
            // 
            this.txtEditarContraseña.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txtEditarContraseña.CustomButton.Image = null;
            this.txtEditarContraseña.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.txtEditarContraseña.CustomButton.Name = "";
            this.txtEditarContraseña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEditarContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditarContraseña.CustomButton.TabIndex = 1;
            this.txtEditarContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEditarContraseña.CustomButton.UseSelectable = true;
            this.txtEditarContraseña.CustomButton.Visible = false;
            this.txtEditarContraseña.ForeColor = System.Drawing.Color.White;
            this.txtEditarContraseña.Lines = new string[0];
            this.txtEditarContraseña.Location = new System.Drawing.Point(388, 254);
            this.txtEditarContraseña.MaxLength = 32767;
            this.txtEditarContraseña.Name = "txtEditarContraseña";
            this.txtEditarContraseña.PasswordChar = '\0';
            this.txtEditarContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEditarContraseña.SelectedText = "";
            this.txtEditarContraseña.SelectionLength = 0;
            this.txtEditarContraseña.SelectionStart = 0;
            this.txtEditarContraseña.ShortcutsEnabled = true;
            this.txtEditarContraseña.Size = new System.Drawing.Size(106, 23);
            this.txtEditarContraseña.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditarContraseña.TabIndex = 28;
            this.txtEditarContraseña.UseCustomBackColor = true;
            this.txtEditarContraseña.UseSelectable = true;
            this.txtEditarContraseña.UseStyleColors = true;
            this.txtEditarContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEditarContraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarContraseña.Leave += new System.EventHandler(this.txtEditarContraseña_Leave);
       
            // 
            // pbModificar
            // 
            this.pbModificar.Image = global::PROYECTO_CATEDRA_MAG.Properties.Resources.icon_save;
            this.pbModificar.Location = new System.Drawing.Point(532, 314);
            this.pbModificar.Name = "pbModificar";
            this.pbModificar.Size = new System.Drawing.Size(41, 42);
            this.pbModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModificar.TabIndex = 26;
            this.pbModificar.TabStop = false;
            this.pbModificar.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // txtEditarApellido
            // 
            this.txtEditarApellido.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txtEditarApellido.CustomButton.Image = null;
            this.txtEditarApellido.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtEditarApellido.CustomButton.Name = "";
            this.txtEditarApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEditarApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditarApellido.CustomButton.TabIndex = 1;
            this.txtEditarApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEditarApellido.CustomButton.UseSelectable = true;
            this.txtEditarApellido.CustomButton.Visible = false;
            this.txtEditarApellido.ForeColor = System.Drawing.Color.White;
            this.txtEditarApellido.Lines = new string[0];
            this.txtEditarApellido.Location = new System.Drawing.Point(94, 304);
            this.txtEditarApellido.MaxLength = 32767;
            this.txtEditarApellido.Name = "txtEditarApellido";
            this.txtEditarApellido.PasswordChar = '\0';
            this.txtEditarApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEditarApellido.SelectedText = "";
            this.txtEditarApellido.SelectionLength = 0;
            this.txtEditarApellido.SelectionStart = 0;
            this.txtEditarApellido.ShortcutsEnabled = true;
            this.txtEditarApellido.Size = new System.Drawing.Size(105, 23);
            this.txtEditarApellido.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditarApellido.TabIndex = 24;
            this.txtEditarApellido.UseCustomBackColor = true;
            this.txtEditarApellido.UseSelectable = true;
            this.txtEditarApellido.UseStyleColors = true;
            this.txtEditarApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEditarApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditarApellido_KeyPress);
            this.txtEditarApellido.Leave += new System.EventHandler(this.txtEditarApellido_Leave);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(3, 304);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(78, 19);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel13.TabIndex = 25;
            this.metroLabel13.Text = "APELLIDO:";
            this.metroLabel13.UseStyleColors = true;
            // 
            // txtEditarNombre
            // 
            this.txtEditarNombre.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // 
            // 
            this.txtEditarNombre.CustomButton.Image = null;
            this.txtEditarNombre.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtEditarNombre.CustomButton.Name = "";
            this.txtEditarNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEditarNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditarNombre.CustomButton.TabIndex = 1;
            this.txtEditarNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEditarNombre.CustomButton.UseSelectable = true;
            this.txtEditarNombre.CustomButton.Visible = false;
            this.txtEditarNombre.ForeColor = System.Drawing.Color.White;
            this.txtEditarNombre.Lines = new string[0];
            this.txtEditarNombre.Location = new System.Drawing.Point(94, 275);
            this.txtEditarNombre.MaxLength = 32767;
            this.txtEditarNombre.Name = "txtEditarNombre";
            this.txtEditarNombre.PasswordChar = '\0';
            this.txtEditarNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEditarNombre.SelectedText = "";
            this.txtEditarNombre.SelectionLength = 0;
            this.txtEditarNombre.SelectionStart = 0;
            this.txtEditarNombre.ShortcutsEnabled = true;
            this.txtEditarNombre.Size = new System.Drawing.Size(105, 23);
            this.txtEditarNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEditarNombre.TabIndex = 22;
            this.txtEditarNombre.UseCustomBackColor = true;
            this.txtEditarNombre.UseSelectable = true;
            this.txtEditarNombre.UseStyleColors = true;
            this.txtEditarNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEditarNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditarNombre_KeyPress);
            this.txtEditarNombre.Leave += new System.EventHandler(this.txtEditarNombre_Leave);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(3, 275);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(73, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel12.TabIndex = 23;
            this.metroLabel12.Text = "NOMBRE:";
            this.metroLabel12.UseStyleColors = true;
            // 
            // txtEditarID
            // 
            this.txtEditarID.BackColor = System.Drawing.Color.AliceBlue;
            this.txtEditarID.Location = new System.Drawing.Point(94, 246);
            this.txtEditarID.Mask = "9999";
            this.txtEditarID.Name = "txtEditarID";
            this.txtEditarID.ReadOnly = true;
            this.txtEditarID.Size = new System.Drawing.Size(68, 20);
            this.txtEditarID.TabIndex = 20;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(11, 246);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(27, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel11.TabIndex = 21;
            this.metroLabel11.Text = "ID:";
            this.metroLabel11.UseStyleColors = true;
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = global::PROYECTO_CATEDRA_MAG.Properties.Resources.eliminar_icono_png_7;
            this.pbEliminar.Location = new System.Drawing.Point(532, 256);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(41, 42);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminar.TabIndex = 19;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbActualizar
            // 
            this.pbActualizar.Image = global::PROYECTO_CATEDRA_MAG.Properties.Resources.icon_actualizar;
            this.pbActualizar.Location = new System.Drawing.Point(518, 3);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(40, 45);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActualizar.TabIndex = 18;
            this.pbActualizar.TabStop = false;
            this.pbActualizar.Click += new System.EventHandler(this.pbActualizar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.Location = new System.Drawing.Point(11, 52);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.ShowEditingIcon = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(555, 172);
            this.dgvUsuarios.TabIndex = 16;
            this.dgvUsuarios.DoubleClick += new System.EventHandler(this.dgvUsuarios_DoubleClick);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(202, 16);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(221, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "CONTROL DE USUARIOS";
            this.metroLabel8.UseStyleColors = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbRegresar
            // 
            this.pbRegresar.Image = global::PROYECTO_CATEDRA_MAG.Properties.Resources.back;
            this.pbRegresar.Location = new System.Drawing.Point(48, 25);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(58, 56);
            this.pbRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRegresar.TabIndex = 17;
            this.pbRegresar.TabStop = false;
            this.pbRegresar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 517);
            this.Controls.Add(this.pbRegresar);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtContraseña;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbTipoUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid dgvUsuarios;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.PictureBox pbRegresar;
        private System.Windows.Forms.MaskedTextBox txtDUI;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.MaskedTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbActualizar;
        private MetroFramework.Controls.MetroTextBox txtEditarNombre;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.MaskedTextBox txtEditarID;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.PictureBox pbModificar;
        private MetroFramework.Controls.MetroTextBox txtEditarApellido;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtEditarUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtEditarContraseña;
        private System.Windows.Forms.MaskedTextBox txtEditarDUI;
        private MetroFramework.Controls.MetroComboBox cmbEditarTipo;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
    }
}