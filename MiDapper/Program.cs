using Dapper;
using System.Data.SqlClient;

namespace MiDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string connection =
                @"Data Source=LAP-ALANC\SQLEXPRESS;Initial Catalog=DapperPruebas;User ID=sa;Password=123456";

            using (var db = new SqlConnection(connection))
            {
                /*
                //Insertar
                var sqlInsert = "INSERT INTO persona(nombre,edad) VALUES(@nombre, @edad)";
                var result = db.Execute(sqlInsert,new {nombre="Chuy",edad=18});

                //Actualizar
                var sqlEdit = "UPDATE persona SET edad=@edad where id=@id";
                var resultEdit = db.Execute(sqlEdit, new { edad = 60, id = 5 });

                //Consultar
                var sql = "SELECT * FROM persona";
                var lst = db.Query<Persona>(sql);

                foreach(var oElement in lst)
                {
                    Console.WriteLine(oElement.nombre + " " + oElement.edad);
                }
                */
                var sql = "SELECT id,nombre,edad FROM persona WHERE id=@id";
                var oElemento = db.QueryFirst<Persona>(sql, new { id = 1 });
                Console.WriteLine(oElemento.nombre);
            }
        }
    }
}