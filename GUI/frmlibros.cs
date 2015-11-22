/*
 * Created by SharpDevelop.
 * User: Mousepower
 * Date: 06/10/2014
 * Time: 09:06 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasificacionLibros.BO;
using ClasificacionLibros.Services;
//using ClasificacionLibros.GUI;
using System.IO;
using System.Drawing.Imaging;
//using ClasificacionLibros.GUI.Reportes;

namespace ClasificacionLibros.GUI
{
	
	public partial class frmlibros : Form
	{
		DataTable dtReporte;
		
		public frmlibros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//this.Buscar();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void Buscar()
		{
			librosBO oLibrosBo = new librosBO();
			librosCtrl oLibrosCtrl = new librosCtrl();
			if(txtCodigo.Text.Trim().Length != 0)
			
			{
				//convertimos lo que está en el txtCodigo a entero por que nuestro atributo codigo es de tipo entero
                oLibrosBo.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
			}
			if(txtSalon.Text.Trim().Length !=0)
			{
				oLibrosBo.Salon = Convert.ToInt32(txtSalon.Text.Trim());
			}
			
			if(txtFamilia.Text.Trim().Length !=0)
			{
				oLibrosBo.Familia = txtFamilia.Text.Trim();
			}
			if(txtAutor.Text.Trim().Length !=0)
			{
				oLibrosBo.Autor =txtAutor.Text.Trim();
			}
			if(txtCategoria.Text.Trim().Length !=0)
			{
				oLibrosBo.Categoria = txtCategoria.Text.Trim();
			}
			if(txtEditorial.Text.Trim().Length !=0)
			{
				oLibrosBo.Editorial= txtEditorial.Text.Trim();
			}
			if(txtTitulo.Text.Trim().Length !=0)
			{
				oLibrosBo.Titulo = txtTitulo.Text.Trim();
			}
			if(txtFecha.Text.Trim().Length !=0)
			{
				oLibrosBo.Fecha = txtFecha.Text.Trim();
			}
			if(txtEjemplar.Text.Trim().Length !=0)
			{
				oLibrosBo.Ejemplar = txtEjemplar.Text.Trim();
			}
			//if(txtEjemplares.Text.Trim().Length !=0)
			//{
				
		//	}
			dtReporte = oLibrosCtrl.devuelveLibros(oLibrosBo).Tables [0];
            dgvLibros.DataSource = dtReporte;
		}
		
		//CODIGO QUE AGREGA LIBROS
		public void AgregaLibros()
		{
			string mensaje = "";
			int estado =1;
			int i =0;
			
			BO.librosBO oLibros = new BO.librosBO();
			Services.librosCtrl olibrosCtrl = new Services.librosCtrl();
			
			
			if(txtSalon.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca el Salon del libro, solo números \n";
				estado = 0;
			}
			
			if(txtFamilia.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca la Familia del libro \n";
				estado = 0;
			}
			if(txtAutor.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca el Autor del libro \n";
				estado = 0;
			}
			if(txtCategoria.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca la Categoria del libro \n";
				estado = 0;
			}
			if(txtEditorial.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca la Editorial del libro \n";
				estado = 0;
			}
			if(txtTitulo.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca el Titulo del libro \n";
				estado = 0;
			}
			if(txtFecha.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca la Fecha del libro \n";
				estado = 0;
			}
			if(txtEjemplar.Text.Trim().Length==0)
			{
				mensaje = mensaje + "Introduzca  el Ejemplar del libro \n";
				estado = 0;
			}
			
			if (estado ==0)
			{
				MessageBox.Show(mensaje);
				return;
			}
			
			else
			{
				
				
				oLibros.Salon = Convert.ToInt32(txtSalon.Text.Trim());
				oLibros.Categoria = txtCategoria.Text.Trim();
				oLibros.Familia = txtFamilia.Text.Trim();
				oLibros.Titulo = txtTitulo.Text.Trim();
				oLibros.Autor = txtAutor.Text.Trim();
				oLibros.Editorial = txtEditorial.Text.Trim();
				oLibros.Fecha = txtFecha.Text.Trim();
				oLibros.Ejemplar = txtEjemplar.Text.Trim();
				
				i = olibrosCtrl.creaLibros(oLibros);
				if(i == 0)
				{
					MessageBox.Show(":( La información no se pudo crear correctamente");
                    }
                else
                    {
                	this.Limpiar();
                    this.Buscar();
                    MessageBox.Show(":) Se ha creado un nuevo Libro en la Base de Datos.");
                    
                    
                    }
                
			
		}
			
		}
			//CODIGO PARA MODIFICAR LIBROS
			public void ModificaLibros()
			{
				int i= 0;
				
				BO.librosBO oLibros = new BO.librosBO();
			Services.librosCtrl olibrosCtrl = new Services.librosCtrl();
			if(txtCodigo.Text.Trim().Length != 0)
                {
			oLibros.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
			oLibros.Salon = Convert.ToInt32(txtSalon.Text.Trim());
			oLibros.Categoria = txtCategoria.Text.Trim();
			oLibros.Familia = txtFamilia.Text.Trim();
			oLibros.Titulo = txtTitulo.Text.Trim();
			oLibros.Autor = txtAutor.Text.Trim();
			oLibros.Editorial = txtEditorial.Text.Trim();
			oLibros.Fecha = txtFecha.Text.Trim();
			oLibros.Ejemplar = txtEjemplar.Text.Trim();
		
			
			//MessageBox.Show("i vale " +i);
			
			
			string mensaje = "";
			int estado =1;
				
			if(txtSalon.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca el Salon del libro \n";
				estado = 0;
			}
			if(txtFamilia.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca la Familia del libro \n";
				estado = 0;
			}
			if(txtAutor.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca el Autor del libro \n";
				estado = 0;
			}
			if(txtCategoria.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca la Categoria del libro \n";
				estado = 0;
			}
			if(txtEditorial.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca la Editorial del libro \n";
				estado = 0;
			}
			if(txtTitulo.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca el Titulo del libro \n";
				estado = 0;
			}
			if(txtFecha.Text.Trim().Length ==0)
			{
				mensaje = mensaje + "Introduzca la Fecha del libro \n";
				estado = 0;
			}
			if(txtEjemplar.Text.Trim().Length==0)
			{
				mensaje = mensaje + "Introduzca  el Ejemplar del libro \n";
				estado = 0;
			}
			
			if (estado == 0)
			{
				MessageBox.Show(mensaje);
				return;
			}
			
			else
			{
				
				
				
				i= olibrosCtrl.modificaLibros(oLibros);
				
				if(i == 0)
				{
					MessageBox.Show(":( La información NO se pudo modificar correctamente");
                    }
                else
                {
                    
                    
                    this.Limpiar();
                    this.Buscar();
                    MessageBox.Show(":) Se ha modificado la información correctamente.");
                    
                    }
			
                
                
                	
			
			
						
			
			
			
			
			}
			
			}
			}
			//CODIGO PARA ELIMINAR LIBROS
			
					
			
	public void EliminaLibros()
			{
				int i= 0;
				
								
				BO.librosBO oLibros = new BO.librosBO();
				Services.librosCtrl olibrosCtrl = new Services.librosCtrl();
					
			//creo una condicion para que no marque error si no pongo nada en el campo de codigo

            if(txtCodigo.Text.Trim().Length != 0)
                {
            	
                if(MessageBox.Show("¿Esta Seguro que desea eliminar el Libro?" , "Confirmación" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.No)
                    {
                    this.Limpiar();
                    return;
                    }
            
                else{
                	//convertimos lo que está en el txtCodigo_Lib a entero por que nuestro atributo codigo es de tipo entero
                	oLibros.Codigo = Convert.ToInt32(txtCodigo.Text.Trim());
                	i = olibrosCtrl.eliminaLibros(oLibros);
                	
                    if(i == 0)
                        {
                        if(MessageBox.Show("La información no se pudo eliminar" , "Error" , MessageBoxButtons.RetryCancel , MessageBoxIcon.Error) == DialogResult.Retry)
                            {
                            return;
                            }
                        }
                    else
                        {
                            this.Limpiar();
                            this.Buscar();
                        MessageBox.Show("Se ha eliminado el Libro!" , "Correcto");
                        
                        }
                    
                }
                	
                	
                    
                        
            }                //oProveedor.Codigo_P = Convert.ToInt32(txtCodigo.Text.Trim());

			 else
                {
                MessageBox.Show("Como mínimo el Campo Código debe tener un valor");


                }
				
			}//fin del public eliminaLibros
			
	

        //Codigo para limpiar campos
        
        public void Limpiar()
        {
        	txtCodigo.Clear();
        	txtSalon.Clear();
        	txtCategoria.Clear();
        	txtFamilia.Clear();
        	txtAutor.Clear();
        	txtEditorial.Clear();
        	txtFecha.Clear();
        	txtTitulo.Clear();
        	txtEjemplar.Clear();

		
		}
		
	//	void Label6Click(object sender, EventArgs e)
	//	{
			
	//	}
	
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Buscar();
		}
		
		void TxtCodigo_LibTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
			this.Buscar();
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			this.AgregaLibros();
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			this.ModificaLibros();
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			this.Limpiar();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			this.EliminaLibros();
		}
		
		void DgvLibrosRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			int codigo = Convert.ToInt32(dgvLibros.CurrentRow.Cells["codigo"].Value);
			int salon =  Convert.ToInt32(dgvLibros.CurrentRow.Cells["salon"].Value);
       		string categoria = (string) dgvLibros.CurrentRow.Cells["categoria"].Value;
       		string Familia = (string) dgvLibros.CurrentRow.Cells["familia"].Value;
       		string titulo = (string) dgvLibros.CurrentRow.Cells["titulo"].Value;
       		string autor = (string) dgvLibros.CurrentRow.Cells["autor"].Value;
       		string editorial = (string) dgvLibros.CurrentRow.Cells["editorial"].Value;
       		string fecha = (string) dgvLibros.CurrentRow.Cells["fecha"].Value;
       		string ejemplar = (string) dgvLibros.CurrentRow.Cells["ejemplar"].Value;
       		
       		
       		
       		txtCodigo.Text = Convert .ToString(codigo);
       		txtSalon.Text = Convert.ToString(salon);
       		txtCategoria.Text = categoria;
       		txtFamilia.Text = Familia;
       		txtTitulo.Text = titulo;
       		txtAutor.Text = autor;
       		txtEditorial.Text = editorial;
       		txtFecha.Text = fecha;
			txtEjemplar.Text = ejemplar;       		
		}
		
		
		
		void TxtEjemplarTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}
		
		void Label10Click(object sender, EventArgs e)
		{
			
		}
		
		void DgvLibrosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void TxtCodigoKeyPress(object sender, KeyPressEventArgs e)
		{
			if(Char.IsDigit(e.KeyChar))
                {
                e.Handled = false;
                }
            else
                if(Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                    e.Handled = false;
                    }
                else
                    {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                    } 
		}
		
		void TxtSalonKeyPress(object sender, KeyPressEventArgs e)
		{
			if(Char.IsDigit(e.KeyChar))
                {
                e.Handled = false;
                }
            else
                if(Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                    e.Handled = false;
                    }
                else
                    {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                    } 
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void TxtFechaTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void TxtFechaKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
                {
                btnAgregar.Focus();
                SendKeys.Send("\r");
                }
		}
		
		void TxtSalonKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
                {
                btnBuscar.Focus();
                SendKeys.Send("\r");
                
                }
		}

        private void button1_Click(object sender, EventArgs e)
        {
            frmCrystalReports oVisorFrmAlumno = new frmCrystalReports(dtReporte);
            oVisorFrmAlumno.ShowDialog();

        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                        {
                            //el resto de teclas pulsadas se desactivan
                            e.Handled = true;
                        } 
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }
}


}