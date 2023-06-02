using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataBases;
using domain;


namespace bussines
{

    public partial class principalForm : Form
    {
        private List<phone> phoneList;
        private phoneController pc;
        private help helper;
        public principalForm()
        {
            this.pc = new phoneController();
            this.helper = new help();
            InitializeComponent();
            
        }

        private void principalForm_Load(object sender, EventArgs e)
        {
            dbLoad();
        }

        private void phoneDataBase_SelectionChanged(object sender, EventArgs e)
        {
            phone selectedPhone = (phone)phoneDataBase.CurrentRow.DataBoundItem; //selecciona el dispositivo movil
            imageLoad(selectedPhone.getUrlImage());
        }
        private void imageLoad (String url)
        {
            helper.imageLoad(picturePhone, url);
        }
        
        
        private void registerButton_Click(object sender, EventArgs e)
        {
            addPhone registerPhone = new addPhone(); //instancia el objeto para llamar a la nueva ventana de registro
            registerPhone.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            String userInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del producto a buscar :", "ID", "");
            phone foundPhone = new phone();
            try { 
                int id = int.Parse(userInput);
                foundPhone = pc.searchForId(id); //guarda el dispositivo encontrado
                if (foundPhone != null) MessageBox.Show("INFORMACION DEL DISPOSITIVO:\n1-Modelo de celular: " + foundPhone.getName() + "\n2-Descripción: " + foundPhone.getDescription() + "\n3-Memoria RAM: " + foundPhone.getRam() + "\n4-Gama (Categoria): " + foundPhone.getGamma().getName());
            } catch (FormatException ex)
            {
                MessageBox.Show("ID Inválido.");
                Console.Write(ex.Message );
            }
            

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            String userInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del producto a eliminar :", "ID", "");
            phone removePhone = new phone();
            try {
                int id = int.Parse(userInput);
                DialogResult confirmation = MessageBox.Show("Confirma que desea eliminar el dispositivo " + removePhone.getName() + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes) pc.removePhone(id);
                else MessageBox.Show("Operacion cancelada.");

            } catch (Exception ex) { MessageBox.Show("ID Inválido."); throw ex; }

        }

        private void listButton_Click(object sender, EventArgs e)
        {
            list list = new list();
            list.ShowDialog();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            String userInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el ID del producto a modificar :", "ID", "");
            try {
                int id = int.Parse(userInput);
                phone currentPhone = pc.searchForId(id);
                if (currentPhone != null) {
                    addPhone modifyPhone = new addPhone(currentPhone, id);
                    modifyPhone.ShowDialog();
                }  
            } catch  (Exception ex) { throw ex; }
            

        }
        private void dbLoad() //carga de los elementos de la base dedatos
        {
            phoneList = pc.phoneList();
            foreach(phone currentPhone in phoneList ) {
                Console.WriteLine("-Modelo de celular: " + currentPhone.getName());
                Console.WriteLine("-Descripcion del celukar: "+currentPhone.getDescription());

            }
            try {
                phoneDataBase.DataSource = phoneList;
                phoneDataBase.Refresh();
                imageLoad(phoneList[0].getUrlImage());
            } catch (Exception ex)
            {
                MessageBox.Show("¡No hay dispositivos registrados!");
            }
            
        }
    }
}
