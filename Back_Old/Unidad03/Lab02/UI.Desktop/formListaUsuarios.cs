using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.UI.Desktop
{
    public partial class formListaUsuarios : Form
    {
        public formListaUsuarios()
        {
            InitializeComponent();
            this.oUsuarios = new Usuario();
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }
        public Usuario oUsuarios
        {
            get { return _Usuarios; }
            set { _usuarios = value; }
        }
    }
}
