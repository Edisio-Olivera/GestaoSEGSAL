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
    class FinancialMovementTypeBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();


        public Int32 ToSelectCodeFinancialMovementType(FinancialMovementTypeDTO fmt)
        {
            cmd.CommandText = "SELECT id FROM tb_financialMovementType " +
                "WHERE type = '" + fmt.Type + "'";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                fmt.Id = dr.GetInt32(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return fmt.Id;
        }

        public List<FinancialMovementTypeDTO> ToPopulaComboboxFinancialMovementType()
        {
            cmd.CommandText = "SELECT typeMovement FROM tb_financialMovementType " +
                "ORDER BY typeMovement ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<FinancialMovementTypeDTO> financial = new List<FinancialMovementTypeDTO>();

            while (dr.Read())
            {
                FinancialMovementTypeDTO fmt = new FinancialMovementTypeDTO();
                fmt.MovimentType = dr.GetString(0);
                financial.Add(fmt);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return financial;
        }




    }
}
