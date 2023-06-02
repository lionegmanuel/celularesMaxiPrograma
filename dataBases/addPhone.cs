using bussines;
using domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBases
{
    public partial class addPhone : Form
    {
        private help helper;
        private phone phone = null;
        private Boolean modify;
        private int idPhone;
        public addPhone()
        {
            this.helper = new help();
            this.modify = false;
            InitializeComponent();
        }
        public addPhone (phone phone, int idPhone)
        {
            this.idPhone = idPhone;
            this.phone = phone;
            this.helper = new help();
            this.modify = true;
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            phone newPhone = new phone(); //instancia el modelo SIN indicar la gama
            phoneController newRegister = new phoneController();
            
            try {
                if (!modify) {
                    newPhone.setGammaPhone(gamma.Text);
                    newPhone.setDescription(description.Text);
                    newPhone.setName(name.Text);
                    newPhone.setYear(date.Value.Year); //registra unicamente el año que ingreso el usuarioi
                    newPhone.setRam(int.Parse(ram.Text));
                    newPhone.setUrl(image.Text);

                    newRegister.addPhone(newPhone);
                    MessageBox.Show("¡Registro de dispositivo " + newPhone.getName() + " realizado con éxito!");
                    this.Close();
                }
                else //cuando se esten modificando los datos
                {
                    newRegister.modifyPhone(phone, idPhone); //hace referencia al celular que se paso por parametro al instanciarse el constructor n°2
                    
                }
                
            } catch (Exception ex) {
                Console.Write("Error al registrar el dispositivo en la base de datos.");
                throw ex; }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPhone_Load(object sender, EventArgs e)
        {
            gammaController gammaController = new gammaController();
            try { 
                gamma.DataSource = gammaController.gammaList();
                if (phone !=null) //cuando se inicie el metodo de modificar.
                {
                    name.Text = phone.getName();
                    description.Text = phone.getDescription();
                    ram.Text = phone.getRam().ToString();
                    //date.Value = phone.getYear();
                    gamma.Text = phone.getGamma().getName();
                    image.Text = phone.getUrlImage();
                }
            
            } 
            catch (Exception ex) 
            { throw ex; } 
            }

        private void image_Leave(object sender, EventArgs e)
        {
            helper.imageLoad(pictureLeaveImage, image.Text);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
