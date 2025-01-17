﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SqliteDataAccess : DataAccess
    {
        // -> for override the LoadConnectionString, make changes at "DataAccess.cs" => "public virtual string LoadConnectionString(string name)"
        //public override string LoadConnectionString(string name)
        //{
        //    string output = base.LoadConnectionString(name);
        //    output += "(from sqlite)";
        //    return output;
        //}
        public override void LoadData(string sql) // override -> abstract
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
