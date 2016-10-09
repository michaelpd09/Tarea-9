using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;
using DAL;

namespace RegistroUsuarios
{
    public partial class RegistroUsuarios : Form
    {
       
        RegistroDB DB = new RegistroDB();
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                DB.Conectar();

                String Query = "update UsuariosDB set Nombre='" + Nombre.Text + "', Clave = '" + Clave.Text + "';";
                DB.EjecutarSql(Query);
                DB.Desconectar();
              
                MessageBox.Show("guardo");
            ID.Clear();
            Nombre.Clear();
            Clave.Clear();
            }
         

        private void Nuevo_Click(object sender, EventArgs e)
        {

            
            ID.ReadOnly = false;
            Nombre.ReadOnly = false;
            Clave.ReadOnly = false;
        }
    }

      
    }

