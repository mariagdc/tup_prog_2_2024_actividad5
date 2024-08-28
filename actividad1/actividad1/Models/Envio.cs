using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad1.Models
{
    internal class Envio
    {


        public int id { get; set;}
        public double Valor_total { get; set;}
        List<Costo> costos { get; set; } = new List<Costo>();

        public List<Envio> ListarTodo()
        {
            
            var  lista = new List<Envio>();

            using (var conn = new SqlConnection() { ConnectionString = "Server = TUPDEV; DATABASE= EnviosDB" })


            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ENVIOS";
                cmd.CommandType = CommandType.Text;

                conn.Open();
                var rd = cmd.ExecuteReader();
                while (rd.Read()== true)
                {

                }
            })


    }
}
