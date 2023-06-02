using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class gammaPhone
    {
        private String name;
        private String description;
        private int id;
        public gammaPhone(String name) { this.name = name;
            
        }
        public void setDescription(String description) { this.description = description; }
        public String getName() { return this.name;}
        public String getDescription() { return this.description;}
        public void setId()
        {
            
 
        }
        public void setId(String name) {
            switch (name)
            {
                case "BAJA":
                    this.id = 1;
                    break;
                    
                case "MEDIA BAJA":
                    this.id = 2;
                    break;
                   
                case "MEDIA":
                    this.id = 3;
                    break;
                   
                case "MEDIA ALTA":
                    this.id = 4;
                    break;
                    
                case "ALTA":
                    this.id = 5;
                    break;
                    
            }
        }
        public int getId() { return this.id; }

        public override string ToString()
        {
            return name;
        }
    }
}
