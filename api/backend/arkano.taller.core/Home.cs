namespace arkano.taller.core
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public class Home
    {
        private string text = "UTE  otro intentoDevOps live demo 01. Answer from server running on OS " + 
            System.Runtime.InteropServices.RuntimeInformation.OSDescription;

        public Home()
        {
            Console.WriteLine(this.text);
        }

        public string Text { get => this.text; set => this.text = value; }
    }
}
