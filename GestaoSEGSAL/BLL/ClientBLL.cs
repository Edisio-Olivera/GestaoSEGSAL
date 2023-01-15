using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoSEGSAL.DTO;
using GestaoSEGSAL.DAO;
using System.Data.OleDb;

namespace GestaoSEGSAL.BLL
{
    class ClientBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        Int32 resultCountCodeClient;

        public Int32 ToCountCodeClient()
        {
            cmd.CommandText = "SELECT COUNT(id) AS id FROM tb_client";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                resultCountCodeClient = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error when trying to connect to the database " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultCountCodeClient;
        }

        public void ToCreateNewClient(ClientDTO c)
        {
            ToCountCodeClient();

            if (resultCountCodeClient == 0)
            {
                c.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_client";

                try
                {
                    cmd.Connection = connection.ToConnect();
                    OleDbDataReader dr = cmd.ExecuteReader();

                    dr.Read();
                    c.Id = dr.GetInt32(0);

                    connection.ToDisconnect();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error when trying to connect to the database " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public List<ClientDTO> ToPopulaComboboxClient()
        {
            cmd.CommandText = "SELECT fantasyName FROM tb_client " +
                "ORDER BY fantasyName ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<ClientDTO> client = new List<ClientDTO>();

            while (dr.Read())
            {
                ClientDTO cli = new ClientDTO();
                cli.FantasyName = dr.GetString(0);
                client.Add(cli);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return client;
        }

        public String ToSelectCodeClient(ClientDTO c)
        {
            cmd.CommandText = "SELECT code FROM tb_client WHERE fantasyName = '" + c.FantasyName + "'";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                c.Code = dr.GetString(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return c.Code;
        }

        public List<ClientDTO> ToSelectClient(ClientDTO c)
        {
            this.ToSelectCodeClient(c);

            cmd.CommandText = "SELECT " +
               "tb_client.id, " +
               "tb_client.code, " +
               "tb_client.socialReason, " +
               "tb_client.fantasyName " +
               "FROM tb_client " +
               "WHERE tb_client.code = '" + c.Code + "'";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<ClientDTO> client = new List<ClientDTO>(4);

            while (dr.Read())
            {
                client.Add(new ClientDTO());

                client[0].Id = dr.GetInt32(0); //id
                client[0].Code = dr.GetString(1); //code
                client[0].SocialReason = dr.GetString(2); //social reason
                client[0].FantasyName = dr.GetString(3); //fantasy name          
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return client;
        }
    }
}
