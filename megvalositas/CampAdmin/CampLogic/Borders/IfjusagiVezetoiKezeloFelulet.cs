///////////////////////////////////////////////////////////
//  Ifj�s�giVezet�iKezel�Fel�let.cs
//  Implementation of the Class Ifj�s�giVezet�iKezel�Fel�let
//  Generated by Enterprise Architect
//  Created on:      26-�pr.-2013 19:57:22
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CampLogic.KorcsoportVezetoFunkciok;
using CampLogic.IfjusagiVezetoFunkciok;
using CampLogic.TaborvezetoFunkciok;


namespace CampLogic.Borders {
	public class IfjusagiVezetoiKezeloFelulet : IIfjusagiVezetoiKezelo {

		public TaborozoImportKezelo _TaborozoImportKezelo;
		public TaborozoKezelo _TaborozoKezelo;

		public IfjusagiVezetoiKezeloFelulet(){
            _TaborozoKezelo = new TaborozoKezelo();
		}

		/// 
		/// <param name="Taborozo"></param>
		/// <param name="csoport"></param>
		public bool T�boroz�CsoporthozRendeles(Taborozo Taborozo, Csoport csoport){

			return false;
		}

        public bool T�boroz�Szob�hozRendel�s(Taborozo T�boroz�, Szoba Szoba)
        {
            throw new NotImplementedException();
        }


		/// 
		/// <param name="path"></param>
		public bool ImportFilebol(string path){

			return false;
		}

        public List<Taborozo> TaborozoListazas()
        {
            return _TaborozoKezelo.TaborozoListazas();
		}

		/// 
		/// <param name="t�boroz�"></param>
		public bool TaborozoModositasa(Taborozo taborozo){
            return _TaborozoKezelo.TaborozoModositasa(taborozo);
		}

		/// 
		/// <param name="T�boroz�"></param>
		/// <param name="Szoba"></param>
		public void TaborozoSzobahozRendeles(Taborozo T�boroz�, Szoba Szoba){

		}

		/// 
		/// <param name="taborozo"></param>
		public bool TaborozoTorles(Taborozo taborozo){

			return false;
		}

		///
		/// <param name="taborozo"></param>
		public bool UjTaborozo(Taborozo taborozo){
			return _TaborozoKezelo.UjTaborozo(taborozo);
		}



    }//end Ifj�s�giVezet�iKezel�Fel�let

}//end namespace Borders