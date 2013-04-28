///////////////////////////////////////////////////////////
//  KorcsoportKezelő.cs
//  Implementation of the Class KorcsoportKezelő
//  Generated by Enterprise Architect
//  Created on:      26-ápr.-2013 20:01:00
//  Original author: lovi88
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using KorcsoportVezetőFunkciók;
using Db;
namespace KorcsoportVezetőFunkciók {
	public class KorcsoportKezelő : ICsoportKezelő<Korcsoport> {

		public DbConnection conn = new DbConnection();

		public KorcsoportKezelő(){

		}
       



    
public bool  Letrehoz(Korcsoport csoport)
{
 	        conn.Korcsoportok.Add(csoport);
            conn.SaveChanges();

            return true;
}



public List<Korcsoport>  Listaz()
{
 	return (from k in conn.Korcsoportok select k).ToList<Korcsoport>();
}

public bool  Modosit(Korcsoport csoport)
{
 	 conn.SaveChanges();
     return true;
}

public bool  Torol(Korcsoport csoport)
{
 	conn.Korcsoportok.Remove(csoport);
     	 conn.SaveChanges();
     return true;
}
}
    }//end KorcsoportKezelő

}//end namespace KorcsoportVezetőFunkciók