using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Diagnostics;


namespace MathCalculation.Services
{
    public class ErrorServices
    {
        private readonly string _filePath;


        public ErrorServices()
        { 
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "ErrorLog.txt");

            //zjisteni jestli adresar existuje
            if (!Directory.Exists(Path.GetDirectoryName(_filePath)))
            {
                Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs")); //vytvoreni adresare
            }
        }


        public async Task SaveError(string message)
        {
            try
            {
                using (var streamWriter = new StreamWriter(_filePath, true))
                {
                    await streamWriter.WriteLineAsync($"{DateTime.Now} - {message}");
                }
            }
            catch (Exception ex)
            {
               Debug.WriteLine(ex.Message);
               
            }
        }
    }
}
