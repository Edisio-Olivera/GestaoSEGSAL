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
    class BussinessProposalServiceBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        ServiceTypeDTO serDto = new ServiceTypeDTO();
        ServiceTypeBLL serBll = new ServiceTypeBLL();

        Int32 resultCountBussinessProposalService;

        public void ToCreateNewBussinesProposalService(BussinessProposalServiceDTO bps)
        {
            ToCountCodeBussinessProposalService();

            if (resultCountBussinessProposalService == 0)
            {
                bps.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_bussinessProposalService";

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
                    MessageBox.Show("Error when trying to connect to the database " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Int32 ToCountCodeBussinessProposalService()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_bussinessProposalService";

            try
            {
                cmd.Connection = connection.ToConnect();
                OleDbDataReader dr = cmd.ExecuteReader();

                dr.Read();
                resultCountBussinessProposalService = dr.GetInt32(0);

                connection.ToDisconnect();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error when trying to connect to the database " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultCountBussinessProposalService;
        }

        public void ToSaveNewBussinessProposalService(BussinessProposalServiceDTO bps)
        {
            serDto.Description = bps.ServiceType;
            serBll.ToSelectCodeServiceType(serDto);

            cmd.CommandText = "INSERT INTO tb_bussinessProposalService (" +
                "id, " +
                "numberProposal, " +
                "quantity, " +
                "codeServiceType, " +
                "service, " +
                "unitaryValue, " +
                "amount) " +
                "VALUES (" +
                bps.Id + ", '" +
                bps.NumberProposal + "', " +
                bps.Quantity + ", " +
                serDto.Id + ", '" +
                bps.Service + "', " +
                bps.UnitityValue + ", " +                
                bps.Amount + ")";
            try
            {
                cmd.Connection = connection.ToConnect();
                cmd.ExecuteNonQuery();
                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ToUpdateBussinessProposalService(BussinessProposalServiceDTO bps)
        {
            serDto.Description = bps.ServiceType;
            serBll.ToSelectCodeServiceType(serDto);

            cmd.CommandText = "UPDATE tb_bussinessProposalService SET " +
                "quantity = " + bps.Quantity + ", " +
                "codeServiceType = " + serDto.Id + ", " +
                "service = '" + bps.Service + "', " +
                "unitaryValue = unitaryValue + (" + bps.UnitityValue + "), " +
                "amount = amount + (" + bps.Amount + ") " +
                "WHERE id = " + bps.Id;

            MessageBox.Show(cmd.CommandText);
            try
            {
                cmd.Connection = connection.ToConnect();
                cmd.ExecuteNonQuery();
                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ToDeleteBussinessProposalService(BussinessProposalServiceDTO bps)
        {
            cmd.CommandText = "DELETE FROM tb_bussinessProposalService WHERE id = " + bps.Id;

            try
            {
                cmd.Connection = connection.ToConnect();
                cmd.ExecuteNonQuery();
                connection.ToDisconnect();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao tentar conectar ao Banco de Dados" + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public List<BussinessProposalServiceDTO> ToListBussinessProposalService(BussinessProposalServiceDTO bps)
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposalService.id, " +
               "tb_bussinessProposalService.numberProposal, " +
               "tb_bussinessProposalService.quantity, " +
               "tb_ServiceType.description, " +
               "tb_bussinessProposalService.service, " +
               "tb_bussinessProposalService.unitaryValue, " +
               "tb_bussinessProposalService.amount " +
               "FROM (tb_bussinessProposalService " +
               "INNER JOIN tb_ServiceType ON tb_bussinessProposalService.codeServiceType = tb_ServiceType.id) " +
               "WHERE tb_bussinessProposalService.numberProposal = '" + bps.NumberProposal + "' " +
               "ORDER BY tb_bussinessProposalService.id ASC";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalServiceDTO> proposal = new List<BussinessProposalServiceDTO>(7);

            while (dr.Read())
            {
                BussinessProposalServiceDTO service = new BussinessProposalServiceDTO();

                service.Id = dr.GetInt32(0); //id
                service.NumberProposal = dr.GetString(1); //number proposal
                service.Quantity = dr.GetInt32(2); //quantity
                service.ServiceType = dr.GetString(3); //service type
                service.Service = dr.GetString(4); //service
                service.UnitityValue = dr.GetInt32(5) / 100; //unitary value
                service.Amount = dr.GetInt32(6) / 100; //amount

                proposal.Add(service);
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return proposal;
        }

        public List<BussinessProposalServiceDTO> ToSelectBussinessProposalService(BussinessProposalServiceDTO bps)
        {
            cmd.CommandText = "SELECT " +
               "tb_bussinessProposalService.id, " +
               "tb_bussinessProposalService.quantity, " +
               "tb_serviceType.description, " +
               "tb_bussinessProposalService.service, " +
               "tb_bussinessProposalService.unitaryValue, " +
               "tb_bussinessProposalService.amount " +
               "FROM (tb_bussinessProposalService " +
               "INNER JOIN tb_serviceType ON tb_bussinessProposalService.codeServiceType = tb_serviceType.id) " +
               "WHERE tb_bussinessProposalService.id = " + bps.Id;

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<BussinessProposalServiceDTO> serv = new List<BussinessProposalServiceDTO>(6);

            while (dr.Read())
            {
                serv.Add(new BussinessProposalServiceDTO());

                serv[0].Id = dr.GetInt32(0); //id
                serv[0].Quantity = dr.GetInt32(1); //number proposal
                serv[0].ServiceType = dr.GetString(2); //data proposal
                serv[0].Service = dr.GetString(3); //title
                serv[0].UnitityValue = dr.GetInt32(4) / 100; //description
                serv[0].Amount = dr.GetInt32(5) / 100; //client
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return serv;
        }




    }
}
