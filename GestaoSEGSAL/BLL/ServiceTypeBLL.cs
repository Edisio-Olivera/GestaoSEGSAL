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
    class ServiceTypeBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        public List<ServiceTypeDTO> ToPopulaComboboxServiceType()
        {
            cmd.CommandText = "SELECT description FROM tb_serviceType " +
                "ORDER BY description ASC";

            cmd.Connection = connection.ToConnect();

            OleDbDataReader dr = cmd.ExecuteReader();
            List<ServiceTypeDTO> service = new List<ServiceTypeDTO>();

            while (dr.Read())
            {
                ServiceTypeDTO st = new ServiceTypeDTO();
                st.Description = dr.GetString(0);
                service.Add(st);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return service;
        }

        public Int32 ToSelectCodeServiceType(ServiceTypeDTO st)
        {
            cmd.CommandText = "SELECT id FROM tb_serviceType WHERE description = '" + st.Description + "'";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                st.Id = dr.GetInt32(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return st.Id;
        }
    }
}
