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
    public partial class compras
    {
        public long folio { get; set; }
        public string tipo_doc { get; set; }
        public System.DateTime f_emision { get; set; }
        public string codigo_proveedor { get; set; }
        public string referencia_proveedor { get; set; }
        public string forma_pago { get; set; }
        public double importe { get; set; }
        public double tipo_cambio { get; set; }
        public string estado { get; set; }
        public string observacion { get; set; }
    }
    
}