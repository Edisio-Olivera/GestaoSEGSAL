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
    class InvoiceTypeBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        InvoiceTypeDTO itDto = new InvoiceTypeDTO();
        InvoiceTypeBLL itBll = new InvoiceTypeBLL();

        public Int32 ToSelectCodeInvoiceType(InvoiceTypeDTO it)
        {
            cmd.CommandText = "SELECT id FROM tb_invoiceType WHERE type = '" + it.InvoiceType + "'";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                it.Id = dr.GetInt32(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return it.Id;
        }

        public List<InvoiceTypeDTO> ToPopulaComboboxInvoiceType()
        {
            cmd.CommandText = "SELECT type FROM tb_invoiceType ORDER BY id ASC";

            cmd.Connection = connection.ToConnect();

            OleDbDataReader dr = cmd.ExecuteReader();
            List<InvoiceTypeDTO> invType = new List<InvoiceTypeDTO>();

            while (dr.Read())
            {
                InvoiceTypeDTO typ = new InvoiceTypeDTO();
                typ.InvoiceType = dr.GetString(0);
                invType.Add(typ);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return invType;
        }
    }
}
