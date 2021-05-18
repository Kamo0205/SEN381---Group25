using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Business_Logic_Layer
{
    public enum clientSearchParameter
    {
        email,
        address,
        phone,
        id
    }

    public class ClientBusinessLogic
    {
        DBAccess db = new DBAccess();

        private List<Client> clients = new List<Client>();
        

        void deleteClient(string id)
        {
            try
            {
                db.DeleteClient(id: id);
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : deleteClient ERROR:" + e.Message);
                throw;
            }
        }

        public List<Client> searchClientByParameter(clientSearchParameter parameter,string query)
        {
            try
            {
                DataTable clientData = new DataTable();
                DataTable contractData = new DataTable();

                switch (parameter)
                {
                    case clientSearchParameter.email:
                        clientData = db.GetClientByEmail(email: query);
                        break;
                    case clientSearchParameter.address:
                        clientData = db.GetClientByAddress(address: query);
                        break;
                    case clientSearchParameter.phone:
                        clientData = db.GetClientByContactNumber(number: query);
                        break;
                    case clientSearchParameter.id:
                        clientData = db.GetClientByID(id: query);
                        break;
                    default:
                        break;
                }

                if (clientData.Rows.Count != 0)
                {
                    for (int i = 0; i < clientData.Rows.Count; i++)
                    {
                        contractData = db.ListContractsByClientID(clientData.Rows[i]["ClientID"].ToString());
                        string serviceLevel = contractData.Rows[i]["ServiceLevel"].ToString();

                        for (int j = 0; j < contractData.Rows.Count; j++)
                        {
                            if (serviceLevel == "Bronze")
                            {
                                clients.Add(new Bronze(data: clientData, i: i));
                            }
                            else if (serviceLevel == "Silver")
                            {
                                clients.Add(new Silver(data: clientData, i: i));
                            }
                            else if (serviceLevel == "Premium")
                            {
                                clients.Add(new Premium(data: clientData, i: i));
                            }
                            else
                            {
                                clients.Add(new Bronze(data: clientData, i: i));
                            }
                        }
                    }
                    return clients;
                }
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : searchClientByParameter ERROR:" + e.Message);
                throw;
            }
        }

        public void updateClient(Client client)
        {
            try
            {
                db.UpdateClient(client: client);
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : updateClient ERROR:" + e.Message);
                throw;
            }
        }

        public void updateClientPassword(Client client, string password)
        {
            try
            {
                db.UpdateClientPassword(client: client, password: password);
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : updateClientPassword ERROR:" + e.Message);
                throw;
            }
        }

        public void createClient(Client client, string password)
        {
            try
            {
                db.CreateClient(client: client, password: password);
            }
            catch (Exception e)
            {
                MessageBox.Show("ClientBusinessLogic : createClient ERROR:" + e.Message);
                throw;
            }
        }
    }
}
