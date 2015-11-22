/*
 * Created by SharpDevelop.
 * User: Mousepower
 * Date: 07/10/2014
 * Time: 10:46 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ClasificacionLibros.GUI
{
	partial class frmlibros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlibros));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEjemplar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnBuscar.Location = new System.Drawing.Point(835, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 31);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "&BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(224, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(43, 24);
            this.txtCodigo.TabIndex = 13;
            this.txtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_LibTextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoKeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "&CODIGO";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "&SALÓN";
            // 
            // txtSalon
            // 
            this.txtSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalon.Location = new System.Drawing.Point(224, 64);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.Size = new System.Drawing.Size(43, 24);
            this.txtSalon.TabIndex = 0;
            this.txtSalon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSalonKeyDown);
            this.txtSalon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSalonKeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "CATE&GORIA:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(370, 20);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(185, 24);
            this.txtCategoria.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "&FAMILIA:";
            // 
            // txtFamilia
            // 
            this.txtFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilia.Location = new System.Drawing.Point(370, 59);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(185, 24);
            this.txtFamilia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "&TÍTULO:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(370, 100);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(185, 24);
            this.txtTitulo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "A&UTOR:";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(657, 20);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(155, 24);
            this.txtAutor.TabIndex = 5;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            this.txtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutor_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(573, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "E&DITORIAL:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.Location = new System.Drawing.Point(657, 62);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(155, 24);
            this.txtEditorial.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "FEC&HA:";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(657, 103);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(155, 24);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.TextChanged += new System.EventHandler(this.TxtFechaTextChanged);
            this.txtFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFechaKeyDown);
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(144, 163);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(879, 359);
            this.dgvLibros.TabIndex = 17;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLibrosCellContentClick);
            this.dgvLibros.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvLibrosRowHeaderMouseClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.Location = new System.Drawing.Point(835, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 31);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "&AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditar.Location = new System.Drawing.Point(836, 83);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 31);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "&EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(939, 9);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 31);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "&LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(939, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 31);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "E&LIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
            // 
            // txtEjemplar
            // 
            this.txtEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjemplar.Location = new System.Drawing.Point(224, 100);
            this.txtEjemplar.Name = "txtEjemplar";
            this.txtEjemplar.Size = new System.Drawing.Size(43, 24);
            this.txtEjemplar.TabIndex = 1;
            this.txtEjemplar.TextChanged += new System.EventHandler(this.TxtEjemplarTextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(145, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "&EJEMPLAR:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(939, 84);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 29);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(885, 526);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(313, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "EL YUCATRACHO. TODOS LOS DERECHOS RESERVADOS";
            this.label10.Click += new System.EventHandler(this.Label10Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 539);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(835, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "&GENERAR REPORTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmlibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEjemplar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFamilia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmlibros";
            this.Text = "frmlibros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		//private DevComponents.DotNetBar.ButtonItem buttonItem3;
		//private DevComponents.DotNetBar.ButtonItem buttonItem2;
		//private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtEjemplar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridView dgvLibros;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtEditorial;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtFamilia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCategoria;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSalon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Button btnBuscar;
	}
}
