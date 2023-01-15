using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using GestaoSEGSAL.DTO;
using GestaoSEGSAL.DAO;

namespace GestaoSEGSAL.BLL
{
    class CompanyBLL
    {
        ConnectionFactory connection = new ConnectionFactory();
        OleDbCommand cmd = new OleDbCommand();

        public void ToUpdateCompany(CompanyDTO c)
        {
            cmd.CommandText = "";

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

        public List<CompanyDTO> ToSelectCompany()
        {            
            cmd.CommandText = "SELECT " +
               "tb_company.id, " +
               "tb_company.socialReason, " +
               "tb_company.fantasyName, " +
               "tb_company.port, " +
               "tb_company.openDate, " +
               "tb_company.cnpj, " +
               "tb_company.stateRegistration," +
               "tb_company.cityRegistration, " +
               "tb_company.legalNature, " +
               "tb_company.address, " +
               "tb_company.complement, " +
               "tb_company.district, " +
               "tb_city.city, " +
               "tb_federationState.initials, " +
               "tb_company.postalCode, " +
               "tb_company.email, " +
               "tb_company.password, " +
               "tb_company.telephone, " +
               "tb_company.logo, " +
               "tb_company.logoPrint " +
               "FROM ((tb_company " +
               "INNER JOIN tb_city ON tb_company.codeCity = tb_city.id) " +
               "INNER JOIN tb_federationState ON tb_city.codeState = tb_federationState.id) " +
               "WHERE tb_company.id = 1";

            cmd.Connection = connection.ToConnect();
            OleDbDataReader dr = cmd.ExecuteReader();
            List<CompanyDTO> company = new List<CompanyDTO>(20);

            while (dr.Read())
            {
                company.Add(new CompanyDTO());

                company[0].Id = dr.GetInt32(0); //id
                company[0].SocialReason = dr.GetString(1); //social reason
                company[0].FantasyName = dr.GetString(2); //fantasy name
                company[0].Port = dr.GetString(3); //port
                company[0].OpenDate = dr.GetDateTime(4); //open date
                company[0].Cnpj = dr.GetString(5); //cnpj
                company[0].StateRegistration = dr.GetString(6); //state registration
                company[0].CityRegistration = dr.GetString(7); //city registration
                company[0].LegalNature = dr.GetString(8); //legal nature
                company[0].Address = dr.GetString(9); //address
                company[0].Complement = dr.GetString(10); //complement
                company[0].District = dr.GetString(11); //district
                company[0].City = dr.GetString(12); //city
                company[0].FederationState = dr.GetString(13); //federation state
                company[0].PostalCode = dr.GetString(14); //postalCode
                company[0].Email = dr.GetString(15); //email
                company[0].Password = dr.GetString(16); //password                
                company[0].Telephone = dr.GetString(17); //telephone
                company[0].Logo = dr.GetString(18); //logo
                company[0].LogoPrint = dr.GetString(19); //logoPrint
                //company[0].MainActivity = dr.GetString(20); //mainActivity
            }
            connection.ToDisconnect();
            cmd.Dispose();
            return company;
        }
    }
}
