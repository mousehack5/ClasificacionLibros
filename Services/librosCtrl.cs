/*
 * Created by SharpDevelop.
 * User: Mousepower
 * Date: 06/10/2014
 * Time: 11:09 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasificacionLibros.DAO;
using System.Data;

namespace ClasificacionLibros.Services
{
public class librosCtrl
	{
	
		librosDAO oLibrosDAO = new librosDAO();
		
		public DataSet devuelveLibros(object obj)
		{
			DataSet ds = new DataSet();
			ds = oLibrosDAO.devuelveLibro(obj);
			return ds;
		}
		
		public int creaLibros(object obj)
		{
			int i = oLibrosDAO.creaLibros(obj);
			if(i<=0)
			{
				return 0;
			}
			return 1;
		}
		public int RegresaMaxLibros()
		{
			int max = 0;
			max = oLibrosDAO.devuelveMAxLibros();
			return max;
		}
		public int modificaLibros(object obj)
		{
			int i = oLibrosDAO.modificaLibros(obj);
			if (i<=0)
			{
				return 0;
				
			}
			return 1;
		}
		
		public int eliminaLibros(object obj)
		{
			int i = oLibrosDAO.eliminaLibros(obj);
			if(i<=0)
			{
				return 0;
			}
			return 1;
		}
			
			
		}
	}

