//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos_GreenLife
{
    using System;
    
    public partial class spConsultarFacturasPorCliente_Result
    {
        public int idFactura { get; set; }
        public Nullable<int> idUsuario { get; set; }
        public int idCliente { get; set; }
        public System.DateTime fecha { get; set; }
        public string metodoDePago { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
    }
}
