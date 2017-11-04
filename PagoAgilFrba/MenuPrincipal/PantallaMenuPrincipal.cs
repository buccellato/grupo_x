using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.MenuPrincipal
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void AbmRolButton_Click(object sender, EventArgs e)
        {
            AbmRol.PantallaAbmRol abm_rol_view = new AbmRol.PantallaAbmRol();
            abm_rol_view.Show();
            this.Hide();
        }

        private void AbmUsuarioButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AbmClienteButton_Click(object sender, EventArgs e)
        {
            AbmCliente.PantallaPrincipalAbmCliente abm_cliente_view = new AbmCliente.PantallaPrincipalAbmCliente();
            abm_cliente_view.Show();
            this.Hide();
        }

        private void AbmEmpresaButton_Click(object sender, EventArgs e)
        {
            AbmEmpresa.PantallaAbmEmpresa abm_empresa_view = new AbmEmpresa.PantallaAbmEmpresa();
            abm_empresa_view.Show();
            this.Hide();
        }

        private void DevolucionesButton_Click(object sender, EventArgs e)
        {
            //Devoluciones.PantallaDevoluciones devoluciones_view = new 
        }

        private void AbmSucursalButton_Click(object sender, EventArgs e)
        {
            AbmSucursal.PantallaAbmSucursal abm_sucursal_view = new AbmSucursal.PantallaAbmSucursal();
            abm_sucursal_view.Show();
            this.Hide();
        }

        private void AbmFacturasButton_Click(object sender, EventArgs e)
        {
            AbmFactura.PantallaAbmFactura abm_factura_view = new AbmFactura.PantallaAbmFactura();
            abm_factura_view.Show();
            this.Hide();
        }

        private void RegistroPagoFacturasButton_Click(object sender, EventArgs e)
        {
            RegistroPago.PantallaRegistroPago registro_pago_view = new RegistroPago.PantallaRegistroPago();
            registro_pago_view.Show();
            this.Hide();
        }

        private void RendicionFacturasCobradasButtton_Click(object sender, EventArgs e)
        {
            Rendicion.PantallaRendicion rendicion_view = new Rendicion.PantallaRendicion();
            rendicion_view.Show();
            this.Hide();
        }

        private void ListadoEstadisticoButton_Click(object sender, EventArgs e)
        {
            ListadoEstadistico.PantallaListadoEstadistico listado_estadistico_view = new ListadoEstadistico.PantallaListadoEstadistico();
            listado_estadistico_view.Show();
            this.Hide();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
