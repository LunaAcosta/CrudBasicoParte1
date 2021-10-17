using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudBasicoParte1
{
    public partial class FrmMenu : Form
    {
        private string action = "";

        public FrmMenu()
        {
            InitializeComponent();
        }



        private void Menu_Load(object sender, EventArgs e)
        {
            tabla.TabPages.Remove(NuevoEscri);

            // carga los datos en la datagridview
            // Desabilita los controles 

            FillDataGridView();
            controlsDisable();
        }

        public void FillDataGridView()
        {
            // Instancia de la clase escritorio

            Escritorio escritorio = new Escritorio();

            limpiareldatagridview();

            dgCatalogo.Columns.Add("scrict", "ESCRITORIO");
            dgCatalogo.Columns.Add("categoria", "CATEGORIA");
            dgCatalogo.Columns.Add("codigo", "CODIGO");
            dgCatalogo.Columns.Add("color", "COLOR");
            dgCatalogo.Columns.Add("materiales", "MATERIALES");

            // llamamdo al metodo getescritorio

            MySqlDataReader dataReader = escritorio.getAllEscritorios();
            {
                // Leer el resultado 
                while (dataReader.Read())
                    dgCatalogo.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4)
                        );
            }

        }

        public void limpiareldatagridview()
        {
            dgCatalogo.Columns.Clear();
            dgCatalogo.Rows.Clear();
        }

        // Desabilita controles
        public void controlsDisable()
        {
            txtEscri.Enabled = false;
            txtcate.Enabled = false;
            txtcodigo.Enabled = false;
            txtcolor.Enabled = false;
            txtmaterial.Enabled = false;
        }

        // Habilitas los controles 

        public void controlsEnable()
        {
            txtEscri.Enabled = false;
            txtcate.Enabled = true;
            txtcodigo.Enabled = true;
            txtcolor.Enabled = true;
            txtmaterial.Enabled = true;

        }

        public void limpiarcontroles()
        {
            txtEscri.Text = "";
            txtcate.Text = "";
            txtcodigo.Text = "";
            txtcolor.Text = "";
            txtmaterial.Text = "";

        }


        private void dgCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabla.TabPages.Remove(listEscrit);
            tabla.TabPages.Add(NuevoEscri);
            tabla.TabPages[0].Text = "EDITAR INFORMACION";

            action = "EDITAR";
            controlsEnable();

            txtEscri.Visible = true;
            txtEscri.ReadOnly = true;
            lbEscri.Visible = true;
            // Carga datos en los controles


        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            tabla.TabPages.Add(NuevoEscri);//Muestra el formulario
            tabla.TabPages.Remove(listEscrit);
            tabla.TabPages[0].Text = "Nuevo Escritorio";

            txtEscri.Visible = false;
            lbEscri.Visible = false;
            action = "Nuevo";
            controlsEnable();
            limpiarcontroles();
            txtcate.Focus(); // Enviar enfoque a categoria  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "¿ Esta seguro que desea cancelar la operacion ?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                limpiarcontroles();
                controlsDisable();

                tabla.TabPages.Remove(NuevoEscri);
                tabla.TabPages.Add(listEscrit);
                tabla.TabPages[0].Text = "Lista De Escritorios";


            }
        }

        public override bool Equals(object obj)
        {
            return obj is FrmMenu menu &&
                   action == menu.action;
        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            if (txtcate.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe escribir el titulo", "VALIDACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcate.Focus(); //enviamos el enfoque a la caja de texto

            }
            else
            {

                Escritorio escritorio = new Escritorio(); //instancia de la clase Libro
                                                          //evaluar la accion
                if (action == "edit")
                {
                    escritorio._scrict = Convert.ToInt32(txtEscri.Text);
                }


                escritorio._categoria = txtcate.Text;
                escritorio._codigo = txtcodigo.Text;
                escritorio._codigo = txtcolor.Text;
                escritorio._material = txtmaterial.Text;

                string mensaje = "Esta seguro que desea guardar el registro?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //LLAMAR AL METODO PARA GUARDAR
                    if (escritorio.newEditEscritorio(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos se han guardado exitosamente!",
                            "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han guardado!",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    limpiarcontroles();
                    controlsDisable();
                    FillDataGridView();
                    tabla.TabPages.Remove(NuevoEscri);
                    tabla.TabPages.Add(listEscrit);
                    tabla.TabPages[0].Text = "BOOK LIST";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                //codigo del boton salir
                string mensaje = "¿Está seguró que desea salir?";
                if (MetroFramework.MetroMessageBox.Show(this, mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    this.Close();
                }
        }
    }
}



        
    
            

