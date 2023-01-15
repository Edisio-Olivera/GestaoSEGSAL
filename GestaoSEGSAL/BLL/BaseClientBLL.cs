using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoSEGSAL.DTO;
using GestaoSEGSAL.DAO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GestaoSEGSAL.BLL
{
    class BaseClientBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        ClientDTO cliDto = new ClientDTO();
        ClientBLL cliBll = new ClientBLL();

        public String ToSelectCodeBaseClient(BaseClientDTO bc)
        {
            cliDto.FantasyName = bc.Client;
            cliBll.ToSelectCodeClient(cliDto);

            cmd.CommandText = "SELECT code FROM tb_baseClient " +
                "WHERE namebase = '" + bc.NameBase + "' " +
                "AND codeClient = '" + cliDto.Code + "'";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                bc.Code = dr.GetString(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bc.Code;
        }

        public List<BaseClientDTO> ToPopulaComboxBaseClient(BaseClientDTO bc)
        {
            cliDto.FantasyName = bc.Client;
            cliBll.ToSelectCodeClient(cliDto);

            cmd.CommandText = "SELECT namebase FROM tb_baseClient " +
                "WHERE codeClient = '" + cliDto.Code + "' " +
                "ORDER BY namebase ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BaseClientDTO> baseC = new List<BaseClientDTO>();

            while (dr.Read())
            {
                BaseClientDTO b = new BaseClientDTO();
                b.NameBase = dr.GetString(0);
                baseC.Add(b);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return baseC;
        }

        public List<BaseClientDTO> ToSelectBaseClient(BaseClientDTO bc)
        {
            this.ToSelectCodeBaseClient(bc);

            cmd.CommandText = "SELECT " +
               "tb_baseClient.id, " +
               "tb_baseClient.namebase, " +
               "tb_baseClient.cnpj, " +
               "tb_baseClient.address, " +
               "tb_baseClient.complement, " +
               "tb_baseClient.district, " +
               "tb_city.city, " +
               "tb_federationState.initials, " +
               "tb_baseClient.postalCode, " +
               "tb_baseClient.telephone, " +
               "tb_baseClient.email " +
               "FROM ((tb_baseClient " +
               "INNER JOIN tb_city ON tb_baseClient.codeCity = tb_city.id) " +
               "INNER JOIN tb_federationState ON tb_city.codeState = tb_federationState.id) " +
               "WHERE tb_baseClient.code = '" + bc.Code + "'";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BaseClientDTO> baseClient = new List<BaseClientDTO>(11);

            while (dr.Read())
            {
                baseClient.Add(new BaseClientDTO());

                baseClient[0].Id = dr.GetInt32(0); //id
                baseClient[0].NameBase = dr.GetString(1); //code
                baseClient[0].Cnpj = dr.GetString(2); //social reason
                baseClient[0].Address = dr.GetString(3); //fantasy name
                baseClient[0].Complement = dr.GetString(4); //fantasy name
                baseClient[0].District = dr.GetString(5); //fantasy name
                baseClient[0].City = dr.GetString(6); //fantasy name
                baseClient[0].FaderationState = dr.GetString(7); //fantasy name
                baseClient[0].PostalCode = dr.GetString(8); //fantasy name
                baseClient[0].Telephone = dr.GetString(9); //fantasy name
                baseClient[0].Email = dr.GetString(10); //fantasy name
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return baseClient;
        }
    }
}
