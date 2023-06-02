using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class phone
    {
        private int ram;//Atributos que se van a llamar y traer desde base de datos.
        private string name;
        private string description;
        private string urlImage;
        private int year;
        private gammaPhone currentGamma;
        
        //constructor
        public phone (gammaPhone gamma)
        {
            this.currentGamma = gamma;
        }
        public phone() { }
        public void setRam (int ram) { this.ram= ram; }
        public void setName(String name) { this.name = name; }
        public void setDescription(String description) { this.description = description; }
        public void setUrl(String url) { this.urlImage = url;}
        public String getName() { return name; }
        public int getRam() { return ram; }
        
        public string getDescription() { return description;}
        public String getUrlImage() { return this.urlImage;}
        public gammaPhone getGamma () { return currentGamma; }
        public void setGammaPhone (String name )
        {
            gammaPhone myGamma = new gammaPhone(name);
            this.currentGamma = myGamma;
            this.currentGamma.setId(name);
        }
        public int getYear () { return year; }
        public void setYear (int year) { this.year = year;}
    
    }
}
