using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using AppCustoViagemSQLite.Model;

namespace AppCustoViagemSQLite.Helper
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLite.SQLiteAsyncConnection con;

        /** método construtor que abre uma conexão com o banco de forma assíncrona.
         * Path = caminho -> onde o arquivo se encontra
         */

        public SQLiteDatabaseHelper(string path)
        {
            con = new SQLite.SQLiteAsyncConnection(path);

            /** criando uma tabela de forma assíncrona, baseada no model produto
             */

            con.CreateTableAsync<Pedagio>().Wait();

            public Task<int> Insert(Pedagio p)
            {
                return con.InsertAsync(p);
            }


            /** 
             * string SQL que vai fazer as atualizações nos seguintes campos da tabela (formulário)
             */

            public void Update(Pedagio p)
            {
                string sql = "UPDATE Produto SEt Descricao=?, Quantidade=?, Preco=? WHERE id =? ";

                con.QueryAsync<Pedagio>(sql, p.Id, p.CidadePedagio, p.ValorPedagio);
            }


            /**
             * consulta o banco de dados e retorna uma lista de produtos (array de objetos)
             */

            public Task<List<Pedagio>> GetAll()
            {
                return con.Table<Pedagio>().ToListAsync();
                /** retorna todos os regsitros da tabela em forma de lista*/
            }


            public Task<int> Delete(int id)
            {
                return con.Table<Pedagio>().DeleteAsync(i => i.Id == id);
                /* Fazer um delete na tabela produto, para cada item da tabela onde 
                 * o Id do item seja igual o Id recebido como parêmtro
                 */
            }
        }

    }
    
}

