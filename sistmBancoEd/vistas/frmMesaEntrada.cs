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

        public frmMesaEntrada()
        {
            InitializeComponent();
            cola = new clsCola();
            listaParaCajas = new clsListaCja();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDniEntrada.Text) && !string.IsNullOrWhiteSpace(txtNombreEntrada.Text))
            {
                if (int.TryParse(txtDniEntrada.Text, out int dni))
                {
                    // Creamos el nuevo nodo con el DNI ingresado
                    Nodo nuevoNodo = new Nodo(dni, txtNombreEntrada.Text);

                    // Intentamos agregar el nodo a la cola
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
            // Obtenemos los nodos de la cola
            List<Nodo> listaDeNodos = cola.ListarElementos();

            // Variable para llevar el conteo del orden
            int orden = 1;

            // Iteramos sobre cada nodo en la lista
            foreach (var nodo in listaDeNodos)
            {
                if (nodo != null)
                {
                    
                    string dniString = nodo.DNI.ToString();
                    string nombre = nodo.Nombre;

                    dgvIngreso.Rows.Add(orden, dniString, nombre);

                    // Incrementamos el contador de orden
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
            // Llama al método Eliminar y guarda el nodo eliminado
            Nodo nodoEliminado = cola.Eliminar();

            // Verifica si se eliminó un nodo
            if (nodoEliminado != null)
            {

                // Establece el texto de txtIngreso con el DNI del nodo eliminado
                txtDniClientes.Text = nodoEliminado.DNI.ToString(); // Convertimos a string

                txtNombreClientes.Text = nodoEliminado.Nombre.ToString(); // Convertimos a string
                CargarDgvEntrada();
            }
            else
            {
                // Opcional: Manejar el caso cuando no hay nodos para eliminar
                MessageBox.Show("No hay mas datos en la cola");
            }
        }

        private void btnAceptarClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDniClientes.Text))
            {
                MessageBox.Show("Debe haber un DNI."); // Mensaje de error si el TextBox está vacío
                return; // Salimos del método
            }


            if (int.TryParse(txtDniClientes.Text, out int dni))
            {
                NodoLista nuevoNodo = new NodoLista(dni,txtNombreClientes.Text)
                {
                    Cliente = chkCliente.Checked // Asignamos true o false según el CheckBox
                };
                
                // Verificamos si el RadioButton btnCaja está seleccionado
                if (rdCajas.Checked)
                {
                        //clsListaCja listaParaCaja = new clsListaCja();
                    
                    listaParaCajas.Insertar(nuevoNodo);

                    // Cargamos los datos en el DataGridView de Caja
                    CargarGrillaCaja();

                    // Limpiamos los controles
                    txtDniClientes.Clear();
                    txtNombreClientes.Clear() ;
                    rdAtencionClientes.Checked = false;
                    rdCajas.Checked = false; // Desmarcamos el RadioButton
                }
                chkCliente.Checked = false;
            }


        }
        private void CargarGrillaCaja()
        {
            // Limpiamos el DataGridView antes de listar los elementos
            dgvCajas.Rows.Clear();

            // Configuramos las columnas del DataGridView si no están configuradas
            if (dgvCajas.Columns.Count == 0)
            {
                dgvCajas.Columns.Add("Orden", "Orden");
               
                dgvCajas.Columns.Add("DNI", "DNI");
                dgvCajas.Columns.Add("Nombre", "Nombre");

                dgvCajas.Columns.Add("Cliente", "Cliente");
            }
            
            // Listamos todos los nodos y los cargamos en el DataGridView
            var nodos = listaParaCajas.Listar();

            // Cargamos los datos en el DataGridView
            int orden = 1; // Variable para llevar el orden de los nodos
            foreach (var nodo in nodos)
            {
                dgvCajas.Rows.Add(orden++, nodo.DNI, nodo.Nombre, nodo.Cliente ? "Sí" : "No"); // Agregamos fila con el orden, DNI y "Sí"/"No" para el cliente
            }
        }
        private bool primerInicioCaja = true;
        private void btnAtender_Click(object sender, EventArgs e)
        {
            NodoLista nodoAtendido;

            if (primerInicioCaja)
            {
                // En el primer clic, atendemos al primer nodo de la lista caja
                nodoAtendido = listaParaCajas.Atender(); // Suponiendo que Atender obtiene el primer nodo
                primerInicioCaja = false; // Cambiamos el estado a no primer clic
            }
            else
            {
                // En clics subsecuentes, buscamos en los primeros 3
                nodoAtendido = listaParaCajas.BuscarCliente(); // Método que deberías tener en tu clase ListaCaja
                primerInicioCaja = true; // Restablecemos el estado para el siguiente clic
            }

            // Verificamos si se obtuvo un nodo atendido
            if (nodoAtendido != null)
            {
                // Cargamos el DNI en el TextBox
                txtClienteCajas.Text = nodoAtendido.DNI.ToString(); // Convertimos el DNI a string y lo asignamos al TextBox
                txtNombreCaja.Text = nodoAtendido.Nombre; // Convertimos el DNI a string y lo asignamos al TextBox

                // Refrescamos la grilla dataGridCaja
                CargarGrillaCaja(); // Este método debería implementar la lógica para cargar los datos en el DataGridView
            }
            else
            {
                MessageBox.Show("No hay más personas para atender."); // Mensaje si no hay más personas
                txtClienteCajas.Clear();
                txtNombreCaja.Clear();
            }   
        }
    }
}
