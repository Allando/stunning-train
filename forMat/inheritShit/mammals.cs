using System;
using System.Threading.Channels;

namespace inheritShit
{
    public class mammals : animal
    {
        public string uniqueMammalTrade0 { get; set; }
        public string uniqueMamnalTrade1 { get; set; }

        public mammals(string name, double height, double length, double weight, int age, string uniqueMammalTrade0,
            string uniqueMamnalTrade1) : base(name, height, length, weight, age)
        {
            this.uniqueMammalTrade0 = uniqueMammalTrade0;
            this.uniqueMamnalTrade1 = uniqueMamnalTrade1;
        }


        
        

    }
}
        
        
    

     