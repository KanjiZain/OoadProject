using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace OOP_Project
{
    public class Filepath
    {
        string filepath;

        public Filepath(string file_path)
        {
            filepath = file_path;
            System.Diagnostics.Process.Start(file_path);
        }
    }
}
