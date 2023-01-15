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
    class PaymentFormBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        PaymentTermsDTO ptDto = new PaymentTermsDTO();
        PaymentTermsBLL ptBll = new PaymentTermsBLL();

        public Int32 ToSelectCodePaymentForm(PaymentFormDTO pf)
        {
            cmd.CommandText = "SELECT id FROM tb_paymentForm WHERE paymentForm = '" + pf.PaymentForm + "'";
            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                pf.Id = dr.GetInt32(0);

                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pf.Id;
        }

        public List<PaymentFormDTO> ToPopulaComboboxPaymentForm(PaymentFormDTO pf)
        {
            ptDto.PaymentTerms = pf.PaymentTerms;
            ptBll.ToSelectCodePaymentTerms(ptDto);

            cmd.CommandText = "SELECT paymentForm FROM tb_paymentForm " +
                "WHERE codePaymentTerms = " + ptDto.Id + " " +
                "ORDER BY id ASC";

            cmd.Connection = connection.ToConnect();

            OleDbDataReader dr = cmd.ExecuteReader();
            List<PaymentFormDTO> payment = new List<PaymentFormDTO>();

            while (dr.Read())
            {
                PaymentFormDTO form = new PaymentFormDTO();
                form.PaymentForm = dr.GetString(0);
                payment.Add(form);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return payment;
        }

    }
}
