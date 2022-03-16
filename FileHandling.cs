using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Tutorial
{
    internal class FileHandling
    {
        public void WriteToFile(String fileName,String msg)
        {
            try 
            { 
                FileInfo fileInfo = new FileInfo(@fileName);
                FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                StreamWriter streamWriter = new StreamWriter(fs);

                streamWriter.WriteLine(msg);
                streamWriter.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }        
        }

        public void ReadFile(String fileName,out String msg)
        {
            msg = "";
            try
            {
                FileInfo fileInfo = new FileInfo(@fileName);
                FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                StreamReader streamReader = new StreamReader(fs);

                msg = streamReader.ReadToEnd();
                streamReader.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
