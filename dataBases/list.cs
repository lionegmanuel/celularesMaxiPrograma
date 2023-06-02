using bussines;
using domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBases
{
    public partial class list : Form
    {

        phoneController controller;
        public list()
        {
            this.controller= new phoneController();
            InitializeComponent();
        }

        private void list_Load(object sender, EventArgs e)
        {
           dgbPhones.DataSource= controller.phoneList();
        }
    }
}
