using sistmBancoEd.Cola;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHospital
{
    public partial class frmMesaEntrada : Form
    {
        private clsCola cola;
        private clsListaCja listaParaCajas;
        private clsAtencionCl listaAtencion;

        public frmMesaEntrada()
        {
            InitializeComponent();
            cola = new clsCola();
            listaParaCajas = new clsListaCja();
            listaAtencion = new clsAtencionCl();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDniEntrada.Text) && !string.IsNullOrWhiteSpace(txtNombreEntrada.Text))
            {
                if (int.TryParse(txtDniEntrada.Text, out int dni))
                {
                    
                    Nodo nuevoNodo = new Nodo(dni, txtNombreEntrada.Text);

                    
                    bool agregado = cola.Agregar(nuevoNodo);

                    if (agregado)
                    {
                        // Si el nodo se agregó correctamente, recargamos la grilla
                        CargarDgvEntrada();

                        
                        txtDniEntrada.Clear();
                        txtNombreEntrada.Clear() ;
                    }
                    else
                    {
                        // Si el DNI ya estaba en la cola, mostramos un mensaje
                        MessageBox.Show("El DNI ya está en la cola.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido.");
                }
            }
            else
            {
                MessageBox.Show("El campo DNI está vacío.");
            }
        }
        private void CargarDgvEntrada()
        {
            // Limpiamos las filas y columnas existentes del DataGridView
            dgvIngreso.Rows.Clear();
            dgvIngreso.Columns.Clear();

            
            dgvIngreso.Columns.Add("Orden", "Orden" );
            dgvIngreso.Columns.Add("DNI", "DNI");
            dgvIngreso.Columns.Add("Nombre", "Nombre");
            
            List<Nodo> listaDeNodos = cola.ListarElementos();

            
            int orden = 1;

            
            foreach (var nodo in listaDeNodos)
            {
                if (nodo != null)
                {
                    
                    string dniString = nodo.DNI.ToString();
                    string nombre = nodo.Nombre;

                    dgvIngreso.Rows.Add(orden, dniString, nombre);

                    
                    orden++;
                }
                else
                {
                    Console.WriteLine("Nodo nulo encontrado.");
                }
            }
        }
        

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            Nodo nodoEliminado = cola.Eliminar();

            // Verifica si se eliminó un nodo
            if (nodoEliminado != null)
            {

                
                txtDniClientes.Text = nodoEliminado.DNI.ToString(); 

                txtNombreClientes.Text = nodoEliminado.Nombre.ToString(); 
                CargarDgvEntrada();
            }
            else
            {
               
                MessageBox.Show("No hay mas datos en la cola");
            }
        }

        private void btnAceptarClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDniClientes.Text))
            {
                MessageBox.Show("Debe haber un DNI."); 
                return; 
            }


            if (int.TryParse(txtDniClientes.Text, out int dni))
            {
                NodoLista nuevoNodo = new NodoLista(dni,txtNombreClientes.Text)
                {
                    Cliente = chkCliente.Checked 
                };
                
                
                if (rdCajas.Checked)
                {
                        //clsListaCja listaParaCaja = new clsListaCja();
                    
                    listaParaCajas.Insertar(nuevoNodo);

                    
                    CargarGrillaCaja();

                    
                    txtDniClientes.Clear();
                    txtNombreClientes.Clear() ;
                    rdAtencionClientes.Checked = false;
                    rdCajas.Checked = false; 
                }
                if (rdAtencionClientes.Checked)
                {
                    
                    

                    listaAtencion.Insertar(nuevoNodo);

                    GrillaAtencionCLiente();

                    
                    txtDniClientes.Clear();
                    txtNombreClientes.Clear();
                    rdAtencionClientes.Checked = false;
                    rdCajas.Checked = false; 
                }
                chkCliente.Checked = false;
            }


        }


        // Configuramos las columnas del DataGridView
        private void ConfigurarColumnas()
        {
            dgvCajas.Columns.Add("Orden", "Orden");
            dgvCajas.Columns.Add("DNI", "DNI");
            dgvCajas.Columns.Add("Nombre", "Nombre");
            dgvCajas.Columns.Add("Cliente", "Cliente");
        }



        private void CargarGrillaCaja()
        {
        
            dgvCajas.Rows.Clear();
            
            if (dgvCajas.Columns.Count == 0)
            {
                ConfigurarColumnas();
            }
            var nodos = listaParaCajas.Listar();

            
            int orden = 1; 
            foreach (var nodo in nodos)
            {
                dgvCajas.Rows.Add(orden++, nodo.DNI, nodo.Nombre, nodo.Cliente ? "Sí" : "No"); 
            }
        }

        private void GrillaAtencionCLiente()
        {
            
            dgvAtencionCliente.Rows.Clear();


            if (dgvAtencionCliente.Columns.Count == 0)
            {
                dgvAtencionCliente.Columns.Add("Orden", "Orden");
                dgvAtencionCliente.Columns.Add("DNI", "DNI");
                dgvAtencionCliente.Columns.Add("Nombre", "Nombre");
                dgvAtencionCliente.Columns.Add("Cliente", "Cliente");
            }

            // Listamos todos los nodos y los cargamos en el DataGridView
            var nodos = listaAtencion.Listar();

            // Cargamos los datos en el DataGridView
            int orden = 1; // Variable para llevar el orden de los nodos
            foreach (var nodo in nodos)
            {
                dgvAtencionCliente.Rows.Add(orden++, nodo.DNI, nodo.Nombre, nodo.Cliente ? "Sí" : "No"); 
            }
        }
        private bool primerInicioCaja = true;
        private void btnAtender_Click(object sender, EventArgs e)
        {
            NodoLista nodoAtendido;

            if (primerInicioCaja)
            {
                nodoAtendido = listaParaCajas.Atender();
                primerInicioCaja = false;
            }
            else
            {
                nodoAtendido = listaParaCajas.BuscarCliente();
                primerInicioCaja = true;
            }

            if (nodoAtendido != null)
            {
                txtClienteCajas.Text = nodoAtendido.DNI.ToString(); txtNombreCaja.Text = nodoAtendido.Nombre;
                CargarGrillaCaja();
            }
            else
            {
                MessageBox.Show("No hay más personas para atender.");
                txtClienteCajas.Clear(); txtNombreCaja.Clear();
            }
        }


        private bool primerInicioPersonal = true; // Variable para controlar si es el primer clic de personal

        private void btnAtenderAC_Click(object sender, EventArgs e)
        {
            NodoLista nodoAtendido;

            if (primerInicioPersonal)
            {
                // En el primer clic, atendemos al primer nodo de la lista personal
                nodoAtendido = listaAtencion.Atender();
                primerInicioPersonal = false; // Cambiamos el estado a no primer clic
            }
            else
            {
                // En clics subsecuentes, buscamos un nodo con Cliente
                nodoAtendido = listaAtencion.BuscarCliente();
                primerInicioPersonal = true;
            }

            // Verificamos si se obtuvo un nodo atendido
            if (nodoAtendido != null)
            {
                // Cargamos el DNI en el TextBox
                txtDniAtencion.Text = nodoAtendido.DNI.ToString(); // Convertimos el DNI a string y lo asignamos al TextBox
                txtClienteAtencion.Text = nodoAtendido.Nombre.ToString(); // Convertimos el DNI a string y lo asignamos al TextBox

                // Refrescamos la grilla dataGridPersonal
                GrillaAtencionCLiente(); // Este método debería implementar la lógica para cargar los datos en el DataGridView
            }
            else
            {
                MessageBox.Show("No hay mas personas para atender."); // Mensaje si no hay más personas
                txtClienteAtencion.Clear();
                txtDniAtencion.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
