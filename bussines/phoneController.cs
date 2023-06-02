using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using domain;
using System.Windows.Forms;
using System.Reflection;
using System.Net.NetworkInformation;

namespace bussines
{
    public class phoneController //clase que contiene toda la logica del negocio y del acceso a los datos.
    {
        private connection con;
        public phoneController() { con = new connection(); }
        
        public List<phone> phoneList()
        {
            List<phone> list = new List<phone>(); //crea la nueva lista de los celulares


            try {
                con.setQuery("select p.phoneModel MODELO, p.shorDescription DESCRIPCION, p.ramCapacity MEMORIA_RAM, p.urlImage PORTADA, g.gamma GAMA from phone p, gamma g where p.idGamma = g.id");
                con.getConnectionAndExecuteReader();

                while (con.getReader().Read()) //mientras que haya objetos
                {
                    gammaPhone gammaPhone = new gammaPhone((string)con.getReader()["GAMA"]);
                    phone newModel = new phone(gammaPhone);
                    //asigna los valores corespondientes traidos desde la base de datos.
                    newModel.setName((string)con.getReader()["MODELO"]);
                    newModel.setDescription((string)con.getReader()["DESCRIPCION"]);
                    newModel.setRam((int)con.getReader()["MEMORIA_RAM"]);
                    newModel.setUrl((string)con.getReader()["PORTADA"]);
                    //Console.WriteLine("MODELO DE CELULAR:\n - "+newModel.getName() + "\nDESCRIPCION:\n - "+ newModel.getDescription() + "\nCAPACIDAD RAM:\n - " + newModel.getRam() + "\nGAMA:\n- "+newModel.getGamma().getName());
                    
                    list.Add(newModel); //añade el celular a la lista
                }
                return list;
            } catch (Exception ex)
            {
                throw ex;
                Console.WriteLine("¡ERROR DETECADO!/n"+ex.Message);
            }
            finally {
                con.closeConnection();
                    } //cierre de conexion + datareader
                

            
        } //listar
        
        public void addPhone (phone model)  {//añadir a la base de datos
            //asignacion de los valores del dispositivo a añadir
            string phoneModel = model.getName();
            int phoneRam = model.getRam();
            int phoneYear = model.getYear();
            string phoneDescription = model.getDescription();
            model.getGamma().setId(model.getGamma().getName()); //setea el id
            int phoneIdGamma = model.getGamma().getId();
            string phoneImage = model.getUrlImage();

            //insert into phone(phoneModel, ramCapacity, yearModel, shorDescription, idGamma, urlImage) values('iPhone 7', 3, 2014, 'Apple iphone 7 reacondicionado de fabrica con 65% de bateria', 4, 'https://http2.mlstatic.com/D_NQ_NP_603037-MLA43703529583_102020-O.jpg');
            String querySQL = "INSERT INTO phone(phoneModel, ramCapacity, yearModel, shorDescription, idGamma, urlImage ) values (@phoneModel, @phoneRam, @phoneYear, @phoneDescription, @phoneIdGamma, @phoneImage)";
            try {
                
                con.setQuery(querySQL);
                SqlCommand com = con.getCommand(); //obtiene el comando especifico de la conexion que esta encapsulado.
                com.Parameters.AddWithValue("@phoneModel", phoneModel);
                com.Parameters.AddWithValue("@phoneRam", phoneRam);
                com.Parameters.AddWithValue("@phoneYear", phoneYear);
                com.Parameters.AddWithValue("@phoneDescription", phoneDescription);
                com.Parameters.AddWithValue("@phoneIdGamma", phoneIdGamma);
                com.Parameters.AddWithValue("@phoneImage", phoneImage);
                con.getConnectionAndExecuteAction(); //ejecucion del tipo noquery.
                MessageBox.Show("¡Dispositivo "+model.getName()+" registrado con éxito!");
                
                
            } 
            catch (Exception ex) {
                MessageBox.Show("¡ERROR!\nEl dispositivo " + model.getName() + " no pudo ser registrado.");
                throw ex;
            } 
            
            finally { con.closeConnection(); }   
        } 
        public void removePhone (int id)
        { //remover de la base de datos utilizando el ID del celular
            if (searchForId(id) != null)
            {
                try {
                    phone currentRemovePhone = searchForId(id);
                    con.setQuery("DELETE FROM phone where id = " + id);
                    con.getConnectionAndExecuteAction();
                    MessageBox.Show("El dispositivo "+currentRemovePhone.getName()+"ha sido eliminado satisfactoriamente.");
   
                } catch  (Exception ex) {

                    throw ex;
                        }      
            } 
        } 
        public void modifyPhone (phone phone, int id) { //modificar elemento mediante el ID (recibe como parametro un objeto de tipo phone que ya fue buscado)
            {
                string phoneModel = phone.getName();
                int phoneRam = phone.getRam();
                int phoneYear = phone.getYear();
                string phoneDescription = phone.getDescription();
                phone.getGamma().setId(phone.getGamma().getName()); 
                int phoneIdGamma = phone.getGamma().getId();
                string phoneImage = phone.getUrlImage();

                String query = "update phone set phoneModel = @phoneModel, ramCapacity = @phoneRam, yearModel = @phoneYear , shorDescription = @phoneDescription, idGamma = @phoneIdGamma, urlImage = @phoneImage where id = @id";
                try {
                    con.setQuery(query);
                    SqlCommand com = con.getCommand();
                    com.Parameters.AddWithValue("@phoneModel", phoneModel);
                    com.Parameters.AddWithValue("@phoneRam", phoneRam);
                    com.Parameters.AddWithValue("@phoneYear", phoneYear);
                    com.Parameters.AddWithValue("@phoneDescription", phoneDescription);
                    com.Parameters.AddWithValue("@phoneIdGamma", phoneIdGamma);
                    com.Parameters.AddWithValue("@phoneImage", phoneImage);
                    com.Parameters.AddWithValue("@id", id);
                    con.getConnectionAndExecuteAction();
                    MessageBox.Show("¡Dispositivo " + phone.getName() + " modificado con exito!");
                    
                }                
                catch (Exception e) {
                    MessageBox.Show("¡ERROR!\nEl dispositivo " + phone.getName() + " no pudo ser modificado.");
                    throw e; }
            }
            
        } //modificar datos 
        public phone searchForId (int id) //busqueda de un celular por ID
        {
            phone currentPhone = null;
            try {
                con.setQuery("select p.phoneModel MODELO, p.shorDescription DESCRIPCION, p.ramCapacity MEMORIA_RAM, p.urlImage PORTADA, g.gamma GAMA from phone p, gamma g where p.idGamma = g.id and p.id = "+id);
                con.getConnectionAndExecuteReader(); //obtiene la conexion
                SqlCommand com = con.getCommand();
                SqlDataReader read = con.getReader();
                if (read.Read()) //si el objeto ES ENCONTRADO 
                {
                    currentPhone = new phone();
                    currentPhone.setName((String)read["MODELO"]);
                    currentPhone.setDescription((String)read["DESCRIPCION"]);
                    currentPhone.setRam((int)read["MEMORIA_RAM"]);
                    currentPhone.setUrl((String)read["PORTADA"]);
                    currentPhone.setGammaPhone((String)read["GAMA"]);

                    return currentPhone;

                }
                else
                {
                    MessageBox.Show("¡ERROR! \nDispositivo NO encontrado.");
                    return null;
                }
            } 
            catch (Exception ex) {
                Console.WriteLine("Elemento con id " + id + " no encontrado.");
                throw ex;
            }
            finally { con.closeConnection(); }
            
        }
    }
}
