//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Entidades
{
    public partial class compras_detalle
    {
        public long id { get; set; }
        public int folio_compra { get; set; }
        public string codigo_articulo { get; set; }
        public double cantidad { get; set; }
        public double precio { get; set; }
        public double tipo_cambio { get; set; }
        public string observacion { get; set; }
    }
    
}
