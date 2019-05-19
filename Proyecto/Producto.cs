using System;
using System.IO;
using System.Collections.Generic;

namespace Proyecto
{
    class Producto: IComparable
    {
        public string Codigo{get; set;}
        public string Descripcion{get;set;}
        public decimal Precio{get;set;}
        public int Departamento{get;set;}
        public int Likes{get;set;}   

        public Producto(string codigo, string descripcion, decimal precio, int departameno, int likes)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Departamento = departameno;
            this.Likes = likes;                
        }         
        
        public Producto(){}  

        public override string ToString()
        {
            return String.Format("Código :{0} \nDescripción: {1} \nPrecio {2}\nDepartamento: {3}\nLikes: {4}\n",Codigo,Descripcion,Precio,Departamento,Likes);            
        }

        public int CompareTo(object obj)
        {
            return Likes.CompareTo((obj as Producto).Likes);
        }    
    }
}