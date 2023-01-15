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
    class PaymentTermsBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();


        public Int32 ToSelectCodePaymentTerms(PaymentTermsDTO pt)
        {
            cmd.CommandText = "SELECT id FROM tb_paymentTerms WHERE paymentTerms = '" + pt.PaymentTerms + "'";
            
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                pt.Id = dr.GetInt32(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pt.Id;
        }

        public List<PaymentTermsDTO> ToPopulaComboxPaymentTerms()
        {
            cmd.CommandText = "SELECT paymentTerms FROM tb_paymentTerms " +
                "ORDER BY id ASC";

            cmd.Connection = connection.ToConnect();

            OleDbDataReader dr = cmd.ExecuteReader();
            List<PaymentTermsDTO> payment = new List<PaymentTermsDTO>();

            while (dr.Read())
            {
                PaymentTermsDTO terms = new PaymentTermsDTO();
                terms.PaymentTerms = dr.GetString(0);
                payment.Add(terms);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return payment;
        }
    }
}
