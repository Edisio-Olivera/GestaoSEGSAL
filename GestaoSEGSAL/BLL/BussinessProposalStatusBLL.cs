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
    class BussinessProposalStatusBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        public Int32 ToSelectCodeBussinessProposalStatus(BussinessProposalStatusDTO bps)
        {
            cmd.CommandText = "SELECT id FROM tb_bussinessProposalStatus WHERE status = '" + bps.Status + "'";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                bps.Id = dr.GetInt32(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bps.Id;
        }
    }
}
